using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoSS.Class
{
    class Semestre
    {
        DBConn db = new DBConn();
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand sql = new MySqlCommand();
        public MySqlDataAdapter ConsultarSemestre()
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "SELECT idSemestre as id,Semestre FROM semestres;";
                dt = new MySqlDataAdapter(sql);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return dt;
        } 
    }
}
