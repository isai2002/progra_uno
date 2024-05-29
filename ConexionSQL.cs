using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal1
{
    public class ConexionSQL
    { //se realiza la conexion con la base de datos
        static string   conexionstring = "server=DESKTOP-KP5I9CP\\SQLEXPRESS; database= ProyectoProgramacion; integrated security=true";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string user, string Contra)
        {
            int cont;
            con.Open();
            string Query = "select Count(*) From usuario where Carnet='" + user + "'" +
                "  and Contra = '" + Contra + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cont = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return cont;

        }
        
    }
}
