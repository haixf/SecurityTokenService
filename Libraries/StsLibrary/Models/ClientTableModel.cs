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

    }
}
