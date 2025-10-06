using Fulbank.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Services
{
    internal class OperationService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<Operation> GetOperations()
        {
            List<Operation> operations = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Operation";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        operations.Add(new Operation
                        {
                            IdOperation = reader.GetInt32(0),
                            DateOperation = reader.GetDateTime(1),
                            Montant = reader.GetDecimal(2),
                            IpDestinataire = reader.GetString(3),
                            IpSource = reader.GetString(4),
                            Statut = reader.GetString(5),
                            IdCryptoWallet = reader.GetInt32(6),
                            IdCryptoWallet_1 = reader.GetInt32(7),
                            IdCompte_1 = reader.GetInt32(8),
                        });
                    }
                }
            }
            return operations;
        }
    }
}
