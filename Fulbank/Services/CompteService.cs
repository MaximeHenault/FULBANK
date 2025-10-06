using Fulbank.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Services
{
    internal class CompteService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<Compte> GetComptes()
        {
            List<Compte> comptes = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Compte";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comptes.Add(new Compte
                        {
                            IdCompte = reader.GetInt32(0),
                            Solde = reader.GetDecimal(1),
                            IdAbonnement = reader.GetInt32(2),
                            IdMonnaie = reader.GetInt32(3)
                        });
                    }
                }
            }
            return comptes;
        }
    }
}
