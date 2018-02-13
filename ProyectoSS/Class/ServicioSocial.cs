using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoSS.Class
{
    class ServicioSocial
    {
        DBConn db = new DBConn();
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand sql = new MySqlCommand();

        public Boolean altaAsignacionEntidad(String[] altaAsignacion)
        {
            Boolean x = false;
            String query = "call altaAsignacionEntidad("+altaAsignacion[0]+","+altaAsignacion[1]+","+altaAsignacion[2]+",'"+altaAsignacion[3]+"')";
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = query;
                sql.ExecuteNonQuery();
                x = true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
                x = false;
            }
            conn.Close();
            return x;
        }
    }
}
