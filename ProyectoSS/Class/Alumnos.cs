using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ProyectoSS.rpt;
using ProyectoSS.DataSet;
using ProyectoSS.FormServicio;

namespace ProyectoSS.Class
{
    class Alumnos
    {
        DBConn db = new DBConn();
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand sql = new MySqlCommand();
        
        public Boolean AltaAlumno(String[] alumno)
        {
            Boolean x = false;
            String query = "call altaAlumno(" + alumno[0] + ",'" + alumno[1] + "','" + alumno[2] + "','" + alumno[3] + "','" +
                alumno[4] + "'," + alumno[5] + ",'" + alumno[6] + "'," + alumno[7] + "," + alumno[8] + "," + alumno[9] + ");";
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

        public MySqlDataAdapter ConsultarEstadoCivil()
        {
            MySqlDataAdapter dt = null;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "select idEstadoCivil as id,EstadoC as estado from EstadoCivil;";
                dt = new MySqlDataAdapter(sql);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            conn.Close();
            return dt;
        }

        //Metodo para la consulta en el from de AltaCartaPresentacion
        public String[] ConsultaAlumno(String matricula) {
          
            String[] info = new String[2];
            MySqlDataReader dataReader;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "call consultaAlumnoCarta(" + matricula + ");";
                dataReader = sql.ExecuteReader();
                    while (dataReader.Read())
                    {
                        info[0] = dataReader["nom"].ToString();
                        info[1] = dataReader["Carrera"].ToString();
                    }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            return info;
        }

        public Boolean ActuAlumnoCarta(String nss,String creditos,String promedio,String matricula)
        {
            Boolean x = false;
            String query = "call  actuAlumnoCarta('"+nss+"',"+creditos+","+promedio+","+matricula+")";
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

        public void reporte(String matricula)
        {
            CartaPresentacion cartaPresentacion = new CartaPresentacion();
            String query = "select idAlumno,concat(nombreAlum,' ',appAlum,' ',apmAlum,' ') as Nombre,NSS from "
            +"Alumnos where idAlumno = "+matricula+";";
            conn = db.Conexion();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet1 ds = new DataSet1();
            adapter.Fill(ds,"Alumnos");
            cartaPresentacion.SetDataSource(ds);
            FormCarta formCarta = new FormCarta();
            formCarta.crystalReportViewer1.ReportSource = cartaPresentacion;
            formCarta.Show();
        }

        public void CartaPresentacionAlumno(String matricula) {
            CartaPresent cartaPresent = new CartaPresent();
            String query = "call consultaCartaPresentacion("+matricula+");";
            conn = db.Conexion();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSetCartaPresentacion ds = new DataSetCartaPresentacion();
            adapter.Fill(ds,"CartaPresentacion");
            cartaPresent.SetDataSource(ds);
            FormCarta formCarta = new FormCarta();
            formCarta.crystalReportViewer1.ReportSource = cartaPresent;
            formCarta.Show();
            
        }

        public String[] infoRegistroAutorizacion(String matricula) {
            String[] info = new String[17];
            MySqlDataReader dataReader;
            try
            {
                conn = db.Conexion();
                sql.Connection = conn;
                sql.CommandText = "call consultaRegistroAutorizacion("+matricula+")";
                dataReader = sql.ExecuteReader();
                while (dataReader.Read())
                {
                    info[0] = dataReader["nombreAlumno"].ToString();
                    info[1] = dataReader["correo"].ToString();
                    info[2] = dataReader["edad"].ToString();
                    int sexo = Convert.ToInt16(dataReader["sexo"].ToString());
                    switch(sexo){
                        case 1:
                            info[3] = "Hombre";
                            break;
                        case 2:
                            info[3] = "Mujer";
                            break;
                    }
                    info[4] = dataReader["Carrera"].ToString();
                    info[5] = dataReader["creditos"].ToString();
                    info[6] = dataReader["promedio"].ToString();
                    info[7] = dataReader["nombreEnt"].ToString();
                    info[8] = dataReader["calle"].ToString();
                    info[9] = dataReader["noExt"].ToString();
                    info[10] = dataReader["noInt"].ToString();
                    info[11] = dataReader["coloniaEnt"].ToString();
                    info[12] = dataReader["municipio"].ToString();
                    info[13] = dataReader["telefonoEnt"].ToString();
                    info[14] = dataReader["idEntidaReceptora"].ToString();
                    info[15] = dataReader["idEncargado"].ToString();
                    info[16] = dataReader["idAsigRcep"].ToString();


                    info[4] = dataReader["Carrera"].ToString();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
            conn.Close();
            return info;
        }
    }
}
