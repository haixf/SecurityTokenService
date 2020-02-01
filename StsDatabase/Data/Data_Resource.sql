MERGE INTO [sts].[Resources] AS Target
	USING (
	VALUES
		(@Resource_OpenId_Key,'openid', 'openid', 0, 'openid resource', 1, 1, 0, 1),
		(@Resource_Email_Key,'email', 'email', 0, 'email resource', 1, 1, 0, 1),
		(@Resource_Phone_Key,'phone', 'phone', 0, 'phone resource', 1, 1, 0, 1),
		(@Resource_Address_Key,'address', 'address', 0, 'address resource', 1, 1, 0, 1),
		(@Resource_Profile_Key,'profile', 'profile', 0, 'profile resource', 1, 1, 0, 1),
		(@Resource_GoClimbApi_Key, 'goclimbapi', 'goclimbapi', 1, 'The resource for the GoClimbApi', 1, 1, 0, 0)
	)
	AS SOURCE ([Key], Name, DisplayName, ResourceType, Description, Enabled, Required, Emphasize, ShowInDiscoveryDocument)
	ON SOURCE.Name = Target.Name
	WHEN NOT MATCHED BY TARGET THEN
	INSERT
	 ([Key], Name, DisplayName, ResourceType, Description, Enabled, Required, Emphasize, ShowInDiscoveryDocument)
	VALUES
	 ([Key], Name, DisplayName, ResourceType, Description, Enabled, Required, Emphasize, ShowInDiscoveryDocument);