# Version history

## Version 2.5.0, released 2023-03-20

### New features

- Add show_future_offers to ListOffers ([commit cb5ba9f](https://github.com/googleapis/google-cloud-dotnet/commit/cb5ba9fcb6aee129ec105af90932a139534e3b76))
- Add ListEntitlementChanges ([commit cb5ba9f](https://github.com/googleapis/google-cloud-dotnet/commit/cb5ba9fcb6aee129ec105af90932a139534e3b76))

## Version 2.4.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.3.0, released 2022-12-14

### New features

- Add support for granular repricing configurations via SkuGroups in Cloud Channel Repricing APIs ([commit fe238c6](https://github.com/googleapis/google-cloud-dotnet/commit/fe238c6dd1d6c47b9421ad53ae7a90b89b7c80e6))

## Version 2.2.0, released 2022-11-10

### New features

- Add deal_code field to message Offer ([commit 454d398](https://github.com/googleapis/google-cloud-dotnet/commit/454d398f44d71fc3666c1d40d9bf7cabbba7e430))

## Version 2.1.0, released 2022-11-02

### New features

- Add CloudChannelReportsService to CloudChannel API ([commit 8ddf7cc](https://github.com/googleapis/google-cloud-dotnet/commit/8ddf7cc80ad604df6d5bff81e3a863c92680d702))

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


## Version 1.7.0, released 2022-04-26

### New features

- Add API definitions for Cloud Channel Repricing APIs ([commit d654082](https://github.com/googleapis/google-cloud-dotnet/commit/d6540821516272203d41affeda5df0ef4eae31bc))
- Add new enum value, new filter in ListCustomersRequest of Cloud Channel API ([commit dfdc095](https://github.com/googleapis/google-cloud-dotnet/commit/dfdc095dd2ee4c8a91cd9c8dd1960906052033f8))

### Documentation improvements

- Clarify language ([commit 1641322](https://github.com/googleapis/google-cloud-dotnet/commit/1641322b44efbd08a2d62b67468029b1ae0e565c))
- Change description for enum default value ([commit 5a4f37b](https://github.com/googleapis/google-cloud-dotnet/commit/5a4f37bacef8f0b3cb22d9ebf466fc0ab1e50eca))
- Change description for GCP ProvisionedService.provisioning_id value ([commit b30248e](https://github.com/googleapis/google-cloud-dotnet/commit/b30248ea2a0cc0066becda3f56eaa33fed29e157))
## Version 1.6.0, released 2021-12-07

- [Commit 2382311](https://github.com/googleapis/google-cloud-dotnet/commit/2382311): docs: Small clarification

## Version 1.5.0, released 2021-11-10

- [Commit 8f5d443](https://github.com/googleapis/google-cloud-dotnet/commit/8f5d443): docs: clarified usage of entitlement parameters
- [Commit bf3d935](https://github.com/googleapis/google-cloud-dotnet/commit/bf3d935): feat: add resource type to ChannelPartnerLink

## Version 1.4.0, released 2021-09-24

- [Commit 7210495](https://github.com/googleapis/google-cloud-dotnet/commit/7210495):
  - feat: add API ImportCustomer for Cloud Channel API
  - docs: update comments for a few fields

## Version 1.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.2.0, released 2021-06-22

- [Commit 01c154e](https://github.com/googleapis/google-cloud-dotnet/commit/01c154e):
  - feat: Add/Update API definitions for Cloud Channel API, including
  - * Update descriptions of APIs.
  - * Add additional_bindings to HTTP annotations of Customer related APIs (list/create/get/update/delete).
  - * Add a new LookupOffer RPC and LookupOfferRequest proto.
  - * Add a new enum value LICENSE_CAP_CHANGED to enum EntitlementEvent.Type.

## Version 1.1.0, released 2021-04-29

- [Commit 8f5a62b](https://github.com/googleapis/google-cloud-dotnet/commit/8f5a62b):
  - docs: Update documentation comments to match tone and style with the rest of Cloud documentation.
  - feat: Adding customer level pubsub events for primary domain verification and primary domain change.
  - feat: Enabled support for boolean as an allowed parameter value.
  - feat: Added legacy_sku field to TransferableSku.

## Version 1.0.0, released 2021-03-03

- [Commit 1620a3a](https://github.com/googleapis/google-cloud-dotnet/commit/1620a3a):
  - feat: addition of billing_account field on Plan
  - docs: clarification that valid address lines are required for all customers
- [Commit f2fdc8f](https://github.com/googleapis/google-cloud-dotnet/commit/f2fdc8f):
  - docs: Documentation update
  - fix!: Removal of TransferableSkus fields `is_commitment` and `commitment_end_timestamp`
- [Commit 59e5691](https://github.com/googleapis/google-cloud-dotnet/commit/59e5691): feat: Add Pub/Sub endpoints for Cloud Channel API.

The breaking change to TransferableSkus was due to the fields having
accidentally been included despite deprecation in previews.

## Version 1.0.0-beta01, released 2021-01-13

Initial release.
