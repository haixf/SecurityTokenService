using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    public class Client : ClientTableModel
    {
        public List<ClientSecret> ClientSecrets { get; set; }
        public List<ClientScope> AllowedScopes { get; set; }
        public List<ClientUri> ClientUris { get; set; }
    }
}
