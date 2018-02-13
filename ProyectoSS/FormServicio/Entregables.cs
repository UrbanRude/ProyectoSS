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
    public partial class Entregables : Form
    {
        DataTable modelo = new DataTable();
        public Entregables()
        {
            InitializeComponent();
        }

        private void Entregables_Load(object sender, EventArgs e)
        {
            cargarEntregables();
        }

        public void cargarEntregables()
        {
            try
            {
                MySqlDataAdapter dt = new MySqlDataAdapter();
                Entregable entregable = new Entregable();
                dt = entregable.ConsultarEntrgables();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmdEntrgables.ValueMember = "id";
                cmdEntrgables.DisplayMember = "Entregable";
                cmdEntrgables.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        public void cargarEntregablesAlumno(String matricula) {
            try {
                Entregable entregable = new Entregable();
                modelo = entregable.ConsultarParticularEntregables(matricula);
                dataGridView1.DataSource = modelo;
                dataGridView1.Columns["Fecha"].DefaultCellStyle.Format = "yyyy/MM/dd";        
            }
            catch (Exception e) { MessageBox.Show("Error >> " + e.ToString()); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarEntregablesAlumno(txtMatricula.Text);
            String[] info = new String[2];
            Alumnos alumno = new Alumnos();
            info = alumno.ConsultaAlumno(txtMatricula.Text);
            txtNombreAlumno.Text = info[0];
            txtCarrera.Text = info[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entregable entregable = new Entregable();
            String fecha = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            if(entregable.AltaEntregable(cmdEntrgables.SelectedValue.ToString(),txtMatricula.Text,fecha)){
                modelo.Rows.Add(cmdEntrgables.Text, fecha);
                dataGridView1.DataSource = modelo;
                MessageBox.Show("Fecha guardada");
            }
        }
    }
}
