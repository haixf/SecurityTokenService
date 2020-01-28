CREATE TABLE [sts].[Client]
(
    [Key] UNIQUEIDENTIFIER PRIMARY KEY,
	[ClientId] NVARCHAR(100) NOT NULL UNIQUE,
	[ClientName] NVARCHAR(100) NOT NULL UNIQUE,
	[Description] NVARCHAR(1000) NULL,
	[Enabled] BIT NOT NULL DEFAULT 1,
	[EnableLocalLogin] BIT NOT NULL DEFAULT 1,
	[AllowOfflineAccess] BIT  NOT NULL DEFAULT 1,
    [IdentityTokenLifetime] INT NOT NULL DEFAULT 3600,
	[AccessTokenLifetime] INT NOT NULL DEFAULT 3600,
	[AuthorizationCodeLifetime] INT NOT NULL DEFAULT 3600,
	[SlidingTokenLifetime] INT NOT NULL DEFAULT 3600,
	[ConsentLifeTime] INT NULL,
	[RefreshTokenUsage] INT NOT NULL DEFAULT 0,
	[UpdateAccessTokenClaimsOnRefresh] BIT NOT NULL DEFAULT 1,
	[RefreshTokenExpiration] INT NOT NULL DEFAULT 1,
	[AccessTokenType] INT NOT NULL DEFAULT 0,
	[IncludeJwtId] INT NOT NULL Default 1,
	[AlwaysSendClientClaims] INT NOT NULL DEFAULT 1
)
