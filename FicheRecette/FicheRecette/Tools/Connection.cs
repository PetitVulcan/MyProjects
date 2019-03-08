using System.Data.SqlClient;

namespace FicheRecette.Tools
{
    public class Connection
    {
        private static SqlConnection _instance = null;
        private static object _lock = new object();

        private Connection()
        {

        }
        public static SqlConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SqlConnection(@"Data Source=DESKTOP-RI59KG6\SQLEXPRESS;Initial Catalog=ListeRecette;Integrated Security=True");
                    }
                    return _instance;
                }
            }
        }
    }
    
}
