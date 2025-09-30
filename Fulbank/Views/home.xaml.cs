using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fulbank
{
    /// <summary>
    /// Logique d'interaction pour home.xaml
    /// </summary>
    public partial class home : Window
    {
        public home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            this.DarkOverlay.Opacity = 0.5;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            this.DarkOverlay.Opacity = 0;
        }

    }
}
