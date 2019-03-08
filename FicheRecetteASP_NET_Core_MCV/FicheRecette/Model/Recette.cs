using FicheRecette.Model;
using FicheRecette.Tools;
using System;
using System.Collections.Generic;

namespace FicheRecette.Model
{
    public class Recette
    {
        private int id;
        private int idUtilisateur;
        private int idCategory;
        private DateTime date;
        private string nomUtilisateur;
        private string nomRecette;
        private int? nbPersonne;
        private string difficulte;
        private string ingredient;
        private string realisation;
        private List<ImageRecette> images;


        private static List<Recette> ListeRecette = new List<Recette>();
        public string NomRecette { get => nomRecette; set => nomRecette = value; }
        public int? NbPersonne { get => nbPersonne; set => nbPersonne = value; }
        public string Difficulte { get => difficulte; set => difficulte = value; }
        public string Ingredient { get => ingredient; set => ingredient = value; }
        public string Realisation { get => realisation; set => realisation = value; }
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<ImageRecette> Images { get => images; set => images = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }

        public Recette()

        {
            Images = new List<ImageRecette>();
            Date = DateTime.Now;
        }

        public void Ajouter()
        {
            DataBase.Instance.AjouterRecette(this);
        }

        public void Supprimer()
        {
            DataBase.Instance.SupprimerRecette(this);
        }

        public static List<Recette> AvoirListeRecette(int? idCategory)

        {
            return DataBase.Instance.AvoirListeRecette(idCategory);
        }
        //public static List<Recette> AvoirListeRecette(int? idUser)

        //{
        //    return DataBase.Instance.AvoirListeRecette(idUser);
        //}
    }
}
