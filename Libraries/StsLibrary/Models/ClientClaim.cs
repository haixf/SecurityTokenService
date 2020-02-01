using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SecurityTokenService.Models
{
    public class ClientClaim
    {
        [Key]
        public Guid Key { get; set; }
        [ForeignKey("Key")]
        public Guid ClientKey { get; set; }
        [ForeignKey("Key")]
        public Guid ClaimKey { get; set; }
    }
}
