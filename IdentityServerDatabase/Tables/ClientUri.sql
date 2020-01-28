﻿CREATE TABLE [sts].[ClientUri]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientKey] UNIQUEIDENTIFIER NOT NULL,
	[UriType] NVARCHAR(100) NOT NULL,
	[Uri] NVARCHAR(200) NOT NULL,
	FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Client]([Key])
)