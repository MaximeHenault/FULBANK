using Fulbank.Models;
using Fulbank.Services;
using MonProjetWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.ModelViews
{
    public class WalletViewModel
    {
        public ObservableCollection<Wallet> Wallets { get; set; } = new();

        private WalletService _service = new WalletService();

        public WalletViewModel()
        {
            LoadWallets();
        }

        private void LoadWallets()
        {
            var listes = _service.GetWallets();
            Wallets.Clear();

            foreach (var element in listes)
            {
                Wallets.Add(element);
            }
        }
    }
}
