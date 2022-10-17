# Version history

## Version 2.2.0, released 2022-10-17

### New features

- Add new field for exception audit log link ([commit f22a43e](https://github.com/googleapis/google-cloud-dotnet/commit/f22a43e19787024d703416e584dcbf53373f401c))
- Add support of new compliance regime for regions and new partner T systems ([commit f22a43e](https://github.com/googleapis/google-cloud-dotnet/commit/f22a43e19787024d703416e584dcbf53373f401c))
- Add apis for AssuredWorkload monitoring feature and to restrict allowed resources ([commit 982ac1c](https://github.com/googleapis/google-cloud-dotnet/commit/982ac1c2add600cf357e6feb5e5c94e33715fd30))

### Documentation improvements

- Fix some typos in documentation ([commit f22a43e](https://github.com/googleapis/google-cloud-dotnet/commit/f22a43e19787024d703416e584dcbf53373f401c))

## Version 2.1.0, released 2022-07-11

### New features

- ITAR June Preview Launch ([commit 74d9981](https://github.com/googleapis/google-cloud-dotnet/commit/74d9981f07a0a61fee8fcef6e8573b4a5bdd5a46))

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


## Version 1.1.0, released 2022-01-17

### New features

- EU Regions and Support With Sovereign Controls ([commit 3e86ed0](https://github.com/googleapis/google-cloud-dotnet/commit/3e86ed09608527eeeae8f79862a57c978623381f))

## Version 1.0.0, released 2021-11-10

First GA release.

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2021-10-11

Initial release.
