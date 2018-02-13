using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoSS.Class;

namespace ProyectoSS.FormServicio
{
    public partial class ArchivoExcel : Form
    {
        DataTable modeloTabla = new DataTable();
        DBConn db = new DBConn();
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand sql = new MySqlCommand();

        public ArchivoExcel()
        {
            InitializeComponent();
        }

        private void ArchivoExcel_Load(object sender, EventArgs e)
        {

        }

        public void ConsultarEstadoCivil()
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
           
        } 
    }
}
