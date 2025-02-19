# Version history

## Version 2.0.0, released 2024-10-14

### Bug fixes

- **BREAKING CHANGE** Remove visibility of unneeded TestIamPermissions RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded InitiateBackup RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded AbandonBackup RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded FinalizeBackup RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded RemoveDataSource RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))
- **BREAKING CHANGE** Remove visibility of unneeded SetInternalStatus RPC ([commit 553e7b0](https://github.com/googleapis/google-cloud-dotnet/commit/553e7b098875151e4dd7d8afbf20a708064fc645))

## Version 1.2.0, released 2024-09-26

### New features

- Client library for the backupvault api is added ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupplan proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupplanassociation proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupvault_ba proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- Add backupvault_gce proto ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))

### Documentation improvements

- A comment for field `oauth2_client_id` in message `.google.cloud.backupdr.v1.ManagementServer` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `parent` in message `.google.cloud.backupdr.v1.ListManagementServersRequest` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `management_servers` in message `.google.cloud.backupdr.v1.ListManagementServersResponse` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `name` in message `.google.cloud.backupdr.v1.GetManagementServerRequest` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `parent` in message `.google.cloud.backupdr.v1.CreateManagementServerRequest` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))
- A comment for field `requested_cancellation` in message `.google.cloud.backupdr.v1.OperationMetadata` is changed ([commit a873918](https://github.com/googleapis/google-cloud-dotnet/commit/a8739185eb39dedeab0eed11d4c382d553d5afd1))

## Version 1.1.0, released 2024-06-24

### New features

- A new field `satisfies_pzs` is added ([commit 401cd38](https://github.com/googleapis/google-cloud-dotnet/commit/401cd38b79392a8e702bdd7718e99d69e26b5a8f))
- A new field `satisfies_pzi` is added ([commit 401cd38](https://github.com/googleapis/google-cloud-dotnet/commit/401cd38b79392a8e702bdd7718e99d69e26b5a8f))
- Updated documentation URI ([commit 401cd38](https://github.com/googleapis/google-cloud-dotnet/commit/401cd38b79392a8e702bdd7718e99d69e26b5a8f))
## Version 1.0.0, released 2024-05-24

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta02, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta01, released 2024-04-18

Initial release.
