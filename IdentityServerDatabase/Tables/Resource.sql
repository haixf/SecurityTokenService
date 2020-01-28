﻿CREATE TABLE [sts].[Resource]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ResourceType] NVARCHAR(10) NOT NULL,
	[Name] NVARCHAR(100) NOT NULL UNIQUE,
	[DisplayName] NVARCHAR(100) NOT NULL UNIQUE,
	[Description] NVARCHAR(200) NULL,
	[Enabled] BIT NOT NULL DEFAULT 1,
	[Required] BIT NOT NULL DEFAULT 1,
	[Emphasize] BIT NOT NULL DEFAULT 1,
	[ShowInDiscoveryDocument] BIT NOT NULL DEFAULT 1
)
