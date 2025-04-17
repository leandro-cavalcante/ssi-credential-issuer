# Changelog

## [1.1.0-cfx-4](https://github.com/Cofinity-X/ssi-credential-issuer/compare/1.1.0-cfx-3...1.1.0-cfx-4) (2025-02-24)
### Added
* Enhanced API Response Body with 'externalTypeDetail' Object by adding the version to the response of owned credentials api.
  

## [1.1.0-cfx-4-rc.1](https://github.com/Cofinity-X/ssi-credential-issuer/compare/1.1.0-cfx-3...1.1.0-cfx-4-rc.1) (2025-02-12)
### Added
* Enhanced API Response Body with 'externalTypeDetail' Object by adding the version to the response of owned credentials api.
  

## [1.1.0-cfx-3](https://github.com/Cofinity-X/ssi-credential-issuer/compare/1.1.0-cfx-2...1.1.0-cfx-3) (2024-12-18)
### Added
* Seeding now contains the creation of BPN and MEMBERSHIP credential during migration
* Enhanced the functionality of the existing GET /api/issuer/useCaseParticipation endpoint to filter the returned list of use case participations by the status of the credentials (Active, Expired, or All).
* Updated the validation of existing filter for GET /api/issuer/useCaseParticipation to not accept numbers as values

### Fixed
* Updated the link to the correct Governance Framework credential.
* Updated Github actions versions by @dependabot


## [1.1.0-cfx-3-rc.3](https://github.com/Cofinity-X/ssi-credential-issuer/compare/1.1.0-cfx-3-rc.2...1.1.0-cfx-3-rc.3) (2024-12-05)
### What's Changed
* Updated the validation of existing filter for GET /api/issuer/useCaseParticipation to not accept numbers as values
* Seeding now contains the creation of BPN and MEMBERSHIP credential during migration
* Updated Github actions versions by @dependabot


## [1.1.0-cfx-3-rc.2](https://github.com/Cofinity-X/ssi-credential-issuer/compare/1.1.0-cfx-3-rc.1...1.1.0-cfx-3-rc.2) (2024-11-22)
### What's Changed
* Enhanced the functionality of the existing GET /api/issuer/useCaseParticipation endpoint to filter the returned list of use case participations by the status of the credentials (Active, Expired, or All).

## [1.1.0-cfx-3-rc.1](https://github.com/Cofinity-X/ssi-credential-issuer/compare/1.1.0-cfx-2...1.1.0-cfx-3-rc.1) (2024-11-21)
### What's Changed
* Updated the link to the correct Governance Framework credential.
 

## [1.1.0-cfx-2](https://github.com/Cofinity-X/ssi-credential-issuer/compare/1.1.0-cfx-1-rc.1...1.1.0-cfx-2) (2024-10-18)
### What's Changed
* **seeding:** Updated the URL link to the correct data exchange file ([#51](https://github.com/Cofinity-X/ssi-credential-issuer/pull/51)) ([5b66803](https://github.com/Cofinity-X/ssi-credential-issuer/commit/5b6680371c3abede91d52aef7a1db4f1fbdb1220))
* **migrations:** Restructured the Seeder folder by adding two different data folders, Cofinityx/Prod and CofinityX/NonProd ([#47](https://github.com/Cofinity-X/ssi-credential-issuer/pull/47)) ([7be7e1e](https://github.com/Cofinity-X/ssi-credential-issuer/commit/7be7e1e3e022146cb0ad6f5e466db86dc541e7b6))
* **seeding:** Updated the data set verified credential external type detail version by adapting the valid_from date to oct-2024([#37](https://github.com/Cofinity-X/ssi-credential-issuer/pull/37)) ([1b42e2f](https://github.com/Cofinity-X/ssi-credential-issuer/commit/1b42e2f7664c35044fdd311c2b409ecadafec34e))
* Verified credential type assigned use cases: Updaded the correct DCM Puris ID ([#28](https://github.com/Cofinity-X/ssi-credential-issuer/pull/28)) ([1b42e2f](https://github.com/Cofinity-X/ssi-credential-issuer/commit/466682dd8fc4b468b0c9bb67e0e7fcc73dde2ea6))
* **issuer-service:** Added the correct type for owned-credentials method ([#6](https://github.com/Cofinity-X/ssi-credential-issuer/pull/6)) ([2140222](https://github.com/Cofinity-X/ssi-credential-issuer/commit/2140222b784e5e4b3b87062b344e563ac935e1ae))
* Credentials: Added missing expiry date for bpnl and membership credentials ([#4](https://github.com/Cofinity-X/ssi-credential-issuer/pull/4)) ([134de56](https://github.com/Cofinity-X/ssi-credential-issuer/commit/134de569e0304624af5b0fbdc75c00db06a64958))
* **credentialType:** rename membership certificate to membership ([#217](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/217)) ([818a9a3](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/818a9a32090322d83cc7ed47e061922f9a1f3d03)), closes [#216](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/216)
* set companyName for credentialApproval ([#218](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/218)) ([32bb69c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/32bb69ce1364da275cd8538b6fc5b5a75e62961a)), closes [#215](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/215)
* release 1.1.0-rc.2 ([6d3f95c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/6d3f95c3741106373a30ff6b79d98c12f05b14d0))
* **credentials:** add Data_Exchange_Governance credential [#198](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/198) ([3702e5c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/3702e5c5f91e67cf1f84f9f03e549968f7e168b0))
* **helm:** consolidate structure in values.yaml  ([#172](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/172)) ([1eceb1f](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/1eceb1fbc659d567fa762d6014f67b8fa08e2eed))
* **seeding:** add test seeding data ([#121](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/121)) ([c8f07b2](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/c8f07b25772f6bc35603439aad594b7a4b474356)), closes [#118](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/118)
* add the correct type for owned-credentials method [#193](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/193) ([796415c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/796415c05324bcf9d5f48b1cbf9dadda6ec23704))
* adjust exceptionhandling for encryption ([#185](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/185)) ([6dcf2f5](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/6dcf2f5c0eb0937042061e4d0420bddd29d4d26f))
* **credential:** adjust naming for membership credential ([#176](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/176)) ([ea2d55f](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/ea2d55fb27dd4ff057b791ed6941d94af4b8d650)), closes [#175](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/175)
* **cronjob expiry:** add the missing environment value for portal ([#196](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/196)) ([dc6b130](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/dc6b13002797dd733694f046f4ec19bc476ecc4e)), closes [#195](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/195)
* **document:** adjust document name for presentation docs ([#174](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/174)) ([e10cbcb](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/e10cbcbb03d11e03f9ae5219e1a0163dbf88b280)), closes [#166](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/166)
* **encryptionKey:** align credential and wallet config ([#201](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/201)) ([1e1ca59](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/1e1ca59ffcb60ce55c2c68da31c889d8cd490939)), closes [#197](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/197)
* **expiry:** adjust removal of companySsiDetails ([#208](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/208)) ([897a735](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/897a7350f39d378338e411c9b3083218634eac93)), closes [#195](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/195)
* **expiry:** set expiry to max 1 year ([#173](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/173)) ([46d23e8](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/46d23e8cfb192b6cd1aece437d348d42b88d54dd))
* **image-build:** change from emulation to cross-compile ([#181](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/181)) ([aa378a8](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/aa378a8849ce10aee523bd3c998c49ab33e943cc))
* implement Expiry Date for BPNL and MembershipMerge [#192](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/192) ([54dbd0e](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/54dbd0e374ca2e0da41ce63c91ee626c57059888))
* release 1.1.0-rc.1 ([f767676](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/f7676767ef475142bb374935fc13d7b8eadf99a0))* establish a database to handle credential requests, verified credentials, document proof, and managing lifecycle ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a GET endpoint for retrieving own credential requests with their current status ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a GET endpoint to retrieve supported credential types, allowing customers to see all credentials that can be requested ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a job to store newly created verified credentials inside the holder wallet ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a notification system for credential expiry to alert holders ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a processes worker to create credentials and submit them for signature by the issuer wallet ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish an admin endpoint to retrieve credential requests for the purpose of approval or rejection ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish endpoints to approve or reject customer credential requests ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish POST endpoints for credential requests for BPN (Business Partner Number), Membership, and Framework Agreement credentials ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* implement a job to run expiry validation and revocation of credentials ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* **issuer:** add filter to /api/issuer ([#120](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/120)) ([ea5d91a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/ea5d91a30b18d70c0bcc46555141db6762f6af56))
* **revocation:** add endpoints to revoke credentials ([#43](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/43)) ([dc9c70d](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/dc9c70da4c0bcba979c71b5c636526c13041c774))
* **ssi:** adjust framework creation endpoint ([#70](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/70)) ([2d06fe6](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/2d06fe65365b644a209900a464c6823cb0db372e))
* chore: Update metrics logging by @arnabcx in https://github.com/Cofinity-X/ssi-credential-issuer/pull/55

### Fix:
* Removed the option for the metrics output to the console output.

### Known Knowns
* **Credential re-issuance:** is not working.
* **Limitations:** Retrigger functions are limited in case of interface errors.

## [1.1.0-rc.4](https://github.com/eclipse-tractusx/ssi-credential-issuer/compare/v1.1.0-rc.3...v1.1.0-rc.4) (2024-09-30)
* **seeding:** Updated the URL link to the correct data exchange file ([#51](https://github.com/Cofinity-X/ssi-credential-issuer/pull/51)) ([5b66803](https://github.com/Cofinity-X/ssi-credential-issuer/commit/5b6680371c3abede91d52aef7a1db4f1fbdb1220))


### Bug Fixes

## [1.1.0-rc.3](https://github.com/eclipse-tractusx/ssi-credential-issuer/compare/v1.1.0-rc.2...v1.1.0-rc.3) (2024-09-20)


### Bug Fixes

* **migrations:** Restructured the Seeder folder by adding two different data folders, Cofinityx/Prod and CofinityX/NonProd ([#47](https://github.com/Cofinity-X/ssi-credential-issuer/pull/47)) ([7be7e1e](https://github.com/Cofinity-X/ssi-credential-issuer/commit/7be7e1e3e022146cb0ad6f5e466db86dc541e7b6))
* **seeding:** Updated the data set verified credential external type detail version by adapting the valid_from date to oct-2024([#37](https://github.com/Cofinity-X/ssi-credential-issuer/pull/37)) ([1b42e2f](https://github.com/Cofinity-X/ssi-credential-issuer/commit/1b42e2f7664c35044fdd311c2b409ecadafec34e))
* Verified credential type assigned use cases: Updaded the correct DCM Puris ID ([#28](https://github.com/Cofinity-X/ssi-credential-issuer/pull/28)) ([1b42e2f](https://github.com/Cofinity-X/ssi-credential-issuer/commit/466682dd8fc4b468b0c9bb67e0e7fcc73dde2ea6))
* **issuer-service:** Added the correct type for owned-credentials method ([#6](https://github.com/Cofinity-X/ssi-credential-issuer/pull/6)) ([2140222](https://github.com/Cofinity-X/ssi-credential-issuer/commit/2140222b784e5e4b3b87062b344e563ac935e1ae))
* Credentials: Added missing expiry date for bpnl and membership credentials ([#4](https://github.com/Cofinity-X/ssi-credential-issuer/pull/4)) ([134de56](https://github.com/Cofinity-X/ssi-credential-issuer/commit/134de569e0304624af5b0fbdc75c00db06a64958))



## [1.1.0-rc.2](https://github.com/eclipse-tractusx/ssi-credential-issuer/compare/v1.1.0-rc.1...v1.1.0-rc.2) (2024-07-25)


### Bug Fixes

* **credentialType:** rename membership certificate to membership ([#217](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/217)) ([818a9a3](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/818a9a32090322d83cc7ed47e061922f9a1f3d03)), closes [#216](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/216)
* set companyName for credentialApproval ([#218](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/218)) ([32bb69c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/32bb69ce1364da275cd8538b6fc5b5a75e62961a)), closes [#215](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/215)


### Miscellaneous Chores

* release 1.1.0-rc.2 ([6d3f95c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/6d3f95c3741106373a30ff6b79d98c12f05b14d0))

## [1.1.0-rc.1](https://github.com/eclipse-tractusx/ssi-credential-issuer/compare/v1.0.0...v1.1.0-rc.1) (2024-07-17)


### Features

* **credentials:** add Data_Exchange_Governance credential [#198](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/198) ([3702e5c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/3702e5c5f91e67cf1f84f9f03e549968f7e168b0))
* **helm:** consolidate structure in values.yaml  ([#172](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/172)) ([1eceb1f](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/1eceb1fbc659d567fa762d6014f67b8fa08e2eed))
* **seeding:** add test seeding data ([#121](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/121)) ([c8f07b2](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/c8f07b25772f6bc35603439aad594b7a4b474356)), closes [#118](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/118)


### Bug Fixes

* add the correct type for owned-credentials method [#193](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/193) ([796415c](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/796415c05324bcf9d5f48b1cbf9dadda6ec23704))
* adjust exceptionhandling for encryption ([#185](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/185)) ([6dcf2f5](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/6dcf2f5c0eb0937042061e4d0420bddd29d4d26f))
* **credential:** adjust naming for membership credential ([#176](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/176)) ([ea2d55f](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/ea2d55fb27dd4ff057b791ed6941d94af4b8d650)), closes [#175](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/175)
* **cronjob expiry:** add the missing environment value for portal ([#196](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/196)) ([dc6b130](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/dc6b13002797dd733694f046f4ec19bc476ecc4e)), closes [#195](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/195)
* **document:** adjust document name for presentation docs ([#174](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/174)) ([e10cbcb](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/e10cbcbb03d11e03f9ae5219e1a0163dbf88b280)), closes [#166](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/166)
* **encryptionKey:** align credential and wallet config ([#201](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/201)) ([1e1ca59](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/1e1ca59ffcb60ce55c2c68da31c889d8cd490939)), closes [#197](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/197)
* **expiry:** adjust removal of companySsiDetails ([#208](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/208)) ([897a735](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/897a7350f39d378338e411c9b3083218634eac93)), closes [#195](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/195)
* **expiry:** set expiry to max 1 year ([#173](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/173)) ([46d23e8](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/46d23e8cfb192b6cd1aece437d348d42b88d54dd))
* **image-build:** change from emulation to cross-compile ([#181](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/181)) ([aa378a8](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/aa378a8849ce10aee523bd3c998c49ab33e943cc))
* implement Expiry Date for BPNL and MembershipMerge [#192](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/192) ([54dbd0e](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/54dbd0e374ca2e0da41ce63c91ee626c57059888))


### Miscellaneous Chores

* release 1.1.0-rc.1 ([f767676](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/f7676767ef475142bb374935fc13d7b8eadf99a0))

## [1.0.0](https://github.com/eclipse-tractusx/ssi-credential-issuer/compare/v1.0.0...v1.0.0) (2024-05-27)

### Features

* establish a database to handle credential requests, verified credentials, document proof, and managing lifecycle ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a GET endpoint for retrieving own credential requests with their current status ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a GET endpoint to retrieve supported credential types, allowing customers to see all credentials that can be requested ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a job to store newly created verified credentials inside the holder wallet ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a notification system for credential expiry to alert holders ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish a processes worker to create credentials and submit them for signature by the issuer wallet ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish an admin endpoint to retrieve credential requests for the purpose of approval or rejection ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish endpoints to approve or reject customer credential requests ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* establish POST endpoints for credential requests for BPN (Business Partner Number), Membership, and Framework Agreement credentials ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* implement a job to run expiry validation and revocation of credentials ([609567a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/609567a6131fdcb1f12ea8a6653b5dbc9963816e))
* **issuer:** add filter to /api/issuer ([#120](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/120)) ([ea5d91a](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/ea5d91a30b18d70c0bcc46555141db6762f6af56))
* **revocation:** add endpoints to revoke credentials ([#43](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/43)) ([dc9c70d](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/dc9c70da4c0bcba979c71b5c636526c13041c774))
* **ssi:** adjust framework creation endpoint ([#70](https://github.com/eclipse-tractusx/ssi-credential-issuer/issues/70)) ([2d06fe6](https://github.com/eclipse-tractusx/ssi-credential-issuer/commit/2d06fe65365b644a209900a464c6823cb0db372e))
