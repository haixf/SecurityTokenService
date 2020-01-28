CREATE TABLE [sts].[ClientSecret]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientKey] UNIQUEIDENTIFIER NOT NULL,
	FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Client]([Key]),
)
