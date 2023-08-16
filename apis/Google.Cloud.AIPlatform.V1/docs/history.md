# Version history

## Version 2.18.0, released 2023-08-16

### New features

- Update field_behavior for `name` to be IMMUTABLE instead of OUTPUT_ONLY in Context, ModelMonitor, Schedule, DeploymentResourcePool ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Expose CreateDatasetVersionOperationMetadata and RestoreDatasetVersionOperationMetadata to DatasetService ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add disk_type and disk_size_gb to PersistentDiskSpec ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add schedule_name to PipelineJob ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add open_evaluation_pipeline to PublisherModel ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))
- Add ReadTensorboardSize to TensorboardService ([commit 67e1930](https://github.com/googleapis/google-cloud-dotnet/commit/67e1930923029f84aab0fe7d0d60bf744a94f099))

## Version 2.17.0, released 2023-08-04

### New features

- Add `PredictionService.ServerStreamingPredict` method ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- Add `StreamingPredictRequest` type ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- Add `StreamingPredictResponse` type ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- Add `Tensor` type ([commit 48c78fe](https://github.com/googleapis/google-cloud-dotnet/commit/48c78fe766c4163c6cd9e2726e9a35583ddd6dda))
- ScheduleService (schedule_service.proto) creates and manages Schedule resources to launch scheduled pipelines runs ([commit dc5bfd6](https://github.com/googleapis/google-cloud-dotnet/commit/dc5bfd69d99d3e8b0290656645c7fba0acd2718e))
- Schedule (schedule.proto) periodically schedules runs to make API calls ([commit dc5bfd6](https://github.com/googleapis/google-cloud-dotnet/commit/dc5bfd69d99d3e8b0290656645c7fba0acd2718e))
- Add data_item_count to Dataset ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add DeleteSavedQuery to DatasetService ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add JOB_STATE_PARTIALLY_SUCCEEDED to JobState ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add pipeline_job to Model ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))
- Add reserved_ip_ranges to PipelineJob ([commit 445fa0e](https://github.com/googleapis/google-cloud-dotnet/commit/445fa0e87ace33fa1fee4c90a4a531fee6a9456c))

## Version 2.16.0, released 2023-06-20

### New features

- Add UpdateExplanationDataset to aiplatform ([commit 8a49530](https://github.com/googleapis/google-cloud-dotnet/commit/8a49530dc8ab6b000c2063b1a4c9385cc1b139f8))
- Add NVIDIA_A100_80GB to AcceleratorType ([commit 8bed9db](https://github.com/googleapis/google-cloud-dotnet/commit/8bed9dbdf9786825c3ab885a32e99d0f49ea6026))
- Add blocking_operation_ids to ImportFeatureValuesOperationMetadata ([commit 8bed9db](https://github.com/googleapis/google-cloud-dotnet/commit/8bed9dbdf9786825c3ab885a32e99d0f49ea6026))
- Support for Model Garden -- A single place to search, discover, and interact with a wide variety of foundation models from Google and Google partners, available on Vertex AI ([commit 617cfa1](https://github.com/googleapis/google-cloud-dotnet/commit/617cfa127c0a381dafd046b2fbb60d245dc12a39))

## Version 2.15.0, released 2023-05-23

### New features

- Add match service in aiplatform v1 ([commit 7fa56aa](https://github.com/googleapis/google-cloud-dotnet/commit/7fa56aa6604cfeb78597c7799e3d9ea10a39e4a7))
- Add examples to ExplanationParameters in aiplatform v1 explanation.proto ([commit 0ec8cc2](https://github.com/googleapis/google-cloud-dotnet/commit/0ec8cc2caa812e2a879687d0ba2150806b42078a))

## Version 2.14.0, released 2023-05-03

### New features

- Add NVIDIA_L4 to AcceleratorType ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add experiment and experiment_run to CustomJobSpec ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add MutateDeployedModel RPC to endpoint_service ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add offline_storage_ttl_days to EntityType ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add online_storage_ttl_days to FeatureStore ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))
- Add GENIE to ModelSourceType ([commit 1a69433](https://github.com/googleapis/google-cloud-dotnet/commit/1a694333f553a44b96d342049495250b75c15ff8))

## Version 2.13.0, released 2023-04-19

### New features

- Add is_default to Tensorboard in aiplatform v1 tensorboard.proto and v1beta1 tensorboard.proto ([commit 0fe126a](https://github.com/googleapis/google-cloud-dotnet/commit/0fe126af822d5691488387da74cccb9650040d5e))

## Version 2.12.0, released 2023-04-12

### New features

- Add public_endpoint_enabled and publid_endpoint_domain_name to IndexEndpoint ([commit 6456df3](https://github.com/googleapis/google-cloud-dotnet/commit/6456df3710bf03715fd60988726c5fc75e76747d))
- Add ModelSourceType.MODEL_GARDEN enum to ModelSourceInfo ([commit 6456df3](https://github.com/googleapis/google-cloud-dotnet/commit/6456df3710bf03715fd60988726c5fc75e76747d))
- Add copy to ModelSourceInfo ([commit 6456df3](https://github.com/googleapis/google-cloud-dotnet/commit/6456df3710bf03715fd60988726c5fc75e76747d))

## Version 2.11.0, released 2023-03-06

### New features

- Add disable_container_logging to BatchPredictionJob in aiplatform v1,v1beta1 batch_prediction_job.proto ([commit 368e543](https://github.com/googleapis/google-cloud-dotnet/commit/368e543246160ac767770be0ea4ec89feb6e62d1))
- Add TPU_V4_POD to AcceleratorType in aiplatform v1 accelerator_type.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add split to ExportDataConfig in aiplatform v1 dataset.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add offline_storage_ttl_days to EntityType in aiplatform v1 entity_type.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add evaluated_annotation.proto to aiplatform v1 ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add cpu_utilization_target to Featurestore.OnlineServingConfig.Scaling in aiplatform v1 featurestore.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add online_storage_ttl_days to Featurestore in aiplatform v1 featurestore.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add slice_spec to ModelEvaluationSlice in aiplatform v1 model_evaluation_slice.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))
- Add BatchImportEvaluatedAnnotations rpc to aiplatform v1 model_service.proto ([commit 995de9c](https://github.com/googleapis/google-cloud-dotnet/commit/995de9c238a1fea5d682b534f8cace63127296fd))

## Version 2.10.0, released 2023-02-08

### New features

- Add service_networking.proto to aiplatform v1 ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add private_service_connect_config to IndexEndpoint in aiplatform v1 index_endpoint.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add nas_job.proto to aiplatform v1 ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add CreateNasJob, GetNasJob, ListNasJobs, DeleteNasJob, CancelNasJob, GetNasTrialDetail, ListNasTrialDetails RPCs to aiplatform v1 job_service.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add original_model_info to Model in aiplatform v1 model.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add CopyModel RPC to aiplatform v1 model_service.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add failed_jobs to CustomJobDetail to aiplatform v1 pipeline_job.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))
- Add safety_config to StudySpec in aiplatform v1 study.proto ([commit 189dffe](https://github.com/googleapis/google-cloud-dotnet/commit/189dffeda7937d84a4397f89621157711b7b2b03))

## Version 2.9.0, released 2023-01-18

### New features

- Add enable_dashboard_access in aiplatform v1 and v1beta1 ([commit 5eef07b](https://github.com/googleapis/google-cloud-dotnet/commit/5eef07bfa85941015645598a0df3362e7db55378))

## Version 2.8.0, released 2023-01-16

### New features

- Add instance_config to BatchPredictionJob in aiplatform v1 batch_prediction_job.proto ([commit f868bc8](https://github.com/googleapis/google-cloud-dotnet/commit/f868bc8f601d12499c7212b0b992ea205fe310f3))
- Add saved_queries to Dataset in aiplatform v1 dataset.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))
- Add order_by to ListModelVersionRequest in aiplatform v1 model_service.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))
- Add update_all_stopped_trials to ConvexAutomatedStoppingSpec in aiplatform v1 study.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))
- Add ReadTensorboardUsage rpc in aiplatform v1 tensorboard_service.proto ([commit e7acad2](https://github.com/googleapis/google-cloud-dotnet/commit/e7acad20e505522f02023821ee133cc48ad8205c))

## Version 2.7.0, released 2022-12-14

### New features

- Add service_account to UploadModelRequest in aiplatform v1 model_service.proto ([commit d2f3215](https://github.com/googleapis/google-cloud-dotnet/commit/d2f32151d16303b4684188ca44e19ba6c115ee5d))
- Add SearchDataItems RPC in aiplatform version v1 and v1beta1 dataset_service.proto ([commit c44d0dc](https://github.com/googleapis/google-cloud-dotnet/commit/c44d0dc34e3d22c26c2edd1eef2df32ea7f6d4e9))

## Version 2.6.0, released 2022-12-01

### New features

- Add metadata_artifact to Dataset in aiplatform v1 dataset.proto ([commit 7f369da](https://github.com/googleapis/google-cloud-dotnet/commit/7f369dafdab8345660654a36e08ecfb53664518a))
- Add WriteFeatureValues rpc to FeaturestoreOnlineServingService in aiplatform v1 featurestore_online_service.proto ([commit 7f369da](https://github.com/googleapis/google-cloud-dotnet/commit/7f369dafdab8345660654a36e08ecfb53664518a))
- Add service_account to batch_prediction_job in aiplatform v1 batch_prediction_job.proto ([commit 047a19c](https://github.com/googleapis/google-cloud-dotnet/commit/047a19c79d0d9ef0c63d596aa0088bac4f9f5a58))

## Version 2.5.0, released 2022-11-10

### New features

- Add annotation_labels to ImportDataConfig in aiplatform v1 dataset.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add start_time to BatchReadFeatureValuesRequest in aiplatform v1 featurestore_service.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add metadata_artifact to Model in aiplatform v1 model.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add failed_main_jobs and failed_pre_caching_check_jobs to ContainerDetail in aiplatform v1 pipeline_job.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))
- Add persist_ml_use_assignment to InputDataConfig in aiplatform v1 training_pipeline.proto ([commit f94d859](https://github.com/googleapis/google-cloud-dotnet/commit/f94d8598ffce8de96037023be374fef58e528061))

## Version 2.4.0, released 2022-10-03

### New features

- Add model_source_info to Model in aiplatform v1 model.proto ([commit 52a99e7](https://github.com/googleapis/google-cloud-dotnet/commit/52a99e7720eb6eb1328746a500c1354ce48948fc))
- Add timestamp_outside_retention_rows_count to ImportFeatureValuesResponse and ImportFeatureValuesOperationMetadata in aiplatform v1 featurestore_service.proto ([commit 093a3f1](https://github.com/googleapis/google-cloud-dotnet/commit/093a3f1a3ea1e44cdb2dc558113cee303208f2ff))
- Add RemoveContextChildren rpc to aiplatform v1 metadata_service.proto ([commit 093a3f1](https://github.com/googleapis/google-cloud-dotnet/commit/093a3f1a3ea1e44cdb2dc558113cee303208f2ff))
- Add order_by to ListArtifactsRequest, ListContextsRequest, and ListExecutionsRequest in aiplatform v1 metadata_service.proto ([commit 093a3f1](https://github.com/googleapis/google-cloud-dotnet/commit/093a3f1a3ea1e44cdb2dc558113cee303208f2ff))

## Version 2.3.0, released 2022-08-26

### New features

- Add read_mask to ListPipelineJobsRequest in aiplatform v1 pipeline_service ([commit 099522b](https://github.com/googleapis/google-cloud-dotnet/commit/099522b4f29dc941b522f23d9c32aadf6b4b7d63))
- Add input_artifacts to PipelineJob.runtime_config in aiplatform v1 pipeline_job ([commit 099522b](https://github.com/googleapis/google-cloud-dotnet/commit/099522b4f29dc941b522f23d9c32aadf6b4b7d63))
- Add UpsertDatapoints and RemoveDatapoints rpcs to IndexService in aiplatform v1 index_service.proto ([commit 592d099](https://github.com/googleapis/google-cloud-dotnet/commit/592d0997fa583f3741b60490fdd4cb131e5ac100))

## Version 2.2.0, released 2022-08-04

### New features

- Making network arg optional in aiplatform v1 custom_job.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))
- Added SHARED_RESOURCES enum to aiplatform v1 model.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))

### Documentation improvements

- Doc edits to aiplatform v1 dataset_service.proto, job_service.proto, model_service.proto, pipeline_service.proto, saved_query.proto, study.proto, types.proto ([commit fbae4d8](https://github.com/googleapis/google-cloud-dotnet/commit/fbae4d8e9d39732ee2c570126f055171256121ba))

## Version 2.1.0, released 2022-07-11

### New features

- Add ListSavedQueries rpc to aiplatform v1 dataset_service.proto ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add saved_query.proto to aiplatform v1 ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add saved_query_id to InputDataConfig in aiplatform v1 training_pipeline.proto ([commit 0ac2a25](https://github.com/googleapis/google-cloud-dotnet/commit/0ac2a258631c1925ae90cac40d4a371be3eebf13))
- Add BatchImportModelEvaluationSlices API in aiplatform v1 model_service.proto ([commit f742d07](https://github.com/googleapis/google-cloud-dotnet/commit/f742d07982cab375c0e81478f473e8e393c985dd))
- Add model_version_id to BatchPredictionJob in aiplatform v1 batch_prediction_job.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to DeployedModel in aiplatform v1 endpoint.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to PredictResponse in aiplatform v1 prediction_service.proto ([commit 2b4568a](https://github.com/googleapis/google-cloud-dotnet/commit/2b4568ab92390c4e8bfaed567dcc831fe59d6641))
- Add model_version_id to UploadModelResponse in aiplatform v1 model_service.proto ([commit c85aa57](https://github.com/googleapis/google-cloud-dotnet/commit/c85aa57f26f70d7fdb6877b4fa7a58f3bdf864fd))
- Add default_skew_threshold to TrainingPredictionSkewDetectionConfig in aiplatform v1beta1, v1 model_monitoring.proto ([commit 5e87a0c](https://github.com/googleapis/google-cloud-dotnet/commit/5e87a0c5da96ffa7bb5b9526d4b982705831c1a2))
- Add default_drift_threshold to PredictionDriftDetectionConfig in aiplatform v1beta1, v1 model_monitoring.proto ([commit 5e87a0c](https://github.com/googleapis/google-cloud-dotnet/commit/5e87a0c5da96ffa7bb5b9526d4b982705831c1a2))
- Add successful_forecast_point_count to CompletionStats in aiplatform v1 completion_stats.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add neighbors to Explanation in aiplatform v1 explanation.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add examples_override to ExplanationSpecOverride in aiplatform v1 explanation.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add version_id, version_aliases, version_create_time, version_update_time, and version_description to aiplatform v1 model.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add ModelVersion CRUD methods in aiplatform v1 model_service.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))
- Add model_id and parent_model to TrainingPipeline in aiplatform v1 training_pipeline.proto ([commit 2ab7359](https://github.com/googleapis/google-cloud-dotnet/commit/2ab735928abdc87cbbc3c2340b0c796495fafe58))

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

### New features also in this release

- Add monitor_window to ModelDeploymentMonitoringScheduleConfig proto in aiplatform v1/v1beta1 model_deployment_monitoring_job.proto ([commit 4a6d865](https://github.com/googleapis/google-cloud-dotnet/commit/4a6d865f55d52f480e4d5f792d0ff3bf0b68b620))
- Add failure_policy to PipelineJob in aiplatform v1 & v1beta1 pipeline_job.proto ([commit 660482a](https://github.com/googleapis/google-cloud-dotnet/commit/660482a467778c562889b98c382edfaded70446c))
- Add latent_space_source to ExplanationMetadata in aiplatform v1 explanation_metadata.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))
- Add scaling to OnlineServingConfig in aiplatform v1 featurestore.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))
- Add template_metadata to PipelineJob in aiplatform v1 pipeline_job.proto ([commit ce1e55d](https://github.com/googleapis/google-cloud-dotnet/commit/ce1e55d51e8e8837f572b470001a6772db87ddab))

## Version 1.8.0, released 2022-05-24

### New features

- Add display_name and metadata to ModelEvaluation in aiplatform model_evaluation.proto ([commit f3160c5](https://github.com/googleapis/google-cloud-dotnet/commit/f3160c58825803c39dcd24d73777caebd5d49481))
## Version 1.7.0, released 2022-04-26

### New features

- Add reserved_ip_ranges to CustomJobSpec in aiplatform v1 custom_job.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add nfs_mounts to WorkPoolSpec in aiplatform v1 custom_job.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add JOB_STATE_UPDATING to JobState in aiplatform v1 job_state.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add MfsMount in aiplatform v1 machine_resources.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
- Add ConvexAutomatedStoppingSpec to StudySpec in aiplatform v1 study.proto ([commit c6626c7](https://github.com/googleapis/google-cloud-dotnet/commit/c6626c775e5c896d2e89f46f1fee8910bb0911f9))
## Version 1.6.0, released 2022-04-04

### New features

- Add ImportModelEvaluation in aiplatform v1 model_service.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))
- Add data_item_schema_uri, annotation_schema_uri, explanation_specs to ModelEvaluationExplanationSpec in aiplatform v1 model_evaluation.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))
- Add ImportModelEvaluation in aiplatform v1beta1 model_service.proto ([commit 9406420](https://github.com/googleapis/google-cloud-dotnet/commit/940642037b4217cf427e3042bf0e7de74abe1d37))

## Version 1.5.0, released 2022-03-14

### New features

- Add monitoring_config to EntityType in aiplatform v1 entity_type.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add disable_monitoring to Feature in aiplatform v1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add monitoring_stats_anomalies to Feature in aiplatform v1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add staleness_days to SnapshotAnalysis in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add import_features_analysis to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add numerical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add categorical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add objective to MonitoringStatsSpec in aiplatform v1 featurestore_service.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add disable_monitoring to Feature in aiplatform v1beta1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add monitoring_stats_anomalies to Feature in aiplatform v1beta1 feature.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add staleness_days to SnapshotAnalysis in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add import_features_analysis to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add numerical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add categorical_threshold_config to FeaturestoreMonitoringConfig in aiplatform v1beta1 featurestore_monitoring.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add objective to MonitoringStatsSpec in aiplatform v1beta1 featurestore_service.proto ([commit fdea2d1](https://github.com/googleapis/google-cloud-dotnet/commit/fdea2d1b2692d30184321a360088e982c5b49453))
- Add PredictRequestResponseLoggingConfig to Endpoint in aiplatform v1 endpoint.proto ([commit a3d6d2b](https://github.com/googleapis/google-cloud-dotnet/commit/a3d6d2b7af22f4a19e78435512861b6dab0b1a7d))

## Version 1.4.0, released 2022-02-28

### New features

- Add TPU_V2 & TPU_V3 values to AcceleratorType in aiplatform v1/v1beta1 accelerator_type.proto ([commit 354f7fd](https://github.com/googleapis/google-cloud-dotnet/commit/354f7fd84ba22d2eef391d63e633ef836bea54e9))

### Documentation improvements

- Fix misformatted field description ([commit 95bf8b9](https://github.com/googleapis/google-cloud-dotnet/commit/95bf8b971a5ebaf3e9c57b69139e6a3b2b69ce32))

## Version 1.3.0, released 2022-02-07

### New features

- Add dedicated_resources to DeployedIndex message in aiplatform v1 index_endpoint.proto ([commit 6be632d](https://github.com/googleapis/google-cloud-dotnet/commit/6be632d58049af3165675d56db2837c7d6b78a81))

## Version 1.2.0, released 2022-01-17

### New features

- Add enable_private_service_connect field to Endpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add id field to DeployedModel ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add service_attachment field to PrivateEndpoints ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add endpoint_id to CreateEndpointRequest and method signature to CreateEndpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add method signature to CreateFeatureStore, CreateEntityType, CreateFeature ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add network and enable_private_service_connect to IndexEndpoint ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add service_attachment to IndexPrivateEndpoints ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))
- Add stratified_split field to training_pipeline InputDataConfig ([commit 9ca7ec1](https://github.com/googleapis/google-cloud-dotnet/commit/9ca7ec1e363e1c737c3bfc8d6cc94a62581f4873))

## Version 1.1.0, released 2021-11-18

- [Commit 0d5a6b7](https://github.com/googleapis/google-cloud-dotnet/commit/0d5a6b7):
  - feat:Tensorboard v1 protos release
  - feat:Exposing a field for v1 CustomJob-Tensorboard integration.

## Version 1.0.0, released 2021-11-10

- [Commit 68f7900](https://github.com/googleapis/google-cloud-dotnet/commit/68f7900): feat: Adds support for `google.protobuf.Value` pipeline parameters in the `parameter_values` field

First GA release. Note that the dependencies on Google.Cloud.AutoML.V1 and Google.Cloud.DataLabeling.V1Beta1 have been removed in this release.

## Version 1.0.0-beta05, released 2021-10-20

- [Commit 43bcfc3](https://github.com/googleapis/google-cloud-dotnet/commit/43bcfc3):
  - feat: add featurestore service to aiplatform v1
  - feat: add metadata service to aiplatform v1
  - docs: fix typo in alert.proto

## Version 1.0.0-beta04, released 2021-09-24

- [Commit 656f5ca](https://github.com/googleapis/google-cloud-dotnet/commit/656f5ca): feat: add Vizier service to aiplatform v1
- [Commit cd4557f](https://github.com/googleapis/google-cloud-dotnet/commit/cd4557f): feat: add XAI, model monitoring, and index services to aiplatform v1

## Version 1.0.0-beta03, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 1.0.0-beta02, released 2021-08-09

- [Commit b950563](https://github.com/googleapis/google-cloud-dotnet/commit/b950563): feat!: Removes breaking change from v1 version of AI Platform protos
- [Commit 8ecff2b](https://github.com/googleapis/google-cloud-dotnet/commit/8ecff2b): feat!: Removes AcceleratorType.TPU_V2 and TPU_V3 constants feat: Adds AcceleratorType.NVIDIA_TESLA_A100 constant feat: Adds BigQuery output table field to batch prediction job output config feat: Adds JobState.JOB_STATE_EXPIRED constant feat: Adds AutoscalingMetricSpec message feat: Adds PipelineService methods: CreatePipelineJob, GetPipelineJob, ListPipelineJobs, DeletePipelineJobs, CancelPipelineJobs feat: Adds fields to Study message
- [Commit 50afb69](https://github.com/googleapis/google-cloud-dotnet/commit/50afb69): fix: Explicitly use Google.Protobuf.WellKnownTypes.Value in ValueConverter
- [Commit b123458](https://github.com/googleapis/google-cloud-dotnet/commit/b123458):
  - feat: Adds additional_experiments field to AutoMlTablesInputs
  - feat: Adds two new ModelType constants for Video Action Recognition training jobs

## Version 1.0.0-beta01, released 2021-06-28

Initial release.
