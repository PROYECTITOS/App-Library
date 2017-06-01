using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//References
using EL;
using MySql.Data.MySqlClient;
using System.Data;
namespace DAO
{
    public class GeneroDAO
    {
        static string PC_PREFIX = "GENERO_";
        private string PC_LISTAR = PC_PREFIX + "LISTAR";
        private string PC_REGISTRAR = PC_PREFIX + "REGISTRAR";
        private string PC_ACTUALIZAR = PC_PREFIX + "ACTUALIZAR";
        private string PC_ELIMINAR = PC_PREFIX + "ELIMINAR";

        ConexionDAO cn = new ConexionDAO();

        public DataTable listar() {
            DataTable tb = new DataTable();
            using (MySqlDataAdapter da = new MySqlDataAdapter(PC_LISTAR, cn.getCN()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tb);
            }
            return tb;
        }

        
    }
}
