using Fulbank.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace MonProjetWPF.Services
{
    public class UtilisateurService
    {
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public List<Utilisateur> GetUtilisateurs()
        {
            List<Utilisateur> utilisateurs = new();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Utilisateur";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        utilisateurs.Add(new Utilisateur
                        {
                            IdUtilisateur = reader.GetInt32(0),
                            Nom = reader.GetString(1),
                            Prenom = reader.GetString(2),
                            IdWallet = reader.GetInt32(3)
                        });
                    }
                }
            }
            return utilisateurs;
        }
    }
}
