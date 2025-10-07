using Fulbank.Models;
using Fulbank.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.ModelViews
{
    public class CryptoViewModel
    {
        public ObservableCollection<Crypto> Cryptos { get; set; } = new();

        private CryptoService _service = new CryptoService();

        public CryptoViewModel()
        {
            LoadCrypto();
        }

        private void LoadCrypto()
        {
            var listes = _service.GetCryptos();
            Cryptos.Clear();

            foreach (var element in listes)
            {
                Cryptos.Add(element);
            }
        }
    }
}
