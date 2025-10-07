using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Models
{
    public class Operation
    {
        public int IdOperation { get; set; }
        public DateTime DateOperation { get; set; }
        public decimal Montant { get; set; }
        public string IpDestinataire { get; set; }
        public string IpSource { get; set; }
        public string Statut { get; set; }
        public int? IdCryptoWallet { get; set; }
        public int? IdCryptoWallet_1 { get; set; }
        public int? IdCompte { get; set; }
        public int? IdCompte_1 { get; set; }
    }
}
