# Version history

## Version 2.11.0, released 2024-03-25

### Breaking changes

The `SearchRelatedAccountGroupMemberships` method and related
request now accept a ProjectName instead of a
`RelatedAccountGroupName`. This is a bug fix; the server-side
behavior has not changed. Although this is clearly a breaking change
in the client library, no caller would have been able to use the
previous functionality, so we are releasing this as a minor version
rather than the normal new major version after a breaking change. We
believe this will minimize customer disruption. Please file an issue
if this change causes problems for you.

### New features

- Existing resource_reference option of the field name is removed from message `google.cloud.recaptchaenterprise.v1.RelatedAccountGroupMemberShip` ([commit db147ef](https://github.com/googleapis/google-cloud-dotnet/commit/db147ef47e26899c28bed40651fab1dffffb0213))
- Existing resource_reference option of the field name is removed from message `google.cloud.recaptchaenterprise.v1.RelatedAccountGroup` ([commit db147ef](https://github.com/googleapis/google-cloud-dotnet/commit/db147ef47e26899c28bed40651fab1dffffb0213))
- Add Cloudflare key creation support ([commit db147ef](https://github.com/googleapis/google-cloud-dotnet/commit/db147ef47e26899c28bed40651fab1dffffb0213))

## Version 2.10.0, released 2024-03-13

### New features

- Add include_recaptcha_script for as a new action in firewall policies ([commit d9e61ce](https://github.com/googleapis/google-cloud-dotnet/commit/d9e61ceccc664f21973cc0e20833f9fabe1b20b3))

## Version 2.9.0, released 2024-02-20

### New features

- Add an API method for reordering firewall policies ([commit 3a8650e](https://github.com/googleapis/google-cloud-dotnet/commit/3a8650eeeec900cc533908c62cb610336425b517))

### Documentation improvements

- Update comment for `AccountVerificationInfo.username` ([commit 7560af8](https://github.com/googleapis/google-cloud-dotnet/commit/7560af85aa6f677214b9a19d5eeeef15f30c7f64))

## Version 2.8.0, released 2023-12-11

### New features

- Added stable account identifier to related group membership resources, and deprecated hashed identifier field ([commit 45bfaad](https://github.com/googleapis/google-cloud-dotnet/commit/45bfaad51e9d0a9564872844963f9398caffc8cc))

### Documentation improvements

- Noted applicable fields as resource identifiers ([commit 45bfaad](https://github.com/googleapis/google-cloud-dotnet/commit/45bfaad51e9d0a9564872844963f9398caffc8cc))

## Version 2.7.0, released 2023-12-04

### New features

- Added AnnotateAssessmentRequest.account_id ([commit eff599a](https://github.com/googleapis/google-cloud-dotnet/commit/eff599a1f92c267a7c7285baf5ef6a88621dc964))
- Added Event.user_info ([commit eff599a](https://github.com/googleapis/google-cloud-dotnet/commit/eff599a1f92c267a7c7285baf5ef6a88621dc964))

### Documentation improvements

- Updated comments ([commit eff599a](https://github.com/googleapis/google-cloud-dotnet/commit/eff599a1f92c267a7c7285baf5ef6a88621dc964))

## Version 2.6.0, released 2023-11-13

### Documentation improvements

- Updated comments explaining if a field is optional or required ([commit 91d1b84](https://github.com/googleapis/google-cloud-dotnet/commit/91d1b8400e4200f791e33b65a1521a87bf13625d))

## Version 2.5.0, released 2023-10-30

### New features

- FirewallPolicy CRUD API ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added Assessment.firewall_policy_assessment, fraud_signals ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added new fields to Event message ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added RiskAnalysis.extended_verdict_reasons ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added FraudPreventionAssessment.behavioral_trust_verdict ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added AndroidKeySettings.support_non_google_app_store_distribution ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added IOSKeySettings.apple_developer_id ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added WafFeature.EXPRESS enum value ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))
- Added WafService.FASTLY enum value ([commit 0eea6bd](https://github.com/googleapis/google-cloud-dotnet/commit/0eea6bd16c906a211c836ec4b7b62e1a3a215d2b))

## Version 2.4.0, released 2023-03-20

### New features

- Add reCAPTCHA Enterprise Fraud Prevention API ([commit c655f99](https://github.com/googleapis/google-cloud-dotnet/commit/c655f99aa7e6579a58b7c0b1dd8b4c3126a96fdc))

## Version 2.3.0, released 2022-12-14

### New features

- Add account_verification field to Assessment for MFA ([commit e703e5b](https://github.com/googleapis/google-cloud-dotnet/commit/e703e5b1cc29c00853d76d788bd91296587048d8))

## Version 2.2.0, released 2022-10-17

### New features

- Add RetrieveLegacySecretKey method ([commit e6d4fea](https://github.com/googleapis/google-cloud-dotnet/commit/e6d4feaf59fde91f0270b42d0dad595a235d1f46))
- Add annotation reasons REFUND, REFUND_FRAUD, TRANSACTION_ACCEPTED, TRANSACTION_DECLINED and SOCIAL_SPAM ([commit e6d4fea](https://github.com/googleapis/google-cloud-dotnet/commit/e6d4feaf59fde91f0270b42d0dad595a235d1f46))

## Version 2.1.0, released 2022-07-11

### Bug fixes

- **BREAKING CHANGE** Set the right field number for reCAPTCHA private password leak ([commit 887e7fe](https://github.com/googleapis/google-cloud-dotnet/commit/887e7fe16c53f0194dc7618e61a9b4ec5a8fb0c7))

## Version 2.0.0, released 2022-06-08

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.


### API-specific breaking change

- Rename parent to project in SearchRelatedAccountGroupMembershipsRequest ([commit 4ff737b](https://github.com/googleapis/google-cloud-dotnet/commit/4ff737b1dbfb31525c0632419cd3799f4fa1bd1c))

### New features

- Add support for Password Check through the private_password_leak_verification field in the reCAPTCHA Assessment ([commit eee8397](https://github.com/googleapis/google-cloud-dotnet/commit/eee8397500f513afcdd3565b1ed8d4bfe8301554))
- Introduced WafSettings ([commit 4ff737b](https://github.com/googleapis/google-cloud-dotnet/commit/4ff737b1dbfb31525c0632419cd3799f4fa1bd1c))

## Version 1.6.0, released 2021-12-07

- [Commit 308c733](https://github.com/googleapis/google-cloud-dotnet/commit/308c733): feat: add new reCAPTCHA Enterprise fraud annotations

## Version 1.5.0, released 2021-11-10

- [Commit fcce878](https://github.com/googleapis/google-cloud-dotnet/commit/fcce878):
  - feat: add reCAPTCHA Enterprise account defender API methods
  - This adds the following API methods to support the Preview release of reCAPTCHA Enterprise account defender: ListRelatedAccountGroups, ListRelatedAccountGroupMemberships, and SearchRelatedAccountGroupMemberships. Additionally it modifies the existing createAssessment API method to add a new hashed_account_id parameter along with AccountDefenderAssessment return value.

## Version 1.4.0, released 2021-09-24

- [Commit 20d6309](https://github.com/googleapis/google-cloud-dotnet/commit/20d6309): feat: add GetMetrics and MigrateKey methods to reCAPTCHA enterprise API

## Version 1.3.0, released 2021-09-01

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.1.0, released 2020-10-23

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 1.0.0, released 2020-04-08

No API surface changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-03-23

Initial beta release.


