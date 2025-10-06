using Fulbank.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Services
{
    internal class EpargneService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<Epargne> GetEpargnes()
        {
            List<Epargne> epargnes = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Epargne";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        epargnes.Add(new Epargne
                        {
                            IdCompte = reader.GetInt32(0),
                            Taux = reader.GetDecimal(1)
                        });
                    }
                }
            }
            return epargnes;
        }
    }
}
