using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Models
{
    internal class Carte
    {
        public int IdCarte { get; set; }
        public string Libelle { get; set; }
        public int IdCategorie { get; set; }
        public int IdCompte { get; set; }
    }
}
