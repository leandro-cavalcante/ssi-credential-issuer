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

using Org.Eclipse.TractusX.Portal.Backend.Framework.Models.Configuration;
using Org.Eclipse.TractusX.Portal.Backend.Framework.Token;
using System.ComponentModel.DataAnnotations;

namespace Org.Eclipse.TractusX.SsiCredentialIssuer.Wallet.Service.DependencyInjection;

public class WalletSettings : BasicAuthSettings
{
    [Required(AllowEmptyStrings = false)]
    public string BaseAddress { get; set; } = null!;

    [Required]
    public IEnumerable<EncryptionModeConfig> EncryptionConfigs { get; set; } = null!;

    [Required]
    public int EncryptionConfigIndex { get; set; }

    [Required]
    public string WalletApplication { get; set; } = null!;

    [Required]
    public string CreateCredentialPath { get; set; } = null!;

    [Required]
    public string SignCredentialPath { get; set; } = null!;

    [Required]
    public string GetCredentialPath { get; set; } = null!;

    [Required]
    public string RevokeCredentialPath { get; set; } = null!;
}
