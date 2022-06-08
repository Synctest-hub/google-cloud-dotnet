# Version history

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


## Version 1.4.0, released 2022-05-05

### New features

- Add Application.service_account ([commit 523e2d2](https://github.com/googleapis/google-cloud-dotnet/commit/523e2d23624e0ed8565027843f2e7e48c2e76f5c))
- Add client library method signature to retrieve Application by name ([commit 523e2d2](https://github.com/googleapis/google-cloud-dotnet/commit/523e2d23624e0ed8565027843f2e7e48c2e76f5c))
- Add Service.labels ([commit 523e2d2](https://github.com/googleapis/google-cloud-dotnet/commit/523e2d23624e0ed8565027843f2e7e48c2e76f5c))
- Add Version.app_engine_apis ([commit 523e2d2](https://github.com/googleapis/google-cloud-dotnet/commit/523e2d23624e0ed8565027843f2e7e48c2e76f5c))
- Add VpcAccessConnector.egress_setting ([commit 523e2d2](https://github.com/googleapis/google-cloud-dotnet/commit/523e2d23624e0ed8565027843f2e7e48c2e76f5c))

## Version 1.3.0, released 2022-04-26

No API surface changes; just dependency updates.

## Version 1.2.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.1.0, released 2021-04-29

- [Commit c78b2f8](https://github.com/googleapis/google-cloud-dotnet/commit/c78b2f8):
  - feat: added vm_liveness, search_api_available, network_settings, service_account, build_env_variables, kms_key_reference to v1 API

## Version 1.0.0, released 2021-02-24

No API changes from 1.0.0-beta01.

## Version 1.0.0-beta01, released 2021-01-05

Initial release.
