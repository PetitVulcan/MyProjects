using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicheRecette.Classe
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
                        _instance = new SqlConnection(@"Data Source=(LOCALDB)\listerecette;Integrated Security=True");
                    }
                    return _instance;
                }
            }
        }
    }
}
