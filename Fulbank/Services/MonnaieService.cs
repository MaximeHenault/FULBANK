using Fulbank.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Services
{
    internal class MonnaieService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<Monnaie> GetMonnaies()
        {
            List<Monnaie> monnaies = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Monnaie";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        monnaies.Add(new Monnaie
                        {
                            IdMonnaie = reader.GetInt32(0),
                            Devise = reader.GetString(1)
                        });
                    }
                }
            }
            return monnaies;
        }
    }
}
