using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Fulbank.Services
{
    internal class CryptoGeckoService
    {
        private readonly HttpClient _httpClient;

        public CryptoGeckoService()
        {
            _httpClient = new HttpClient();
        }

        // Récupérer le prix d'une crypto-monnaie en EUR
        public async Task<decimal> GetCryptoPriceAsync(string cryptoId)
        {
            try
            {
                // Construire l'URL de l'API CoinGecko
                string url = $"https://api.coingecko.com/api/v3/simple/price?ids={cryptoId}&vs_currencies=usd";

                // Effectuer la requête GET
                var response = await _httpClient.GetStringAsync(url);

                // Analyser la réponse JSON
                var json = JObject.Parse(response);

                // Vérifier si le prix en EUR est disponible
                if (json[cryptoId]?["usd"] != null)
                {
                    return json[cryptoId]["usd"].Value<decimal>();
                }

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la récupération du prix : {ex.Message}");
                return 0;
            }
        }
    }
}
