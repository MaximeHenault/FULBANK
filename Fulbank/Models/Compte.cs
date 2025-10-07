using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Models
{
    public class Compte
    {
        public int IdCompte { get; set; }
        public decimal Solde { get; set; }
        public int IdAbonnement { get; set; }
        public int IdMonnaie { get; set; }
    }
}
