using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    [Table("ClientScopes", Schema = "sts")]
    public class ClientScope
    {
        [Key]
        public Guid Key { get; set; }
        [ForeignKey("Key")]
        public Guid ClientKey { get; set; }
        [ForeignKey("Key")]
        public Guid ScopeKey { get; set; }
    }
}
