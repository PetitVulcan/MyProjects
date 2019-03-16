using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FicheRecette.Model
{
    public class Ingredient
    {
        private int id;
        private int idRecette;
        private string nom;

        public int Id { get => id; set => id = value; }
        public int IdRecette { get => idRecette; set => idRecette = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
