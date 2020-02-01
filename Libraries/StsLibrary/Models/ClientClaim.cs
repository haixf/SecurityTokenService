using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SecurityTokenService.Models
{
    public class ClientClaim
    {
        [Key]
        public Guid Key { get; set; }
        public Guid ClientKey { get; set; }
        public Guid ClaimKey { get; set; }
    }
}
