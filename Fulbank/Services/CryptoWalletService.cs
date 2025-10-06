using Fulbank.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Services
{
    internal class CryptoWalletService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<CryptoWallet> GetCryptoWallets()
        {
            List<CryptoWallet> cryptowallets = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CryptoWallet";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cryptowallets.Add(new CryptoWallet
                        {
                            IdCryptoWallet = reader.GetInt32(0),
                            Quantite = reader.GetInt32(1)
                        });
                    }
                }
            }
            return cryptowallets;
        }
    }
}
