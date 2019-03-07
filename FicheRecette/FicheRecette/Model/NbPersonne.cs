using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FicheRecette.Model;
using FicheRecette.Tools;

namespace FicheRecette.Model
{
    public class NbPersonne
    {
        private int id;
        private int? choixNbPersonne;

        public int Id { get => id; set => id = value; }
        public int? ChoixNbPersonne { get => choixNbPersonne; set => choixNbPersonne = value; }

        public void Add()
        {
            DataBase.Instance.AddNbPersonne(this);
        }

        public void Delete()
        {
            DataBase.Instance.DeleteNbPersonne(this);
        }


        public static List<NbPersonne>GetNbPersonne()
        {
            return DataBase.Instance.LoadNbPersonne();
        }

    }
}
