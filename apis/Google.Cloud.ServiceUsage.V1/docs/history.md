# Version history

## Version 2.2.0, released 2023-09-18

### New features

- Introduce resource class serviceusage.googleapis.com/Service ([commit 6cecdd9](https://github.com/googleapis/google-cloud-dotnet/commit/6cecdd9badf4d838884abdf2faaba829b5225739))
- Added ConsumerQuotaLimit.supported_locations ([commit 6cecdd9](https://github.com/googleapis/google-cloud-dotnet/commit/6cecdd9badf4d838884abdf2faaba829b5225739))
- Added ProducerQuotaPolicy message and QuotaBucket.producer_quota_policy field ([commit 6cecdd9](https://github.com/googleapis/google-cloud-dotnet/commit/6cecdd9badf4d838884abdf2faaba829b5225739))

## Version 2.1.0, released 2023-01-19

### New features

- Enable REST transport in C# ([commit f6a1c3e](https://github.com/googleapis/google-cloud-dotnet/commit/f6a1c3e8930f0e8209a079352765be3bb9039be2))

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


## Version 1.2.0, released 2021-12-07

- [Commit 66b9405](https://github.com/googleapis/google-cloud-dotnet/commit/66b9405): docs: Remove erroneous space in a docstring
## Version 1.1.0, released 2021-09-06

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0, released 2021-06-22

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta01, released 2021-05-20

Initial release.
