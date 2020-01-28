﻿CREATE TABLE [sts].[ClientClaim]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientKey] UNIQUEIDENTIFIER NOT NULL,
	[ClaimKey] UNIQUEIDENTIFIER NOT NULL,
	FOREIGN KEY ([ClientKey]) REFERENCES [sts].[Client]([Key]),
	FOREIGN KEY ([ClaimKey]) REFERENCES [sts].[Claim]([Key])
)
