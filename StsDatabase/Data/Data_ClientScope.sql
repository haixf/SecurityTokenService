MERGE INTO [sts].[ClientScopes] AS Target
	USING (
	VALUES
		(@ClientScope_GoClimbWebsite_GoClimbApiManage, @Client_GcWebsite_Key, @Scope_GoClimbApi_Manage)
	)
	AS SOURCE ([Key], [ClientKey], [ScopeKey])
	ON SOURCE.[ClientKey] = Target.[ClientKey] AND SOURCE.[ScopeKey] = Target.[ScopeKey]
	WHEN NOT MATCHED BY TARGET THEN
	INSERT
	 ([Key], [ClientKey], [ScopeKey])
	VALUES
	 ([Key], [ClientKey], [ScopeKey]);