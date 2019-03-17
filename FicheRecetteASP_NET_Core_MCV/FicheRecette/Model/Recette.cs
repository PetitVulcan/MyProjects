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
        private int idrecette;
        private DateTime date;
        private string nomCategory;
        private string nomUtilisateur;
        private string nomRecette;
        private int? nbPersonne;
        private string difficulte;
        private string ingredient;
        private string realisation;
        private List<ImageRecette> images;
        private List<Ingredient> ingredients;
        private static List<Recette> ListeRecette = new List<Recette>();
        private static List<Recette> InfoRecette = new List<Recette>();

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
        public int Idrecette { get => idrecette; set => idrecette = value; }
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        public string NomCategory { get => nomCategory; set => nomCategory = value; }

        public Recette()

        {
            Ingredients=new List<Ingredient>();
            Images = new List<ImageRecette>();
            Date = DateTime.Now;
        }
        public Recette(int Id, DateTime Date, string NomUtilisateur, string NomRecette, int? NbPersonne, string Difficulte, string Ingredient, string Realisation, string NomCategory, List<ImageRecette> Images)

        {
            Images = new List<ImageRecette>();
            Date = date;
            NomUtilisateur = nomUtilisateur;
            NomRecette = nomRecette;
            NbPersonne = nbPersonne;
            Difficulte = difficulte;
            Ingredient = ingredient;
            Realisation = realisation;
            NomCategory = nomCategory;
        }
       

        public void AjouterRecette()
        {
            DataBase.Instance.AjouterRecette(this);
        }

        public void Supprimer()
        {
            DataBase.Instance.SupprimerRecette(this);
        }

        public static List<Recette> GetRecette(int Id)

        {
            return DataBase.Instance.AfficherRecette(Id);         
        }

        public static List<Recette> AvoirListeRecette(int? IdCategory)

        {
            return DataBase.Instance.AvoirListeRecette(IdCategory);
        }
        
    }
}
