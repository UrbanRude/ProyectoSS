using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ProyectoSS.Class
{
    class DBConn
    {
        public static MySqlConnection conn;
        public String msg = "";
        private String cadena = "server=localhost; database=DBServicioSocial; Uid=root; pwd=R00tCer*";
       
        public MySqlConnection Conexion() {
            try {
                conn = new MySqlConnection(cadena);
                conn.Open();
                msg = "Conexion Exitosa";
            }catch(MySqlException e){
                msg = "Error >> " + e.ToString();
            }
            return conn;
        }

        public void CloseConexion() {
            try {
                conn.Close();
            }catch(MySqlException e){
                msg = "Error >> " + e.ToString();
            }
        }
    }
}
