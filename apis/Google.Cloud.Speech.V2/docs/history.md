# Version history

## Version 1.0.0-beta08, released 2024-02-27

### New features

- Add API for writing BatchRecognize transcripts in SRT and VTT formats ([commit 75f14ec](https://github.com/googleapis/google-cloud-dotnet/commit/75f14ec9ae233ff89a3649e501a0c84abb0b867b))

### Documentation improvements

- Update field documentation based on field behavior updates ([commit 75f14ec](https://github.com/googleapis/google-cloud-dotnet/commit/75f14ec9ae233ff89a3649e501a0c84abb0b867b))

## Version 1.0.0-beta07, released 2023-11-07

### New features

- Add transcript normalization + m4a audio format support ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))
- Deprecate `BatchRecognizeFileResult.uri` in favor of `cloud_storage_result.native_format_uri` ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))
- Deprecate `BatchRecognizeFileResult.transcript` in favor of `inline_result.transcript` ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))

### Documentation improvements

- Clarify alternatives for deprecated fields ([commit 368d1e1](https://github.com/googleapis/google-cloud-dotnet/commit/368d1e1643c80b968fb5eab8d5db9b00fa05725c))

## Version 1.0.0-beta06, released 2023-07-13

### New features

- Add `model` and `language_codes` fields in `RecognitionConfig` message + enable default `_` recognizer ([commit d2ecbdf](https://github.com/googleapis/google-cloud-dotnet/commit/d2ecbdff4500db196e8ebe2c75a98ba8fe5554d6))

## Version 1.0.0-beta05, released 2023-05-11

### New features

- Add processing strategy to batch recognition requests ([commit bbd6a85](https://github.com/googleapis/google-cloud-dotnet/commit/bbd6a857b74004230caecc548bff7ab4ba386b85))

## Version 1.0.0-beta04, released 2023-03-27

### New features

- Add support for BatchRecognize ([commit 406087a](https://github.com/googleapis/google-cloud-dotnet/commit/406087ac4d57c8364326616b38ffbed9254e33e9))

## Version 1.0.0-beta03, released 2023-01-19

### New features

- Enable REST transport in C# ([commit e04406f](https://github.com/googleapis/google-cloud-dotnet/commit/e04406fbc8700134ab6955e5244a5f2924a16a0a))

## Version 1.0.0-beta02, released 2022-10-17

### Documentation improvements

- Remove instructions for custom endpoint for Speech.V2

## Version 1.0.0-beta01, released 2022-09-30

Initial release.
