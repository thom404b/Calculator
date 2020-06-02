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
    /// Interaction logic for DesginSet.xaml
    /// </summary>
    public partial class DesginSet : Window
    {
        public DesginSet()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string PizzaMessage = "Du har bestilt " + CbSize.Text + "" +  CbDej.Text + "" + CbSovs.Text + "" + CbTilbehør.Text + "" + CbOst.Text + "" + CbKrydderi.Text;
            MessageBox.Show(PizzaMessage);
        }
    }
}
