MERGE INTO [sts].[Resource] AS Target
	USING (
	VALUES
		(@Resource_OpenId_Key,'openid', 'openid', 'identity', 'openid resource', 1, 1, 0, 1),
		(@Resource_Email_Key,'email', 'email', 'identity', 'email resource', 1, 1, 0, 1),
		(@Resource_Phone_Key,'phone', 'phone', 'identity', 'phone resource', 1, 1, 0, 1),
		(@Resource_Address_Key,'address', 'address', 'identity', 'address resource', 1, 1, 0, 1),
		(@Resource_Profile_Key,'profile', 'profile', 'identity', 'profile resource', 1, 1, 0, 1)
	)
	AS SOURCE ([Key], Name, DisplayName, ResourceType, Description, Enabled, Required, Emphasize, ShowInDiscoveryDocument)
	ON SOURCE.Name = Target.Name
	WHEN NOT MATCHED BY TARGET THEN
	INSERT
	 ([Key], Name, DisplayName, ResourceType, Description, Enabled, Required, Emphasize, ShowInDiscoveryDocument)
	VALUES
	 ([Key], Name, DisplayName, ResourceType, Description, Enabled, Required, Emphasize, ShowInDiscoveryDocument);