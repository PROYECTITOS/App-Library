using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//REFERENCIAS
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class ConexionDAO
    {
        //private MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MYSQL"].ConnectionString);
        private MySqlConnection cn = new MySqlConnection("server=192.252.146.11;database=prevention_model; uid=prevention;pwd=PreventionSystemIsoSystem"); 
        public MySqlConnection getCN()
        {
            return cn;
        }
    }
}
