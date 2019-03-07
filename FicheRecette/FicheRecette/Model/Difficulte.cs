using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicheRecette.Model;
using FicheRecette.Tools;

namespace FicheRecette.Model
{
    public class Difficulte
    {
        private int id;
        private string titre;

        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }

        public void Add()
        {
            DataBase.Instance.AddDifficulte(this);
        }

        public void Delete()
        {
            DataBase.Instance.DeleteDifficulte(this);
        }


        public static List<Difficulte> GetDifficulte()
        {
            return DataBase.Instance.LoadDifficulte();
        }

    }
}

