using FicheRecette.Tools;
using FicheRecette.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FicheRecette.Model
{
    public class Category
    {
        private int id;
        private string titre;

        
        public int Id { get => id; set => id = value; }
        public string Titre { get => titre; set => titre = value; }

        public void Add()
        {
            DataBase.Instance.AddCategory(this);
        }

        public void Delete()
        {
            DataBase.Instance.DeleteCategory(this);
        }


        public static List<Category> GetCategories()
        {
            return DataBase.Instance.LoadCategories();
        }
    }
}
