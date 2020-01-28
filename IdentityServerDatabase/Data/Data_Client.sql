MERGE INTO [sts].[Client] AS TARGET
	USING (
	VALUES
		(@Client_GcWebsite_Key, 'GoClimbSite', 'GoClimbSite', 'The Go Climb Website client', 1, 1)
	)
	AS SOURCE ([Key], [ClientId], [ClientName], [Description], [Enabled], [EnableLocalLogin])
	ON Source.[ClientId] = Target.[ClientId]
	WHEN NOT MATCHED BY TARGET THEN
	INSERT
		([Key], [ClientId], [ClientName], [Description], [Enabled], [EnableLocalLogin])
	VALUES
		([Key], [ClientId], [ClientName], [Description], [Enabled], [EnableLocalLogin]);


