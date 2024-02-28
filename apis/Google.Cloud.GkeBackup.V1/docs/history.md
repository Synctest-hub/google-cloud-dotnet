# Version history

## Version 2.3.0, released 2024-02-28

### Documentation improvements

- Minor formatting ([commit 9498ba9](https://github.com/googleapis/google-cloud-dotnet/commit/9498ba98ecac1ebc1aa1fa0174aadd089d9f853c))

## Version 2.2.0, released 2023-06-27

### New features

- Added new restore scope options ([commit b606f4c](https://github.com/googleapis/google-cloud-dotnet/commit/b606f4c5293289554f5a035f3f8e0ce4c71ef3fe))
- Added transformation rules for restore ([commit b606f4c](https://github.com/googleapis/google-cloud-dotnet/commit/b606f4c5293289554f5a035f3f8e0ce4c71ef3fe))
- Added BackupPlan and RestorePlan state information ([commit b606f4c](https://github.com/googleapis/google-cloud-dotnet/commit/b606f4c5293289554f5a035f3f8e0ce4c71ef3fe))

### Documentation improvements

- Minor documentation fixes ([commit c78b468](https://github.com/googleapis/google-cloud-dotnet/commit/c78b46845ade4aafe6388159c5d12796fe150c77))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit 496c8ab](https://github.com/googleapis/google-cloud-dotnet/commit/496c8abe53e80646e5dd5a6d4a2231b11b36969a))

## Version 2.0.0, released 2022-11-02

No API surface changes; just dependency updates and promotion to general availability.

## Version 2.0.0-beta01, released 2022-06-09

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

## Version 1.0.0-beta01, released 2022-05-17

Initial release.
