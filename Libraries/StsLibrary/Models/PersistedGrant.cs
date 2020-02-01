using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StsLibrary.Models
{
    [Table("PersistedGrants", Schema = "sts")]
    public class PersistedGrant
    {
        [Key]
        public Guid Key { get; set; }
        public string IdentityServerKey { get; set; }
        public string Type { get; set; }
        public string SubjectId { get; set; }
        public string Data { get; set; }
        [ForeignKey("Key")]
        public Guid ClientKey { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public DateTimeOffset Expiration { get; set; }
    }
}
