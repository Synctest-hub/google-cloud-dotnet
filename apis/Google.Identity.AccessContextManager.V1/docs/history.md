# Version history

## Version 2.1.0, released 2022-11-10

### New features

- Added AccessPolicy.scopes, EgressTo.external_resources, and IAM methods ([commit a4ebef3](https://github.com/googleapis/google-cloud-dotnet/commit/a4ebef36c9c7cc6b5ddaa1a0abfaff3242ec6309))

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


## Version 1.5.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 1.4.0, released 2022-02-04

### New features

- Add full Identity Access Context Manager support ([commit 0aa263c](https://github.com/googleapis/google-cloud-dotnet/commit/0aa263c45e49b3956e1cc47a7b116044e8ea7dbe))

## Version 1.3.0, released 2021-08-10

- [Commit abd324d](https://github.com/googleapis/google-cloud-dotnet/commit/abd324d): chore: publish Access Context Manager API v1

## Version 1.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 1.1.0, released 2020-11-18

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31

## Version 1.0.0, released 2020-04-08

No API surface changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2020-03-30

First beta release.
