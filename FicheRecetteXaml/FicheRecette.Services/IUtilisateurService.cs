using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheRecette.Services
{
    public interface ICustomersService
    {
        IEnumerable<Utilisateur> Search(string name);

        IEnumerable<Recette> ConsulterListeRecette()(int id);

        void Add(string name, string phone, string email, string prenom);

        void Update(Utilisateur resource);

        void Delete(int id);
    }
}
