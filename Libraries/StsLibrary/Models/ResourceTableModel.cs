using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    [Table("Resources", Schema = "sts")]
    public class ResourceTableModel
    {
        [Key]
        public Guid Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public string DisplayName { get; set; }
        public ResourceTypes ResourceType { get; set; }
        public bool Required { get; set; }
        public bool Emphasize { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public enum ResourceTypes
        {
            IDENTITY = 0,
            API = 1
        }
    }
}
