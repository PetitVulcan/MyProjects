using FicheRecette.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace FicheRecette.Tools
{
    public class DataBase
    {
        private static DataBase _instance = null;
        private static object _lock = new object();

        private DataBase()
        {

        }
        public static DataBase Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataBase();
                    }
                    return _instance;
                }
            }
        }


        public void AjouterRecette(Recette r)
        {
            SqlCommand command = new SqlCommand("INSERT INTO recette (date,nomutilisateur,nomrecette,nbpersonne,difficulte,ingredient,realisation,Idcategory) OUTPUT INSERTED.id values(@Date,@NomUtilisateur,@NomRecette,@NbPersonne,@Difficulte,@Ingredient,@Realisation,@IdCategory)", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime) { Value = DateTime.Now });
            command.Parameters.Add(new SqlParameter("@NomUtilisateur", SqlDbType.VarChar) { Value = r.NomUtilisateur });
            command.Parameters.Add(new SqlParameter("@NomRecette", SqlDbType.VarChar) { Value = r.NomRecette });
            command.Parameters.Add(new SqlParameter("@NbPersonne", SqlDbType.Int) { Value = r.NbPersonne });
            command.Parameters.Add(new SqlParameter("@Difficulte", SqlDbType.VarChar) { Value = r.Difficulte });
            command.Parameters.Add(new SqlParameter("@Ingredient", SqlDbType.NText) { Value = r.Ingredient });
            command.Parameters.Add(new SqlParameter("@Realisation", SqlDbType.NText) { Value = r.Realisation });
            command.Parameters.Add(new SqlParameter("@IdCategory", SqlDbType.Int) { Value = r.IdCategory });
            Connection.Instance.Open();
            r.Id = (int)command.ExecuteScalar();
            command.Dispose();
            foreach (ImageRecette img in r.Images)
            {
                command = new SqlCommand("INSERT INTO images (urlimage,Idrecette) values(@Url,@Idrecette)", Connection.Instance);
                command.Parameters.Add(new SqlParameter("@Url", img.Url));
                command.Parameters.Add(new SqlParameter("@Idrecette", r.Id));
                command.ExecuteNonQuery();
                command.Dispose();
            }

            command = new SqlCommand("UPDATE utilisateur SET nbRecettecree = nbRecettecree+1 WHERE nomutilisateur = @nomUtilisateur", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@nomUtilisateur", SqlDbType.VarChar) { Value = r.NomUtilisateur });
            command.ExecuteNonQuery();
            command.Dispose();
            
            Connection.Instance.Close();
            return;
        }


        public void SupprimerRecette(Recette r)
        {
            SqlCommand command = new SqlCommand("DELETE FROM recette WHERE id=@id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", r.Id));
            Connection.Instance.Open();
            command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
            return;
        }

        public List<Recette> AvoirListeRecette(int? idCategory)
        {
            List<Recette> listeRecette = new List<Recette>();
            SqlCommand command;
            if (idCategory == null)
            {
                command = new SqlCommand("SELECT * From Recette", Connection.Instance);
            }
            else
            {
                command = new SqlCommand("SELECT IdCategory, Id, NomRecette, NbPersonne, Difficulte, NomUtilisateur, Date From recette WHERE IdCategory = @idcategory", Connection.Instance);
                command.Parameters.Add(new SqlParameter("@idcategory", idCategory));
            }
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Recette r = new Recette { IdCategory = reader.GetInt32(8), Id = reader.GetInt32(0), NomRecette = reader.GetString(3), NbPersonne = reader.GetInt32(4), Difficulte = reader.GetString(5), NomUtilisateur = reader.GetString(2), Date = reader.GetDateTime(1) };
                listeRecette.Add(r);

            }
            reader.Close();
            command.Dispose();
            for (int i = 0; i < listeRecette.Count; i++)
            {
                command = new SqlCommand("SELECT Id, Urlimage from images WHERE Idrecette = @idrecette", Connection.Instance);
                command.Parameters.Add(new SqlParameter("@idrecette", listeRecette[i].Id));
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listeRecette[i].Images.Add(new ImageRecette { Id = reader.GetInt32(0), Url = reader.GetString(1) });
                }
                reader.Close();
                command.Dispose();
            }
            Connection.Instance.Close();
            return listeRecette;
        }

        public List<Recette> AfficherRecette(int Id)
        {
            
                List<Recette> InfoRecette = new List<Recette>();
                SqlCommand command = new SqlCommand("SELECT * FROM recette WHERE Id=@Id", Connection.Instance);
                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = Id });
                Connection.Instance.Open();
                SqlDataReader reader = command.ExecuteReader();
           
                while (reader.Read())
                {
                Recette r = new Recette { IdCategory = reader.GetInt32(8), Id = reader.GetInt32(0), NomRecette = reader.GetString(3), NbPersonne = reader.GetInt32(4), Difficulte = reader.GetString(5), NomUtilisateur = reader.GetString(2), Date = reader.GetDateTime(1), Ingredient = reader.GetString(6) , Realisation = reader.GetString(7) };
                InfoRecette.Add(r);
                }
                reader.Close();
                command.Dispose();
                for (int i = 0; i < InfoRecette.Count; i++)
                {
                    command = new SqlCommand("SELECT Id, Urlimage from images WHERE Idrecette = @Id", Connection.Instance);
                    command.Parameters.Add(new SqlParameter("@Id", InfoRecette[i].Id));
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        InfoRecette[i].Images.Add(new ImageRecette { Id = reader.GetInt32(0), Url = reader.GetString(1) });
                    }
                    reader.Close();
                    command.Dispose();
                }
                Connection.Instance.Close();
                return InfoRecette;
        }
            public List<NbPersonne> LoadNbPersonne()
        {
            List<NbPersonne> liste = new List<NbPersonne>();
            SqlCommand command = new SqlCommand("SELECT * FROM nbpersonne", Connection.Instance);
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NbPersonne n = new NbPersonne { Id = reader.GetInt32(0), ChoixNbPersonne = reader.GetInt32(1) };
                liste.Add(n);
            }
            reader.Close();
            command.Dispose();
            Connection.Instance.Close();
            return liste;
        }
        public void AddNbPersonne(NbPersonne n)
        {
            SqlCommand command = new SqlCommand("INSERT INTO nbpersonne(nbpersonnes) OUTPUT INSERTED.ID VALUES(@ChoixNbPersonne)", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@ChoixNbPersonne", n.ChoixNbPersonne));
            Connection.Instance.Open();
            n.Id = (int)command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
        }

        public void DeleteNbPersonne(NbPersonne n)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nbpersonne WHERE Id = @id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", n.Id));
            Connection.Instance.Open();
            command.ExecuteNonQuery();
            Connection.Instance.Close();
        }


        public List<Difficulte> LoadDifficulte()
        {
            List<Difficulte> liste = new List<Difficulte>();
            SqlCommand command = new SqlCommand("SELECT * FROM difficulte", Connection.Instance);
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Difficulte d = new Difficulte { Id = reader.GetInt32(0), Titre = reader.GetString(1) };
                liste.Add(d);
            }
            reader.Close();
            command.Dispose();
            Connection.Instance.Close();
            return liste;
        }
        public void AddDifficulte(Difficulte d)
        {
            SqlCommand command = new SqlCommand("INSERT INTO difficulte(titre) OUTPUT INSERTED.ID VALUES(@Titre)", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@Titre", d.Titre));
            Connection.Instance.Open();
            d.Id = (int)command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
        }

        public void DeleteDifficulte(Difficulte d)
        {
            SqlCommand command = new SqlCommand("DELETE FROM difficulte WHERE Id = @id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", d.Id));
            Connection.Instance.Open();
            command.ExecuteNonQuery();
            Connection.Instance.Close();
        }

        public List<Category> LoadCategories()
        {
            List<Category> liste = new List<Category>();
            SqlCommand command = new SqlCommand("SELECT * FROM Category", Connection.Instance);
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Category c = new Category { Id = reader.GetInt32(0), Titre = reader.GetString(1) };
                liste.Add(c);
            }
            reader.Close();
            command.Dispose();
            Connection.Instance.Close();
            return liste;
        }
        public void AddCategory(Category c)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Category(Titre) OUTPUT INSERTED.ID VALUES(@Titre)", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@Titre", c.Titre));
            Connection.Instance.Open();
            c.Id = (int)command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
        }

        public void DeleteCategory(Category c)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Category WHERE Id = @id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", c.Id));
            Connection.Instance.Open();
            command.ExecuteNonQuery();
            Connection.Instance.Close();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public void AjouterUtilisateur(Utilisateur u)
        {
            SqlCommand command = new SqlCommand("INSERT INTO utilisateur (date,nom,prenom,nomutilisateur,email,nbrecettecree,mdp) OUTPUT INSERTED.id values(@date,@nom,@prenom,@NomUtilisateur,@eMail,@NbRecettecree,@Mdp)", Connection.Instance);
            MD5 md5Hash = MD5.Create();
            string MdpHash = GetMd5Hash(md5Hash, u.Mdp);
            command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date) { Value = DateTime.Now });
            command.Parameters.Add(new SqlParameter("@Nom", SqlDbType.VarChar) { Value = u.Nom });
            command.Parameters.Add(new SqlParameter("@Prenom", SqlDbType.VarChar) { Value = u.Prenom });
            command.Parameters.Add(new SqlParameter("@NomUtilisateur", SqlDbType.VarChar) { Value = u.NomUtilisateur });
            command.Parameters.Add(new SqlParameter("@eMail", SqlDbType.VarChar) { Value = u.EMail });
            command.Parameters.Add(new SqlParameter("@NbRecettecree", SqlDbType.Int) { Value = 0 });
            command.Parameters.Add(new SqlParameter("@Mdp", SqlDbType.VarChar) { Value = MdpHash });
            Connection.Instance.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            Connection.Instance.Close();
            return;
        }

        public void SupprimerUtilisateur(Utilisateur u)
        {
            SqlCommand command = new SqlCommand("DELETE FROM utilisateur WHERE Id=@Id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", u.Id));
            Connection.Instance.Open();
            command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
            return;
        }

        public List<Utilisateur> AvoirListeUtilisateur()
        {
            List<Utilisateur> listeUtilisateur = new List<Utilisateur>();
            SqlCommand command = new SqlCommand("SELECT * FROM Utilisateur", Connection.Instance);
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Utilisateur u = new Utilisateur { Id = reader.GetInt32(0), Nom = reader.GetString(2), Prenom = reader.GetString(3), NomUtilisateur = reader.GetString(4), EMail = reader.GetString(5), NbRecettecree = reader.GetInt32(6) };
                listeUtilisateur.Add(u);
            }
            reader.Close();
            command.Dispose();
            Connection.Instance.Close();
            return listeUtilisateur;
        }
        public bool LookUser(Utilisateur u)
        {
            bool retour = false;
            if (u.NomUtilisateur != null)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Utilisateur where NomUtilisateur=@NomUtilisateur", Connection.Instance);
                command.Parameters.Add(new SqlParameter("@NomUtilisateur", u.NomUtilisateur));
                Connection.Instance.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    u.Id = reader.GetInt32(0);
                    retour = true;
                }
                else
                {
                    retour = false;
                }
                reader.Close();
                command.Dispose();
                Connection.Instance.Close();
            }
            else
            {
                retour = false;
            }

            return retour;
        }

        public bool LookUser(string NomUtilisateur, string Mdp, Utilisateur u)
        {
            bool retour = false;
            if (NomUtilisateur != null)
            {
                MD5 md5Hash = MD5.Create();
                string MdpHash = GetMd5Hash(md5Hash, Mdp);
                SqlCommand command = new SqlCommand("SELECT Id, Nom, Prenom FROM Utilisateur where NomUtilisateur=@NomUtilisateur and Mdp = @Mdp", Connection.Instance);
                command.Parameters.Add(new SqlParameter("@NomUtilisateur", NomUtilisateur));
                command.Parameters.Add(new SqlParameter("@Mdp", MdpHash));
                Connection.Instance.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    u.Id = reader.GetInt32(0);
                    u.Nom = reader.GetString(1);
                    u.Prenom = reader.GetString(2);
                    retour = true;
                }
                else
                {
                    retour = false;
                }
                reader.Close();
                command.Dispose();
                Connection.Instance.Close();
            }
            else
            {
                retour = false;
            }

            return retour;
        }
    }
}