using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    [Table("ClientUris", Schema = "sts")]
    public class ClientUri
    {
        [Key]
        public Guid Key { get; set; }
        [ForeignKey("Key")]
        public Guid ClientKey { get; set; }
        public string Uri { get; set; }
        public UriTypes Type { get; set; }

        public enum UriTypes
        {
            REDIRECT,
            POST
        }
    }
}
