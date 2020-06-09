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

namespace PizzaApp.Windows
{
    /// <summary>
    /// Interaction logic for PreSet2.xaml
    /// </summary>
    public partial class PreSet2 : Window
    {
        public PreSet2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Vil du bestille en eller flere sodavand med?",
                 "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                SodaSet win7 = new SodaSet();
                win7.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Du har Bestilt en Pizza Nummer 2 til 52,- kr ");
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
