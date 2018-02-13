using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSS.Class;
using MySql.Data.MySqlClient;

namespace ProyectoSS.FormServicio
{
    public partial class RegistroAuto : Form
    {
        public String matricula = "";
        private String[] info;
        private String idAsigRcep, idEntidadReceptora, idEncargado,tipo,dias,totalHoras;
        public RegistroAuto(String matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
        }

        private void RegistroAuto_Load(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtRegistroEstatal,"Error");
            cargarProgramas();
            cargarInfo(matricula);
            rdFederal.Checked = true;
            rd480.Checked = true;
            rdLaV.Checked = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadesReceptoras entidad = new EntidadesReceptoras();
            String[] registro = new String[12];
            //call altaRegistroAutorizacion(13090111,1,5,'Prueba 1',1,2,'Desarrollo',1,'9:00 a 1:00','2017/10/02','2017/10/02','480');
            registro[0] = matricula;
            registro[1] = idEntidadReceptora;
            registro[2] = tipo;
            registro[3] = txtUnidadResponsable.Text;
            registro[4] = cmbEncargado.SelectedValue.ToString();
            registro[5] = cmbPrograma.SelectedValue.ToString();
            registro[6] = txtActividades.Text;
            registro[7] = dias;
            registro[8] = Convert.ToString(maskedHora1.Text) + " a " + Convert.ToString(maskedHora2.Text);
            registro[9] = dtimeInicio.Value.ToString("yyyy/MM/dd");
            registro[10] = dtimeTermino.Value.ToString("yyyy/MM/dd");
            registro[11] = totalHoras;
            if(entidad.AltaRegistroAutorizacion(registro)){
                MessageBox.Show("Alta Exitosa");
            }else{
                MessageBox.Show("Error");
            }

            /*AgregarAlumnoRegistroAutorizacion agregar = new AgregarAlumnoRegistroAutorizacion();
            agregar.MdiParent = this.MdiParent;
            agregar.Show();*/
        }

        public void cargarProgramas()
        {
            try
            {
                MySqlDataAdapter dt = new MySqlDataAdapter();
                Encargados encargado = new Encargados();
                dt = encargado.ConsultarPrograma();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbPrograma.ValueMember = "idProyectoPSS";
                cmbPrograma.DisplayMember = "ProyectoPSS";
                cmbPrograma.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        public void cargarInfo(String matricula) {
            Alumnos alumno = new Alumnos();
            info = alumno.infoRegistroAutorizacion(matricula);
            txtNombreAlumno.Text = info[0];
            txtCorreoElectronico.Text = info[1];
            txtEdad.Text = info[2];
            txtSexo.Text = info[3];
            txtCarrera.Text = info[4];
            txtCreditos.Text = info[5];
            txtPromedio.Text = info[6];
            txtNombreEntidad.Text = info[7];
            txtDireccionUnidad.Text = "Col: " + info[11] + " Calle:" + info[8] + ", Nº Int:" + info[9] + " Nº Ext:" + info[10];
            txtMunicipio.Text = info[12];
            txtTelefono.Text = info[13];
            idEntidadReceptora = info[14];
            idEncargado = info[15];
            idAsigRcep = info[16];
            CargarEncargados(idEntidadReceptora);
        }

        public void CargarEncargados(String idEntidad) { 
            try
            {
                MySqlDataAdapter dt = new MySqlDataAdapter();
                Encargados encargado = new Encargados();
                dt = encargado.ConsultarEncargados(Convert.ToInt32(idEntidad));
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbEncargado.ValueMember = "idEncargado";
                cmbEncargado.DisplayMember = "nom";
                cmbEncargado.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        private void rdFederal_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "1";
        }

        private void rdEstatal_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "2";
        }

        private void rdMunicipal_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "3";
        }

        private void rdONG_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "4";
        }

        private void rdIE_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "5";
        }

        private void rdIP_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "6";
        }

        private void rdLaV_CheckedChanged(object sender, EventArgs e)
        {
            dias = "1";
        }

        private void rdFines_CheckedChanged(object sender, EventArgs e)
        {
            dias = "2";
        }

        private void rd480_CheckedChanged(object sender, EventArgs e)
        {
            totalHoras = "480";
        }

        private void rdOtras_CheckedChanged(object sender, EventArgs e)
        {
            totalHoras = txtOtras.Text;
        }


    }
}
