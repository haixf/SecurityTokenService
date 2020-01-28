﻿CREATE TABLE [sts].[ClientGrantType]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientKey] UNIQUEIDENTIFIER NOT NULL,
	[GrantType] NVARCHAR(200) NOT NULL,
	FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Client]([Key]),
)
