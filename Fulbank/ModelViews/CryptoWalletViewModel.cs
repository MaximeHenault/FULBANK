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
    public class CryptoWalletViewModel
    {
        public ObservableCollection<CryptoWallet> CryptoWallets { get; set; } = new();

        private CryptoWalletService _service = new CryptoWalletService();

        public CryptoWalletViewModel()
        {
            LoadCryptoWallets();
        }

        private void LoadCryptoWallets()
        {
            var listes = _service.GetCryptoWallets();
            CryptoWallets.Clear();

            foreach (var element in listes)
            {
                CryptoWallets.Add(element);
            }
        }
    }
}
