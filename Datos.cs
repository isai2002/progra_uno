using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal1
{
    public class Datos
    {
        ConexionSQL cn = new ConexionSQL();
        public int conSQL(string user, string pass)
        {
            return cn.consultalogin(user, pass);
        }
       
        


    }
}
