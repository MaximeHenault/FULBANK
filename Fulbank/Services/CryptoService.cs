using Fulbank.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Services
{
    internal class CryptoService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<Crypto> GetCryptos()
        {
            List<Crypto> cryptos = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Crypto";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cryptos.Add(new Crypto
                        {
                            IdCrypto = reader.GetInt32(0),
                            Libelle = reader.GetString(1),
                            IdCryptoWallet = reader.GetInt32(2)
                        });
                    }
                }
            }
            return cryptos;
        }
    }
}
