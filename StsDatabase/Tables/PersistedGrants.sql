CREATE TABLE [sts].[PersistedGrants]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
    [IdentityServerKey] NVARCHAR(MAX) NOT NULL,
    [Type] NVARCHAR(200) NOT NULL,
    [SubjectId] NVARCHAR(200) NOT NULL,
    [Data] NVARCHAR(2000) NOT NULL,
    [ClientKey] UNIQUEIDENTIFIER NOT NULL,
    [CreationTime] DATETIMEOFFSET NOT NULL,
    [Expiration] DATETIMEOFFSET NULL,
    FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Clients]([Key]),
)
