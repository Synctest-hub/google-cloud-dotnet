# Version history

## Version 2.6.0, released 2024-05-14

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 2.5.0, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 2.4.0, released 2024-02-29

No API surface changes; just dependency updates.

## Version 2.3.0, released 2023-09-06

### New features

- Add UNAVAILABLE and QUEUED to state enum ([commit 21221cb](https://github.com/googleapis/google-cloud-dotnet/commit/21221cb0b71345b466bce0bd0e9dee9e934b41d2))
- Add LOG_NONE to call_log_level ([commit 21221cb](https://github.com/googleapis/google-cloud-dotnet/commit/21221cb0b71345b466bce0bd0e9dee9e934b41d2))
- Add status, labels, duration and state_error fields to Execution ([commit 21221cb](https://github.com/googleapis/google-cloud-dotnet/commit/21221cb0b71345b466bce0bd0e9dee9e934b41d2))
- Add filter and order_by fields to ListExecutionsRequest ([commit 21221cb](https://github.com/googleapis/google-cloud-dotnet/commit/21221cb0b71345b466bce0bd0e9dee9e934b41d2))

## Version 2.2.0, released 2023-08-16

No API surface changes; just dependency updates.

## Version 2.1.0, released 2023-02-08

No API surface changes; just dependency updates.

## Version 2.0.0, released 2022-06-09

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

## Version 1.2.0, released 2022-01-18

### New features

- Add a stack_trace field to the Error messages specifying where the error occured
- Add call_log_level field to Execution messages

### Documentation improvements

- Clarify requirement to escape strings within JSON arguments ([commit 141a9c3](https://github.com/googleapis/google-cloud-dotnet/commit/141a9c35a4a70aee171f13e2a3dbb98f4c6e129e))

## Version 1.1.0, released 2021-09-20

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-05-11

First GA release. No API surface changes since 1.0.0-beta01.

## Version 1.0.0-beta01, released 2021-03-02

Initial release.
