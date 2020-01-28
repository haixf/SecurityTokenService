using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    public class Scope
    {
        [Key]
        public Guid Key { get; set; }
        [ForeignKey("Key")]
        public Guid ResourceKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Required { get; set; }
        public bool Emphasize { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public IdentityServer4.Models.Scope ConvertToIdsModel()
        {
            return new IdentityServer4.Models.Scope
            {
                Name = this.Name,
                Description = this.Description,
                DisplayName = this.DisplayName,
                Required = this.Required,
                Emphasize = this.Emphasize,
                ShowInDiscoveryDocument = this.ShowInDiscoveryDocument
            };
        }
    }
}
