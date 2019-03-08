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
using FicheRecette.Classe;

namespace FicheRecette
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Se_Loger_Click(object sender, RoutedEventArgs e)
        {
             Login.ShowDialog();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AjouterRecette_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
