using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityTokenService.Models
{
    public class Resource : ResourceTableModel
    {
        public List<Scope> Scopes { get; set; }

    }
}
