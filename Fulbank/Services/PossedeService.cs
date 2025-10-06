using Fulbank.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Services
{
    internal class PossedeService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<Possede> GetPossedes()
        {
            List<Possede> possedes = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Possede";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        possedes.Add(new Possede
                        {
                            IdUtilisateur = reader.GetInt32(0),
                            IdCompte = reader.GetInt32(1)
                        });
                    }
                }
            }
            return possedes;
        }
    }
}
