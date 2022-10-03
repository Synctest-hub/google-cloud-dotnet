# Version history

## Version 5.1.0, released 2022-10-03

### New features

- Add support for Dataproc metric configuration ([commit 3267b4f](https://github.com/googleapis/google-cloud-dotnet/commit/3267b4f1faa7c15ff21ef0708f3636e48283ca3d))

## Version 5.0.0, released 2022-06-08

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


## Version 4.0.0, released 2022-02-17

### New features

- Add support for Virtual Dataproc cluster running on GKE cluster ([commit 462556b](https://github.com/googleapis/google-cloud-dotnet/commit/462556ba2b46bd840da1198fe0bd4bfba6b13af1))

### Breaking changes

- ClusterConfig.GkeClusterConfig has been removed
- GkeClusterConfig.NamespacedGkeDeploymentTarget has been removed
  (along with the corresponding nested type)

## Version 3.4.0, released 2022-01-17

### New features

- Spark runtime versioning for Spark batches ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
- Custom image containers for Spark batches ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
- Auto-diagnostic of failed Spark batches ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
- Local SSD NVME interface support for GCE clusters ([commit b6189ae](https://github.com/googleapis/google-cloud-dotnet/commit/b6189aeaa81e283d7eb9d0cd1652f5b594db2d0a))
## Version 3.3.0, released 2021-10-14

- [Commit 7c1e526](https://github.com/googleapis/google-cloud-dotnet/commit/7c1e526): feat: add Dataproc Serverless for Spark Batches API

## Version 3.2.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 3.1.0, released 2021-04-29

- [Commit d429843](https://github.com/googleapis/google-cloud-dotnet/commit/d429843):
  - feat: The new start and stop cluster methods.
  - feat: The ability to specify a metastore config in a cluster.
  - feat: The ability to specify a (BETA) GKE cluster when creating a Dataproc cluster.
  - feat: The ability to configure the behavior for private IPv6 cluster networking.
  - feat: The ability to specify node affinity groups for clusters.
  - feat: The ability to specify shielded VM configurations for clusters.
  - feat: Support for service-account based secure multi-tenancy.
  - feat: The ability to specify cluster labels for picking which cluster should run a job.
  - feat: Components for DOCKER, DRUID, FLINK, HBASE, RANGER, and SOLR
  - feat: The ability to specify a DAG timeout for workflows.

## Version 3.0.0, released 2020-11-17

- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit baae3ab](https://github.com/googleapis/google-cloud-dotnet/commit/baae3ab): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 0ceb9e8](https://github.com/googleapis/google-cloud-dotnet/commit/0ceb9e8): feat: Additional fields for the `ClusterConfig` and `InstanceGroupConfig` messages.
- [Commit 9724a7a](https://github.com/googleapis/google-cloud-dotnet/commit/9724a7a): fix!: fix LRO annotations for method `DiagnoseCluster`.
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit bdd321b](https://github.com/googleapis/google-cloud-dotnet/commit/bdd321b): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

Please note the breaking change compared with 2.1.0, in terms of long-running operation response/metadata types.

## Version 2.1.0, released 2020-05-04

- [Commit cdd7342](https://github.com/googleapis/google-cloud-dotnet/commit/cdd7342): docs: change relative URLs to absolute URLs to fix broken links.
- [Commit e644610](https://github.com/googleapis/google-cloud-dotnet/commit/e644610):
  - Adds Dataproc Jobs.SubmitJobAsOperation RPC
  - Adds SparkR and Presto job types to WorkflowTemplates
  - Adds new Optional Components
  - Clarifies usage of some APIs 
- [Commit edebc2b](https://github.com/googleapis/google-cloud-dotnet/commit/edebc2b): fix Dataproc: add missing `REQUIRED` annotation.
- [Commit bd045c2](https://github.com/googleapis/google-cloud-dotnet/commit/bd045c2): Adds resource name overloads for autoscaling policy operations

## Version 2.0.0, released 2020-03-17

- [Commit c120b77](https://github.com/googleapis/google-cloud-dotnet/commit/c120b77):
  - Feature: SparkR and Presto job support
  - Feature: Lifecycle config support
  - Feature: Reservation affinity support
- [Commit 5ae3789](https://github.com/googleapis/google-cloud-dotnet/commit/5ae3789): Breaking changes around resource names, due to removing RegionOrLocationName

Note that the breaking change here was expected;
RegionOrLocationName didn't represent the name of a real resource,
and we now have better options for handling parents of resources with multiple patterns.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additional changes:

- [Commit a629906](https://github.com/googleapis/google-cloud-dotnet/commit/a629906): Adds AutoscalingPolicyClient.

## Version 1.1.0, released 2019-12-09

- [Commit 4e38a24](https://github.com/googleapis/google-cloud-dotnet/commit/4e38a24): Autoscaling and security configuration
- [Commit 50658e2](https://github.com/googleapis/google-cloud-dotnet/commit/50658e2): Add resource name format methods

## Version 1.0.0, released 2019-07-10

Initial GA release.
