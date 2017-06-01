using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//References
using DAO;
using EL;
using System.Data;

namespace BL
{
    public class GeneroBL
    {
        DAO.GeneroDAO dao = new DAO.GeneroDAO();
        public DataTable listar() {
            return dao.listar();
        }
    }
}
