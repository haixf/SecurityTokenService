CREATE TABLE [sts].[ClientSecrets]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientKey] UNIQUEIDENTIFIER NOT NULL,
	FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Clients]([Key]),
)
