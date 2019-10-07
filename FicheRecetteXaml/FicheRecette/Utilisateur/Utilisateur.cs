using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using Microsoft.VisualStudio.PlatformUI;

namespace FicheRecette.Utilisateur.utilisateur

{
    public class UtilisateurViewModel : ViewModelBase
    {
        private string nomUtilisateur;
        private string eMail;
        private int id;
        private int nbRecettecree;
        private string mdp;
        private readonly IClosable _view;


        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public int Id { get => id; set => id = value; }
        public int NbRecettecree { get => nbRecettecree; set => nbRecettecree = value; };
        public string Mdp { get => mdp; set => mdp = value; }

        public ICommand AddCommand { get; set; }

        public AddUtilisateurViewModel(IClosable view)
        {
            AddCommand = new DelegateCommand(Add);
            this._view = view;
        }

        private void Add()
        {
            UtilisateurService service = new UtilisateurService();
            service.Add(this.NomUtilisateur, this.EMail, this.NbRecettecree, this.Mdp);
            _view.Close();
        }

        public Utilisateur()
        {

        }
        public Utilisateur(string NomUtilisateur)
        {
            NomUtilisateur = nomUtilisateur;
        }
        public Utilisateur(DateTime Date, string NomUtilisateur, string EMail, int NbRecettecree, string Mdp)
        {
            NbRecettecree = 0;
            Date = DateTime.Now;
            NomUtilisateur = nomUtilisateur;
            EMail = eMail;



            byte[] raw = UTF8Encoding.UTF8.GetBytes(Mdp);

            byte[] hash;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = md5Hash.ComputeHash(raw);
            }

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sBuilder.Append(hash[i].ToString("x2"));


            Mdp = sBuilder.ToString();
        }

    }


}
