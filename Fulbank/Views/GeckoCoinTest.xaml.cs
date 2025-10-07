using Fulbank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fulbank.Views
{
    /// <summary>
    /// Logique d'interaction pour GeckoCoinTest.xaml
    /// </summary>
    public partial class GeckoCoinTest : Window
    {
        private CryptoGeckoService _cryptoService;

        public GeckoCoinTest()
        {
            InitializeComponent();
            _cryptoService = new CryptoGeckoService();
            LoadCryptoPrice();
        }

        private async void LoadCryptoPrice()
        {
            decimal bitcoinPrice = await _cryptoService.GetCryptoPriceAsync("bitcoin");
            lblBitcoinPrice.Content = $"Bitcoin : {bitcoinPrice} $";
        }

        private async void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd");
                var json = JsonSerializer.Deserialize<JsonElement>(response);
                var bitcoinPrice = json.GetProperty("bitcoin").GetProperty("usd").GetDecimal();
                lblBitcoinPrice.Content = $"Bitcoin : {bitcoinPrice} $";
            }
        }


    }
}
