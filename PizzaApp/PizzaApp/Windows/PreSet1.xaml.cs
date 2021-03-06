﻿using System;
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
using PizzaApp.Properties;

namespace PizzaApp.Windows
{
    /// <summary>
    /// Interaction logic for PreSet1.xaml
    /// </summary>
    public partial class PreSet1 : Window
    {
        public PreSet1()
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
                MessageBox.Show("Du har Bestilt en Pizza Nummer 1 til 40,- kr ");
                this.Close();
            }

        }
    }
}
