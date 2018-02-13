using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectoSS.Class
{
    class Entregable
    {
        DBConn db = new DBConn();
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand sql = new MySqlCommand();
        
        

        public MySqlDataAdapter ConsultarEntrgables()
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "select idEntregable as id,Entregable from Entregables;";
                dt = new MySqlDataAdapter(sql);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            conn.Close();
            return dt;
        }

        public DataTable ConsultarParticularEntregables(String matricula)
        {
            DataTable modelo = new DataTable();
            MySqlDataReader dataReader;
            modelo.Columns.Add("Documento");
            modelo.Columns.Add("Fecha");
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "call consultaEntregables(" + matricula + ")";
                dataReader = sql.ExecuteReader();
                while(dataReader.Read()){
                    modelo.Rows.Add(dataReader["entregable"].ToString(), Convert.ToDateTime(dataReader["FechaEntrega"].ToString()).ToString("yyyy/MM/dd"));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            conn.Close();
            return modelo;
        }

        public Boolean AltaEntregable(String idEntregable,String matricula,String fecha)
        {
            Boolean x = false;
            String query = "insert into asignacionentregables(idEntregable,idAlumno,FechaEntrega) values (" + idEntregable + "," + matricula + ",'" + fecha + "');";
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
