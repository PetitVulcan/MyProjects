using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheRecette.Classe
{
    class Recette
    {
        private int id;
        private DateTime date;
        private string nomUtilisateur;
        private string nomRecette;
        private int nbPersonne;
        private string difficulte;
        private string ingredient;
        private string realisation;



        public string NomRecette { get => nomRecette; set => nomRecette = value; }
        public int NbPersonne { get => nbPersonne; set => nbPersonne = value; }
        public string Difficulte { get => difficulte; set => difficulte = value; }
        public string Ingredient { get => ingredient; set => ingredient = value; }
        public string Realisation { get => realisation; set => realisation = value; }
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }

        public Recette()

        {

        }

        public Recette(string nomRecette, int nbPersonne, string difficulte)

        {
            NomRecette = nomRecette;
            NbPersonne = nbPersonne;
            Difficulte = difficulte;
        }

        public Recette(DateTime date, string nomUtilisateur, string nomRecette, int nbPersonne, string difficulte, string ingredient, string realisation)

        {
            NomRecette = nomRecette;
            NbPersonne = nbPersonne;
            Difficulte = difficulte;
            Ingredient = ingredient;
            Realisation = realisation;
        }


        public override string ToString()

        {
            return "Nom : " + NomRecette + " - Nb de Personnes: " + NbPersonne + " - Niveau de difficulté : " + Difficulte;
        }

        private static List<Recette> ListeRecette = new List<Recette>();
        public static List<Recette> AvoirRecette(Recette r)

        {
            return ListeRecette;
        }
    }
}
