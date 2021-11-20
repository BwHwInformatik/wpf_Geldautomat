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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGeldautomat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Konto bk = new Konto("Max Mustermann", 12.34);
            tbxKundenName.Text = bk.KundenName;
            tbxSaldo.Text = bk.Saldo.ToString();
        }

        private void btnAuszahlung_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSEPAUeberweisung_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHandyAufladen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEinzahlung_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGeldkarte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnKontoauszug_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
