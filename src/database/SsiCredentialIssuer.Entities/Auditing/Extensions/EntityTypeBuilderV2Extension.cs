/********************************************************************************
 * Copyright (c) 2024 Contributors to the Eclipse Foundation
 *
 * See the NOTICE file(s) distributed with this work for additional
 * information regarding copyright ownership.
 *
 * This program and the accompanying materials are made available under the
 * terms of the Apache License, Version 2.0 which is available at
 * https://www.apache.org/licenses/LICENSE-2.0.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 *
 * SPDX-License-Identifier: Apache-2.0
 ********************************************************************************/

using Laraue.EfCoreTriggers.Common.Extensions;
using Laraue.EfCoreTriggers.Common.TriggerBuilders.TableRefs;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.Eclipse.TractusX.Portal.Backend.Framework.ErrorHandling;
using Org.Eclipse.TractusX.Portal.Backend.Framework.Linq;
using Org.Eclipse.TractusX.SsiCredentialIssuer.Entities.Auditing.Attributes;
using Org.Eclipse.TractusX.SsiCredentialIssuer.Entities.Auditing.Enums;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace Org.Eclipse.TractusX.SsiCredentialIssuer.Entities.Auditing.Extensions;

public static class EntityTypeBuilderV2Extension
{
    public static EntityTypeBuilder<TEntity> HasAuditV2Triggers<TEntity, TAuditEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : class, IAuditableV2 where TAuditEntity : class, IAuditEntityV2
    {
        var (auditEntityType, sourceProperties, auditProperties, targetProperties) = typeof(TEntity).GetAuditV2PropertyInformation() ?? throw new ConfigurationException($"{typeof(TEntity)} must be annotated with {nameof(AuditEntityV2Attribute)}");
        if (typeof(TAuditEntity) != auditEntityType)
        {
            throw new ConfigurationException($"{typeof(TEntity).Name} is annotated with {nameof(AuditEntityV2Attribute)} referring to a different audit entity type {auditEntityType.Name} then {typeof(TAuditEntity).Name}");
        }

        sourceProperties.IntersectBy(auditProperties.Select(x => x.Name), p => p.Name).IfAny(
            illegalProperties => throw new ConfigurationException($"{typeof(TEntity).Name} is must not declare any of the following properties: {string.Join(", ", illegalProperties.Select(x => x.Name))}"));

        sourceProperties.ExceptBy(targetProperties.Select(x => x.Name), p => p.Name).IfAny(
            missingProperties => throw new ArgumentException($"{typeof(TAuditEntity).Name} is missing the following properties: {string.Join(", ", missingProperties.Select(x => x.Name))}"));

        if (!Array.Exists(
            typeof(TAuditEntity).GetProperties(),
            p => p.Name == AuditPropertyV2Names.AuditV2Id.ToString() && p.CustomAttributes.Any(a => a.AttributeType == typeof(KeyAttribute))))
        {
            throw new ConfigurationException($"{typeof(TAuditEntity).Name}.{AuditPropertyV2Names.AuditV2Id} must be marked as primary key by attribute {typeof(KeyAttribute).Name}");
        }

        var insertEditorProperty = sourceProperties.SingleOrDefault(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(AuditInsertEditorV2Attribute)));
        var lastEditorProperty = sourceProperties.SingleOrDefault(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(LastEditorV2Attribute)));

        return builder
            .AfterInsert(trigger =>
                trigger.Action(action =>
                    action.Insert(CreateNewAuditEntityExpression<TEntity, TAuditEntity>(sourceProperties, insertEditorProperty ?? lastEditorProperty))))
            .AfterUpdate(trigger =>
                trigger.Action(action =>
                    action.Insert(CreateUpdateAuditEntityExpression<TEntity, TAuditEntity>(sourceProperties, lastEditorProperty))));
    }

    private static Expression<Func<NewTableRef<TEntity>, TAuditEntity>> CreateNewAuditEntityExpression<TEntity, TAuditEntity>(IEnumerable<PropertyInfo> sourceProperties, PropertyInfo? lastEditorProperty) where TEntity : class
    {
        var entity = Expression.Parameter(typeof(NewTableRef<TEntity>), "entity");

        var newPropertyInfo = typeof(NewTableRef<TEntity>).GetProperty("New");
        if (newPropertyInfo == null)
        {
            throw new UnexpectedConditionException($"{nameof(NewTableRef<TEntity>)} must have property New");
        }

        var propertyExpression = Expression.Property(entity, newPropertyInfo);
        return Expression.Lambda<Func<NewTableRef<TEntity>, TAuditEntity>>(
            CreateAuditEntityExpression<TAuditEntity>(sourceProperties, AuditOperationId.INSERT, propertyExpression, lastEditorProperty),
            entity);
    }

    private static Expression<Func<OldAndNewTableRefs<TEntity>, TAuditEntity>> CreateUpdateAuditEntityExpression<TEntity, TAuditEntity>(IEnumerable<PropertyInfo> sourceProperties, PropertyInfo? lastEditorProperty) where TEntity : class
    {
        var entity = Expression.Parameter(typeof(OldAndNewTableRefs<TEntity>), "entity");

        var newPropertyInfo = typeof(OldAndNewTableRefs<TEntity>).GetProperty("New");
        if (newPropertyInfo == null)
        {
            throw new UnexpectedConditionException($"{nameof(OldAndNewTableRefs<TEntity>)} must have property New");
        }

        var propertyExpression = Expression.Property(entity, newPropertyInfo);
        return Expression.Lambda<Func<OldAndNewTableRefs<TEntity>, TAuditEntity>>(
            CreateAuditEntityExpression<TAuditEntity>(sourceProperties, AuditOperationId.UPDATE, propertyExpression, lastEditorProperty),
            entity);
    }

    private static MemberInitExpression CreateAuditEntityExpression<TAuditEntity>(IEnumerable<PropertyInfo> sourceProperties, AuditOperationId auditOperationId, Expression entity, PropertyInfo? lastEditorProperty)
    {
        var memberBindings = sourceProperties.Select(p =>
                CreateMemberAssignment(typeof(TAuditEntity).GetMember(p.Name)[0], Expression.Property(entity, p)))
            .Append(CreateMemberAssignment(typeof(TAuditEntity).GetMember(AuditPropertyV2Names.AuditV2Id.ToString())[0], Expression.Call(typeof(Guid).GetMethod(nameof(Guid.NewGuid), BindingFlags.Public | BindingFlags.Static)!)))
            .Append(CreateMemberAssignment(typeof(TAuditEntity).GetMember(AuditPropertyV2Names.AuditV2OperationId.ToString())[0], Expression.Constant(auditOperationId)))
            .Append(CreateMemberAssignment(typeof(TAuditEntity).GetMember(AuditPropertyV2Names.AuditV2DateLastChanged.ToString())[0], Expression.MakeMemberAccess(null, typeof(DateTimeOffset).GetProperty(nameof(DateTimeOffset.UtcNow))!)));

        if (lastEditorProperty != null)
        {
            memberBindings = memberBindings.Append(CreateMemberAssignment(typeof(TAuditEntity).GetMember(AuditPropertyV2Names.AuditV2LastEditorId.ToString())[0], Expression.Property(entity, lastEditorProperty)));
        }

        return Expression.MemberInit(
            Expression.New(typeof(TAuditEntity)),
            memberBindings);
    }

    private static MemberAssignment CreateMemberAssignment(MemberInfo member, Expression expression)
    {
        try
        {
            return Expression.Bind(member, expression);
        }
        catch (Exception e)
        {
            throw new ArgumentException($"{member.DeclaringType?.Name}.{member.Name} is not assignable from {expression}, {e.Message}", e);
        }
    }
}
