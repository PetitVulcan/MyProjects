using FicheRecette.Tools;
using System;
using System.Collections.Generic;

namespace FicheRecette.Model
{
    public class Utilisateur
    {
        private string nom;
        private string prenom;
        private string nomutilisateur;
        private string eMail;
        private int id;
        private int nbRecettecree;
        private string mdp;


        public string NomUtilisateur { get => nomutilisateur; set => nomutilisateur = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public int Id { get => id; set => id = value; }
        public int NbRecettecree { get => nbRecettecree; set => nbRecettecree = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Utilisateur()
        {

        }
        public Utilisateur(string NomUtilisateur)
        {
            NomUtilisateur = nomutilisateur;
        }
        public Utilisateur(DateTime Date,string Nom,string Prenom, string NomUtilisateur, string EMail, int NbRecettecree)
        {
            NbRecettecree = 0;
            Date = DateTime.Now;
            Nom = nom;
            Prenom = prenom;
            NomUtilisateur = nomutilisateur;
            EMail = eMail;
            
        }
        public override string ToString()

        {
            return "NomUtilisateur : " + NomUtilisateur + " - Adresse email : " + EMail + " - Nombre de recette(s) crée(s) : " + NbRecettecree;
        }

        public void AjouterUtilisateur()
        {
            DataBase.Instance.AjouterUtilisateur(this);
        }

        public void SupprimerUtilisateur()
        {
            DataBase.Instance.SupprimerUtilisateur(this);
        }

        public static List<Utilisateur> AvoirListeUtilisateur()
        {
            return DataBase.Instance.AvoirListeUtilisateur();
        }
        public bool Exist()
        {
            return DataBase.Instance.LookUser(this);
        }
        public bool ExistWithPassword()
        {
            return DataBase.Instance.LookUser(NomUtilisateur,Mdp, this);
        }
    }
}
