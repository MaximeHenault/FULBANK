using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
using Fulbank;


namespace FULBANK
{
    public partial class MainWindow : Window
    {
        // Chaîne de connexion à adapter
        private string connectionString = "Server=172.16.119.44;Database=FULBANK;User Id=fulbank_user;Password=MonSuperMotDePasse123!;Encrypt=False;";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCharger_Click(object sender, RoutedEventArgs e)
        {
            // Vider la ListBox avant de charger
            lstClients.Items.Clear();

            try
            {
                // 1️⃣ Créer la connexion
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();  // 2️⃣ Ouvrir la connexion

                    // 3️⃣ Créer la commande SQL
                    string query = "SELECT devise FROM Monnaie";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // 4️⃣ Exécuter la commande
                    SqlDataReader reader = cmd.ExecuteReader();

                    // 5️⃣ Lire les résultats
                    while (reader.Read())
                    {
                        string nomClient = reader.GetString(0);
                        lstClients.Items.Add(nomClient);
                    }

                    // 6️⃣ La connexion se ferme automatiquement grâce à "using"
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erreur SQL : " + ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnChanger_Click(object sender, RoutedEventArgs e)
        {
            // Créer la nouvelle fenêtre
            Window1 w1 = new Window1();

            // Afficher la fenêtre
            w1.Show();

            // Fermer l’ancienne (facultatif, sinon elle reste ouverte)
            this.Close();
        }

        private void lstClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}