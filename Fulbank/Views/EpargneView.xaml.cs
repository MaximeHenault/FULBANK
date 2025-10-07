using Fulbank.ModelViews;
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

namespace Fulbank.Views
{
    /// <summary>
    /// Logique d'interaction pour EpargneView.xaml
    /// </summary>
    public partial class EpargneView : Window
    {
        public EpargneView()
        {
            InitializeComponent();
            DataContext = new EpargneViewModel();
        }
    }
}
