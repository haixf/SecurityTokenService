CREATE TABLE [sts].[PersistedGrants]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
    [IdentityServerKey] NVARCHAR(1000) NOT NULL,
    [Type] NVARCHAR(200) NOT NULL,
    [SubjectId] NVARCHAR(200) NOT NULL,
    [Data] NVARCHAR(2000) NOT NULL,
    [ClientKey] UNIQUEIDENTIFIER NOT NULL,
    [CreationTime] DATETIME NOT NULL,
    [Expiration] DATETIME NULL,
    FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Clients]([Key]),
)
