CREATE TABLE [sts].[Scope]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ResourceKey] UNIQUEIDENTIFIER,
	[Name] nvarchar(200) NOT NULL UNIQUE,
	FOREIGN KEY ([ResourceKey]) REFERENCES [sts].[Resource]([Key])
)
