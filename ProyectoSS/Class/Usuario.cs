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
    class Usuario
    {
        DBConn db = new DBConn();
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand sql = new MySqlCommand();
        MySqlDataReader DataReader;

        public Boolean ConsultarUsuario(String usuario,String pwd){
            Boolean x = false;
            try {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "select count(idUsuario) as id from Usuarios where idUsuario = '"+usuario+"' and pass = '"+pwd+"';";
                DataReader = sql.ExecuteReader();
                while(DataReader.Read()){
                    if(DataReader["id"].ToString().Equals("1")){
                        x = true;
                    }
                    else { x = false; }
                }
                conn.Close();
                db.CloseConexion();
            }catch(MySqlException e){
                MessageBox.Show("Error >> "+e.ToString());
                conn.Close();
                db.CloseConexion();
            }
            return x;            
        }
    }
}
