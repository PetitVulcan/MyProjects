using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FicheRecette.Utilisateur;


namespace FicheRecette.Classe
{
    class DataBase
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
        public void AjouterRecette(DateTime date, string nomUtilisateur, string nomRecette, int nbPersonne, string difficulte, string ingredient, string realisation)
        {

            SqlCommand command = new SqlCommand("INSERT INTO recette (date,nomutilisateur,nomrecette,nbpersonne,difficulte,ingredient,realisation) OUTPUT INSERTED.id values(@date,@nomutilisateur,@nomRecette,@nbPersonne,@difficulte,@ingredient,@realisation)", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@date", SqlDbType.DateTime) { Value = date });
            command.Parameters.Add(new SqlParameter("@nomUtilisateur", SqlDbType.VarChar) { Value = nomUtilisateur });
            command.Parameters.Add(new SqlParameter("@nomRecette", SqlDbType.VarChar) { Value = nomRecette });
            command.Parameters.Add(new SqlParameter("@nbPersonne", SqlDbType.Int) { Value = nbPersonne });
            command.Parameters.Add(new SqlParameter("@difficulte", SqlDbType.VarChar) { Value = difficulte });
            command.Parameters.Add(new SqlParameter("@ingredient", SqlDbType.Text) { Value = ingredient });
            command.Parameters.Add(new SqlParameter("@realisation", SqlDbType.Text) { Value = realisation });

            Connection.Instance.Open();
            command.ExecuteNonQuery();
            command.Dispose();
            Connection.Instance.Close();
            AjouterRecetteCree(nomUtilisateur);
            Console.Clear();
            return;
        }

        public void AjouterRecetteCree(String nomUtilisateur)
        {
            int nbRecette = 0;
            SqlCommand command = new SqlCommand(
                "SELECT nbRecette FROM utilisateur WHERE nom = @NomUtilisateur", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@NomUtilisateur", SqlDbType.VarChar) { Value = nomUtilisateur });

            Connection.Instance.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nbRecette = reader.GetInt32(0);
            }

            nbRecette++;

            command.Dispose();
            reader.Close();

            command = new SqlCommand(
                "UPDATE utilisateur SET nbRecette = @nbRecette", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@nbRecette", SqlDbType.Int) { Value = nbRecette });

            command.ExecuteNonQuery();

            command.Dispose();
            Connection.Instance.Close();
        }
        
        public void SupprimerRecette(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM recette WHERE id=@id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = id });
            Connection.Instance.Open();
            command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
            Console.WriteLine("Recette Supprimée, Veuillez patienter...");
            Thread.Sleep(3000);
            Console.Clear();
            return;
        }

        public void AfficherRecette(int id, Recette r)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM recette WHERE id=@id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = r.Id });
            command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date) { Value = r.Date });
            command.Parameters.Add(new SqlParameter("@NomUtilisateur", SqlDbType.VarChar) { Value = r.NomUtilisateur });
            command.Parameters.Add(new SqlParameter("@NomRecette", SqlDbType.VarChar) { Value = r.NomRecette });
            command.Parameters.Add(new SqlParameter("@NbPersonne", SqlDbType.Int) { Value = r.NbPersonne });
            command.Parameters.Add(new SqlParameter("@Difficulte", SqlDbType.VarChar) { Value = r.Difficulte });
            command.Parameters.Add(new SqlParameter("@Ingredient", SqlDbType.VarChar) { Value = r.Ingredient });
            command.Parameters.Add(new SqlParameter("@Realisation", SqlDbType.VarChar) { Value = r.Realisation });
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                new Recette() { Id = reader.GetInt32(0), Date = reader.GetDateTime(1), NomUtilisateur = reader.GetString(2), NomRecette = reader.GetString(3), NbPersonne = reader.GetInt32(4), Difficulte = reader.GetString(5), Ingredient = reader.GetString(6), Realisation = reader.GetString(5) };
            }
            return;

        }

        public int AjouterUtilisateur(DateTime Date, string NomUtilisateur, string EMail, int NbRecettecree, string Mdp)
        {

            int id;
            SqlCommand command = new SqlCommand("INSERT INTO utilisateur (date,nomutilisateur,email,nbrecettecree,mdp) OUTPUT INSERTED.id values(@date,@NomUtilisateur,@eMail,@NbRecettecree,@Mdp)", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date) { Value = DateTime.Now });
            command.Parameters.Add(new SqlParameter("@NomUtilisateur", SqlDbType.VarChar) { Value = NomUtilisateur });
            command.Parameters.Add(new SqlParameter("@eMail", SqlDbType.VarChar) { Value = EMail });
            command.Parameters.Add(new SqlParameter("@NbRecettecree", SqlDbType.Int) { Value = 0 });
            command.Parameters.Add(new SqlParameter("@Mdp", SqlDbType.VarChar) { Value = Mdp });
            Connection.Instance.Open();
            id = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            Connection.Instance.Close();

            Console.Clear();
            return id;
        }

        //public Utilisateur UtilisateurExist(string NomUtilisateur)
        //{
        //    Utilisateur u = null;
        //    SqlCommand command = new SqlCommand("SELECT * FROM utilisateur WHERE nomutilisateur = @NomUtilisateur ", Connection.Instance);
        //    command.Parameters.Add(new SqlParameter("@NomUtilisateur", SqlDbType.VarChar) { Value = NomUtilisateur });
        //    Connection.Instance.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    if (reader.Read())
        //    {
        //        u = new Utilisateur() { NomUtilisateur = reader.GetString(4) };
        //    }
        //    reader.Close();
        //    command.Dispose();
        //    Connection.Instance.Close();
        //    return u;
        //}
                     
        public List<Recette> ConsulterListeRecette()
        {
            List<Recette> liste = new List<Recette>();
            SqlCommand command = new SqlCommand("SELECT * FROM recette order by nomrecette ASC", Connection.Instance);
            Connection.Instance.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Recette r = new Recette() { Id = reader.GetInt32(0), NomRecette = reader.GetString(3), NbPersonne = reader.GetInt32(4), Difficulte = reader.GetString(5) };
                liste.Add(r);
            }
            reader.Close();
            command.Dispose();
            Connection.Instance.Close();
            return liste;
        }

    }
}
