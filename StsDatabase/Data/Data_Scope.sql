MERGE INTO [sts].[Scopes] AS Target
	USING (
	VALUES
		(@Scope_GoClimbApi_Manage, @Resource_GoClimbApi_Key, 'goclimbapi.manage', 'goclimbapi.manage', 'Scope used for accessing the go climb api')
	)
	AS SOURCE ([Key], [ResourceKey], [Name], [DisplayName], [Description])
	ON SOURCE.Name = Target.Name
	WHEN NOT MATCHED BY TARGET THEN
	INSERT
	 ([Key], [ResourceKey], [Name], [DisplayName], [Description])
	VALUES
	 ([Key], [ResourceKey], [Name], [DisplayName], [Description]);