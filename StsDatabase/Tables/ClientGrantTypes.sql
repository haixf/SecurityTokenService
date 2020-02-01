CREATE TABLE [sts].[ClientGrantTypes]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientKey] UNIQUEIDENTIFIER NOT NULL,
	[GrantType] NVARCHAR(200) NOT NULL,
	FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Clients]([Key]),
)
