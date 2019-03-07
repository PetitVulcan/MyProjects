using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FicheRecette.Model
{
    public class ImageRecette
    {
        private int id;
        private string url;

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
    }
}
