using EatWell.PreSets;
using EatWell.Windows;
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

namespace EatWell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FamPreSet win2 = new FamPreSet();
            win2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PreSet2 win3 = new PreSet2();
            win3.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PreSet3 win4 = new PreSet3();
            win4.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Self_Design_Pizza win5 = new Self_Design_Pizza();
            win5.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
