using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoSS.Class
{
    class EntidadesReceptoras
    {
        DBConn db = new DBConn();
        MySqlCommand sql = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();
        public Boolean AltaEntidad(String[] entidad) {
            Boolean x = false;
            String query = "insert into entidadesreceptoras (nombreEnt,calle,entreCalle1,entreCalle2,noExt,noInt,coloniaEnt,referencia,telefonoEnt,idMunicipio) values ('" + entidad[0] + "','" + entidad[1] + "','" +
                entidad[2] + "','" + entidad[3] + "'," + entidad[4] + "," + entidad[5] + ",'" + entidad[6] + "','" + entidad[7] + "',null," + entidad[8] + ")";
            try {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = query;
                sql.ExecuteNonQuery();
                x = true;
            }
            catch (MySqlException e) {
                MessageBox.Show("Error >> " + e.ToString());
                x = false;
            }
            return x;
        }

        public MySqlDataAdapter ConsultarMunicipios()
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "select idMunicipio as id, Municipio from Municipios where idMunicipio < 126;";
                dt = new MySqlDataAdapter(sql);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return dt;
        }

        public MySqlDataAdapter ConsultarDelegaciones()
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "select idMunicipio as id, Municipio from Municipios where idMunicipio > 125;";
                dt = new MySqlDataAdapter(sql);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return dt;
        }

        public MySqlDataAdapter ConsultarEntidades()
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "SELECT idEntidadReceptora as id, nombreEnt as nom FROM entidadesreceptoras;";
                dt = new MySqlDataAdapter(sql);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return dt;
        }

        public String[] infoEntidad(String cod) {
            String[] arreglo = new String[8];
            MySqlDataReader dataReader;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "call consultaEntidad("+cod+");";
                dataReader = sql.ExecuteReader();
                while(dataReader.Read()){
                    arreglo[0] = dataReader["campo1"].ToString();
                    arreglo[1] = dataReader["campo2"].ToString();
                    arreglo[2] = dataReader["campo3"].ToString();
                    arreglo[3] = dataReader["campo4"].ToString();
                    arreglo[4] = dataReader["campo5"].ToString();
                    arreglo[5] = dataReader["campo6"].ToString();
                    arreglo[6] = dataReader["campo7"].ToString();
                    arreglo[7] = dataReader["campo8"].ToString();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return arreglo;
        }

        public Boolean AltaRegistroAutorizacion(String[] registro)
        {
            Boolean x = false;
            //call                   altaRegistroAutorizacion(13090111,     1,                  5,          'Prueba 1',         1,              2,              'Desarrollo',       1,          '9:00 a 1:00','2017/10/02','2017/10/02','480');
            String query = "call altaRegistroAutorizacion("+registro[0]+","+registro[1]+","+registro[2]+",'"+registro[3]+"',"+registro[4]+","+registro[5]+",'"+registro[6]+"',"+registro[7]+",'"+registro[8]+"','"+registro[9]+"','"+registro[10]+"','"+registro[11]+"');";
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
