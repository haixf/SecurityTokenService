CREATE TABLE [sts].[ClientClaims]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientKey] UNIQUEIDENTIFIER NOT NULL,
	[ClaimKey] UNIQUEIDENTIFIER NOT NULL,
	FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Clients]([Key]),
	FOREIGN KEY ([ClaimKey]) REFERENCES [sts].[Claims]([Key])
)
