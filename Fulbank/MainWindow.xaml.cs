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
using Fulbank.Views;
using Fulbank;
using Fulbank.Models;
using Fulbank.ModelViews;


namespace FULBANK
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCharger_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnChanger_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            // Créer la nouvelle fenêtre
            Window1 w1 = new Window1();
=======
            UtilisateurView fenetreTest = new UtilisateurView();
>>>>>>> Stashed changes
=======
            UtilisateurView fenetreTest = new UtilisateurView();
>>>>>>> Stashed changes
=======
            UtilisateurView fenetreTest = new UtilisateurView();
>>>>>>> Stashed changes

            // Afficher la fenêtre
            fenetreTest.Show();

            // Fermer l’ancienne (facultatif, sinon elle reste ouverte)
            this.Close();
        }

        private void lstClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnTester_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAbonnement_Click(object sender, RoutedEventArgs e)
        {
            AbonnementView fenetreTest = new UtilisateurView();

            // Afficher la fenêtre
            fenetreTest.Show();

            // Fermer l’ancienne (facultatif, sinon elle reste ouverte)
            this.Close();
        }
>>>>>>> Stashed changes
    }
}