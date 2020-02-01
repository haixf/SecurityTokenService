using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SecurityTokenService.Models
{
    [Table("Clients", Schema = "sts")]
    public class ClientTableModel
    {
        [Key]
        public Guid Key { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool EnableLocalLogin { get; set; }
        public bool AllowOfflineAcccess { get; set; }
        public int AccessTokenLifetime { get; set; }
        public int IdentityTokenLifetime { get; set; }
        public int AuthorizationCodeLifetime { get; set; }
        public int SlidingTokenLifetime { get; set; }
        public int? ConsentLifetime { get; set; }
        public int RefreshTokenUsage { get; set; }
        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }
        public int RefreshTokenExpiration { get; set; }
        /// <summary>
        /// 0 is JWT. That is what we want to use
        /// </summary>
        public int AccessTokenType = 0;
        public bool IncludeJwtId { get; set; }
        public bool AlwaysSendClientClaims = true;
    }
}
