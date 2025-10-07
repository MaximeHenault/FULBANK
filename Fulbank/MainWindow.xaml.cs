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
            WalletView fenetreWallet = new WalletView();
            fenetreWallet.Show();

            this.Close();
        }

        private void BtnPossede_Click(object sender, RoutedEventArgs e)
        {
            PossedeView fenetrePossede = new PossedeView();
            fenetrePossede.Show();

            this.Close();
        }

        private void BtnMonnaie_Click(object sender, RoutedEventArgs e)
        {
            MonnaieView fenetreMonnaie = new MonnaieView();
            fenetreMonnaie.Show();

            this.Close();
        }

        private void BtnCryptoWallet_Click(object sender, RoutedEventArgs e)
        {
            CryptoWalletView fenetreCryptoWallet = new CryptoWalletView();
            fenetreCryptoWallet.Show();

            this.Close();
        }

        private void BtnCourant_Click(object sender, RoutedEventArgs e)
        {
            CourantView fenetreCourant = new CourantView();
            fenetreCourant.Show();

            this.Close();
        }

        private void BtnCategorieCarte_Click(object sender, RoutedEventArgs e)
        {
            CategorieCarteView fenetreCategorieCarte = new CategorieCarteView();
            fenetreCategorieCarte.Show();

            this.Close();
        }

        private void BtnCarte_Click(object sender, RoutedEventArgs e)
        {
            CarteView fenetreCarte = new CarteView();
            fenetreCarte.Show();

            this.Close();
        }

        private void BtnCompte_Click(object sender, RoutedEventArgs e)
        {
            CompteView fenetreCompte = new CompteView();
            fenetreCompte.Show();

            this.Close();
        }

        private void BtnCrypto_Click(object sender, RoutedEventArgs e)
        {
            CryptoView fenetreCrypto = new CryptoView();
            fenetreCrypto.Show();

            this.Close();
        }

        private void BtnEpargne_Click(object sender, RoutedEventArgs e)
        {
            EpargneView fenetreEpargne = new EpargneView();
            fenetreEpargne.Show();

            this.Close();
        }

        private void BtnOperation_Click(object sender, RoutedEventArgs e)
        {
            OperationView fenetreOperation = new OperationView();
            fenetreOperation.Show();

            this.Close();
        }

        private void BtnUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            UtilisateurView fenetreUser = new UtilisateurView();
            fenetreUser.Show();

            this.Close();
        }
    }
}