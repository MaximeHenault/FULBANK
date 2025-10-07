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
            // Créer la nouvelle fenêtre
            UtilisateurView fenetreUser = new UtilisateurView();
            // Afficher la fenêtre
            fenetreUser.Show();

            // Fermer l’ancienne (facultatif, sinon elle reste ouverte)
            this.Close();
        }

        private void lstClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BtnTester_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAbonnement_Click(object sender, RoutedEventArgs e)
        {
            AbonnementView fenetreAbonnement = new AbonnementView();

            // Afficher la fenêtre
            fenetreAbonnement.Show();

            // Fermer l’ancienne (facultatif, sinon elle reste ouverte)
            this.Close();
        }

        private void BtnWallet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPossede_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMonnaie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCryptoWallet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCourant_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCategorieCarte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCarte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCompte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCrypto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEpargne_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOperation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUtilisateur_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}