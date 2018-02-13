using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoSS.Class
{
    class Encargados
    {
        DBConn db = new DBConn();
        MySqlCommand sql = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();

        public MySqlDataAdapter ConsultarEncargados(int idEncargado)
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "select idEncargado,concat(nombreEncargado,' ',appEncargado,' ',apmEncargado) as nom from encargadoservicio where idEntidadReceptora = " + idEncargado + ";";
                dt = new MySqlDataAdapter(sql);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return dt;
        }
        public Boolean AltaEncargado(String[] encargado)
        {
            Boolean x = false;
            String query = "call altaEncargado('" + encargado[0] + "','" + encargado[1] + "','" + encargado[2] + "','" + encargado[3] +
                        "','" + encargado[4] + "','" + encargado[5] + "'," + encargado[6] + ");";
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
            return x;
        }

        public String[] ConsultarInfoEncargados(int idEncargado)
        {
            String[] infoEncargado = new String[5];
            MySqlDataReader dataReader;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "call ConsultaInfoEncargado("+idEncargado+");";
                dataReader = sql.ExecuteReader();
                while(dataReader.Read()){
                    infoEncargado[0] = dataReader["idEncargado"].ToString();
                    infoEncargado[1] = dataReader["nom"].ToString();
                    infoEncargado[2] = dataReader["cargo"].ToString();
                    infoEncargado[3] = dataReader["tel"].ToString();
                    infoEncargado[4] = dataReader["correo"].ToString();
                
                }
               
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return infoEncargado;
        }

        public MySqlDataAdapter ConsultarPrograma()
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "SELECT * FROM proyectopss;";
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
