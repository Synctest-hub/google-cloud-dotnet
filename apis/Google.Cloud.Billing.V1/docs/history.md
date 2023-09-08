# Version history

## Version 3.4.0, released 2023-09-08

### Breaking change

The resource annotation for `GetProjectBillingInfoRequest.Name` has changed from referring to a `ProjectBillingInfoName` to a `ProjectName`. This means `GetProjectBillingInfoRequest.ProjectBillingInfoName` has been removed, and `GetProjectBillingInfo.ProjectName` has replaced it, and the overloads to the `GetProjectName` method have changed accordingly.

Although this is clearly a breaking change (as removing a public property always is), we have not taken a major version bump as any customers whose source code is broken by this would already have been broken when making a request. Customers whose code is already working will not be affected.

### Bug fixes

- Fixed resource_reference for name in GetProjectBillingInfo ([commit 58d6168](https://github.com/googleapis/google-cloud-dotnet/commit/58d6168573e2039bae924d9a3e15ffe32aa38f0d))

### Documentation improvements

- Update comments ([commit 5de2c9b](https://github.com/googleapis/google-cloud-dotnet/commit/5de2c9b2badcd4b58642b12c5fa5413ed96be75f))

## Version 3.3.0, released 2023-06-20

### New features

- Added resource_reference for name in GetProjectBillingInfoRequest message ([commit a092965](https://github.com/googleapis/google-cloud-dotnet/commit/a092965c2e524581712dec037b73d2f3c0931abb))

## Version 3.2.0, released 2023-01-18

### New features

- Enable REST transport in C# ([commit 0f8560c](https://github.com/googleapis/google-cloud-dotnet/commit/0f8560c840725bf41bc060c8beecafc7d99f38eb))

## Version 3.1.0, released 2022-12-01

### Bug fixes

- More oauth scopes ([commit 79b9658](https://github.com/googleapis/google-cloud-dotnet/commit/79b965802715666be335a721886668bcbcd630dc))

### New features

- Added Sku.geo_taxonomy ([commit 79b9658](https://github.com/googleapis/google-cloud-dotnet/commit/79b965802715666be335a721886668bcbcd630dc))

## Version 3.0.0, released 2022-06-08

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


## Version 2.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-10-12

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit 4a7fe6d](https://github.com/googleapis/google-cloud-dotnet/commit/4a7fe6d): fix: combine billing/v1 grpc_service_config files
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0, released 2020-02-11

- [Commit 6308c12](https://github.com/googleapis/google-cloud-dotnet/commit/6308c12): Adds parameterless (aside from page token/size) list methods:
  - ListBillingAccounts
  - ListServices

## Version 1.0.0-beta01, released 2020-01-15

Initial beta release.

