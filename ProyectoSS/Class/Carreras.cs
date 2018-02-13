using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSS.Class;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoSS.Class
{
    class Carreras
    {
        DBConn db = new DBConn();
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand sql = new MySqlCommand();
        public MySqlDataAdapter ConsultarCarreras()
        {
            MySqlDataAdapter dt = null;
            try {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "select idCarrera as id, car from carreras;";
                dt = new MySqlDataAdapter(sql);
            }catch(MySqlException e){
                MessageBox.Show("Error >> "+e.ToString());
            }
            return dt;
        } 

    }
}
