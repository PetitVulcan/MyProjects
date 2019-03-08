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
using FicheRecette.Classe;

namespace FicheRecette.Recette
{
   
    public partial class AjouterRecette : Window
    {
        public AjouterRecette()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Now;
            
            DataBase.AjouterRecette(date, nomUtilisateur, nomRecette, nbPersonne, difficulte, ingredient, realisation);
            this.Close();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
