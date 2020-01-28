using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    [Table("ClientSecret", Schema = "sts")]
    public class ClientSecret
    {
        [Key]
        public Guid Key { get; set; }

        [ForeignKey("Key")]
        public Guid ClientKey { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }
        public string Type = "SharedSecret";


        public IdentityServer4.Models.Secret ConvertToIdsModel()
        {
            return new IdentityServer4.Models.Secret
            {
                Description = this.Description,
                Expiration = this.Expiration,
                Type = this.Type,
                Value = this.Value
            };
        }
    }
}
