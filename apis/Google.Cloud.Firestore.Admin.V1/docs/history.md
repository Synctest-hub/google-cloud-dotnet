# Version history

## Version 3.9.0, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

### Documentation improvements

- Allow 14 week backup retention for Firestore daily backups ([commit 484b7d9](https://github.com/googleapis/google-cloud-dotnet/commit/484b7d946753effa6c5faa8ebd1192f57846e624))
- Correct BackupSchedule recurrence docs that mentioned specific time of day ([commit d41af41](https://github.com/googleapis/google-cloud-dotnet/commit/d41af41616ae720d5b96e640f9d0a50d83582f3e))

## Version 3.8.0, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))
- Add Vector Index API ([commit 6d2a003](https://github.com/googleapis/google-cloud-dotnet/commit/6d2a0034b46c52254739cbd097fbe56f6d02b2b8))

## Version 3.7.0, released 2024-03-21

### New features

- A new message `Backup` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new resource_definition `firestore.googleapis.com/Backup` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `GetBackup` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `ListBackups` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `DeleteBackup` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `RestoreDatabase` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `CreateBackupSchedule` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `GetBackupSchedule` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `ListBackupSchedules` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `UpdateBackupSchedule` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new method `DeleteBackupSchedule` is added to service `FirestoreAdmin` ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `CreateBackupScheduleRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `GetBackupScheduleRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `UpdateBackupScheduleRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `ListBackupSchedulesRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `ListBackupSchedulesResponse` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `DeleteBackupScheduleRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `GetBackupRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `ListBackupsRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `ListBackupsResponse` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `DeleteBackupRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `RestoreDatabaseRequest` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `RestoreDatabaseMetadata` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `BackupSchedule` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new resource_definition `firestore.googleapis.com/BackupSchedule` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `DailyRecurrence` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))
- A new message `WeeklyRecurrence` is added ([commit 959a792](https://github.com/googleapis/google-cloud-dotnet/commit/959a79280a86ee4e387d4892db7c860aba0ec553))

## Version 3.6.0, released 2024-02-28

### Documentation improvements

- Fix formatting due to unclosed backtick ([commit 9c9f138](https://github.com/googleapis/google-cloud-dotnet/commit/9c9f138f23701d913a1fc192003ff9d77563f792))

## Version 3.5.0, released 2024-01-08

### New features

- Add DeleteDatabase API and delete protection ([commit 045eb3b](https://github.com/googleapis/google-cloud-dotnet/commit/045eb3b54e169edab666bc0e3154683d402fde0e))

### Documentation improvements

- Update Database API description ([commit 045eb3b](https://github.com/googleapis/google-cloud-dotnet/commit/045eb3b54e169edab666bc0e3154683d402fde0e))

## Version 3.4.0, released 2023-12-05

### New features

- Expose Firestore PITR fields in Database to stable ([commit 164e151](https://github.com/googleapis/google-cloud-dotnet/commit/164e151633aa4d82861a61d4a95ff496d38b87ef))
- Expose Firestore snapshot_time field in export API to stable ([commit 164e151](https://github.com/googleapis/google-cloud-dotnet/commit/164e151633aa4d82861a61d4a95ff496d38b87ef))
- Expose Firestore namespace ID fields in import/export APIs to stable ([commit 164e151](https://github.com/googleapis/google-cloud-dotnet/commit/164e151633aa4d82861a61d4a95ff496d38b87ef))

### Documentation improvements

- Assorted typo fixes and whitespace updates ([commit 164e151](https://github.com/googleapis/google-cloud-dotnet/commit/164e151633aa4d82861a61d4a95ff496d38b87ef))

## Version 3.3.0, released 2023-06-05

### New features

- Add CreateDatabase API ([commit 09a1ae4](https://github.com/googleapis/google-cloud-dotnet/commit/09a1ae43740e16ae1d27024044aa1c62c7b1ed16))

## Version 3.2.0, released 2023-05-26

### New features

- Add ApiScope and COLLECTION_RECURSIVE query_scope for Firestore index ([commit 4c82bff](https://github.com/googleapis/google-cloud-dotnet/commit/4c82bffa5257d5083f5c06681c7540bf4a03bcfc))

## Version 3.1.0, released 2023-01-16

### New features

- Enable REST transport in C# ([commit a6c4606](https://github.com/googleapis/google-cloud-dotnet/commit/a6c46063bd961a9dadc728a780d66de772f28e71))

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


## Version 2.4.0, released 2022-01-17

### New features

- Update client libraries to support Database operations ([commit ba21870](https://github.com/googleapis/google-cloud-dotnet/commit/ba2187023f67d902d54ec8c6a3d16b0c934873f8))

## Version 2.3.0, released 2021-08-31

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-26

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-11-18

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Apply timeouts to RPCs without retry
- [Commit b1a62dd](https://github.com/googleapis/google-cloud-dotnet/commit/b1a62dd): chore: set Ruby namespace in proto options
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation

## Version 2.0.0, released 2020-03-18

No API surface changes compared with 2.0.0-beta01, just dependency
and implementation changes.

## Version 2.0.0-beta01, released 2020-02-18

This is the first prerelease targeting GAX v3. Please see the [breaking changes
guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

Additionally, many of the long-running operation methods have taken
a breaking change to return the generation `Operation<TResponse, TMetadata>`
type instead of just the `Operation` proto.

## Version 1.0.0, released 2019-12-10

Initial GA release.
