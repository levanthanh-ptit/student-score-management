-- Enabling the replication database
use master
exec sp_replicationdboption @dbname = N'QLDSV', @optname = N'merge publish', @value = N'true'
GO

-- Adding the merge publication
use [QLDSV]
exec sp_addmergepublication @publication = N'QLDSV_CNTT', @description = N'Khoa Công nghệ Thông tin.', @sync_mode = N'native', @retention = 14, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_subdirectory = N'ftp', @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @dynamic_filters = N'false', @conflict_retention = 14, @keep_partition_changes = N'false', @allow_synctoalternate = N'false', @max_concurrent_merge = 0, @max_concurrent_dynamic_snapshots = 0, @use_partition_groups = N'true', @publication_compatibility_level = N'100RTM', @replicate_ddl = 1, @allow_subscriber_initiated_snapshot = N'false', @allow_web_synchronization = N'false', @allow_partition_realignment = N'true', @retention_period_unit = N'days', @conflict_logging = N'both', @automatic_reinitialization_policy = 0
GO

exec sp_addpublication_snapshot @publication = N'QLDSV_CNTT', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 500, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 0, @publisher_login = N'sa', @publisher_password = N''
exec sp_grant_publication_access @publication = N'QLDSV_CNTT', @login = N'distributor_admin'
GO
exec sp_grant_publication_access @publication = N'QLDSV_CNTT', @login = N'sa'
GO
exec sp_grant_publication_access @publication = N'QLDSV_CNTT', @login = N'FPTDNSB\ThanhLeVan'
GO
exec sp_grant_publication_access @publication = N'QLDSV_CNTT', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_access @publication = N'QLDSV_CNTT', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_access @publication = N'QLDSV_CNTT', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
exec sp_grant_publication_access @publication = N'QLDSV_CNTT', @login = N'NT Service\MSSQLSERVER'
GO

-- Adding the merge articles
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'KHOA', @source_owner = N'dbo', @source_object = N'KHOA', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'[MAKH] =''CNTT''', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'MONHOC', @source_owner = N'dbo', @source_object = N'MONHOC', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'GIANGVIEN', @source_owner = N'dbo', @source_object = N'GIANGVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'LOP', @source_owner = N'dbo', @source_object = N'LOP', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'SINHVIEN', @source_owner = N'dbo', @source_object = N'SINHVIEN', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'HOCPHI', @source_owner = N'dbo', @source_object = N'HOCPHI', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'DIEM', @source_owner = N'dbo', @source_object = N'DIEM', @type = N'table', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000010C034FD1, @identityrangemanagementoption = N'none', @destination_owner = N'dbo', @force_reinit_subscription = 1, @column_tracking = N'false', @subset_filterclause = N'', @vertical_partition = N'false', @verify_resolver_signature = 1, @allow_interactive_resolver = N'false', @fast_multicol_updateproc = N'true', @check_permissions = 0, @subscriber_upload_options = 0, @delete_tracking = N'true', @compensate_for_errors = N'false', @stream_blob_columns = N'true', @partition_options = 0
GO
use [QLDSV]
exec sp_addmergearticle @publication = N'QLDSV_CNTT', @article = N'CreateRoleSystem', @source_owner = N'dbo', @source_object = N'CreateRoleSystem', @type = N'proc schema only', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x0000000008000001, @destination_owner = N'dbo', @destination_object = N'CreateRoleSystem', @force_reinit_subscription = 1
GO

-- Adding the merge article join filters
use [QLDSV]
exec sp_addmergefilter @publication = N'QLDSV_CNTT', @article = N'GIANGVIEN', @filtername = N'GIANGVIEN_KHOA', @join_articlename = N'KHOA', @join_filterclause = N'[GIANGVIEN].[MAKH] = [KHOA].[MAKH]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV]
exec sp_addmergefilter @publication = N'QLDSV_CNTT', @article = N'LOP', @filtername = N'LOP_KHOA', @join_articlename = N'KHOA', @join_filterclause = N'[LOP].[MAKH] = [KHOA].[MAKH]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV]
exec sp_addmergefilter @publication = N'QLDSV_CNTT', @article = N'SINHVIEN', @filtername = N'SINHVIEN_LOP', @join_articlename = N'LOP', @join_filterclause = N'[SINHVIEN].[MALOP] = [LOP].[MALOP]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO
use [QLDSV]
exec sp_addmergefilter @publication = N'QLDSV_CNTT', @article = N'DIEM', @filtername = N'DIEM_SINHVIEN', @join_articlename = N'SINHVIEN', @join_filterclause = N'[DIEM].[MASV] = [SINHVIEN].[MASV]', @join_unique_key = 1, @filter_type = 1, @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO

-- Adding the merge subscriptions
use [QLDSV]
exec sp_addmergesubscription @publication = N'QLDSV_CNTT', @subscriber = N'FPTDNSB\THANH02', @subscriber_db = N'QLDSV', @subscription_type = N'Push', @sync_type = N'Automatic', @subscriber_type = N'Global', @subscription_priority = 75, @description = N'', @use_interactive_resolver = N'False'
exec sp_addmergepushsubscription_agent @publication = N'QLDSV_CNTT', @subscriber = N'FPTDNSB\THANH02', @subscriber_db = N'QLDSV', @job_login = null, @job_password = null, @subscriber_security_mode = 0, @subscriber_login = N'sa', @subscriber_password = null, @publisher_security_mode = 1, @frequency_type = 64, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0
GO

