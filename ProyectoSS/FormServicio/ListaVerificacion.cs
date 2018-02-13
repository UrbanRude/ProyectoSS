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
    public partial class ListaVerificacion : Form
    {
        Carreras carreras = new Carreras();
        Semestre semestre = new Semestre();
        Alumnos alumno = new Alumnos();
        ServicioSocial ss = new ServicioSocial();
        public ListaVerificacion()
        {
            InitializeComponent();
        }

        public void cargarCarreras() {
            try { 
                MySqlDataAdapter dt = new MySqlDataAdapter();
                dt = carreras.ConsultarCarreras();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbCarreras.ValueMember = "id";
                cmbCarreras.DisplayMember = "car";
                cmbCarreras.DataSource = table;
            }
            catch (MySqlException e) {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        public void cargarSemestre()
        {
            try
            {
                MySqlDataAdapter dt = new MySqlDataAdapter();
                dt = semestre.ConsultarSemestre();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbSemestre.ValueMember = "id";
                cmbSemestre.DisplayMember = "Semestre";
                cmbSemestre.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        public void cargarEntidades()
        {
            try
            {
                MySqlDataAdapter dt = new MySqlDataAdapter();
                EntidadesReceptoras entidad = new EntidadesReceptoras();
                dt = entidad.ConsultarEntidades();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbEntidad.ValueMember = "id";
                cmbEntidad.DisplayMember = "nom";
                cmbEntidad.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        private void ListaVerificacion_Load(object sender, EventArgs e)
        {
            cargarSemestre();
            cargarEstadoCivil();
            cargarCarreras();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AltaEntidadReceptora altaEntidad = new AltaEntidadReceptora();
            MDI mdi = new MDI();
            altaEntidad.MdiParent = this.MdiParent;
            altaEntidad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarEntidades();
        }

        private void txtCalle2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntidadesReceptoras entidad = new EntidadesReceptoras();
            String[] arreglo = new String[8];
                arreglo = entidad.infoEntidad(cmbEntidad.SelectedValue.ToString());
                txtCalle.Text = arreglo[0];
                txtCalle1.Text = arreglo[1];
                txtCalle2.Text = arreglo[2];
                txtNoExt.Text = arreglo[3];
                txtNoInt.Text = arreglo[4];
                txtColonia.Text = arreglo[5];
                txtReferencia.Text = arreglo[6];
                txtMunicipio.Text = arreglo[7];
                cargarEncargados(Convert.ToInt32(cmbEntidad.SelectedValue.ToString()));
        }

        public void cargarEncargados(int idEncargado)
        {
            try
            {
                MySqlDataAdapter dt = new MySqlDataAdapter();
                Encargados encargado = new Encargados();
                dt = encargado.ConsultarEncargados(idEncargado);
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbNombre.ValueMember = "idEncargado";
                cmbNombre.DisplayMember = "nom";
                cmbNombre.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        public void cargarEstadoCivil()
        {
            try
            {
                MySqlDataAdapter dt = new MySqlDataAdapter();
                Encargados encargado = new Encargados();
                dt = alumno.ConsultarEstadoCivil();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbEstadoCivil.ValueMember = "id";
                cmbEstadoCivil.DisplayMember = "estado";
                cmbEstadoCivil.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AltaEncargado altaEncargado = new AltaEncargado(Convert.ToInt32(cmbEntidad.SelectedValue.ToString()));
            altaEncargado.MdiParent = this.MdiParent;
            altaEncargado.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarEncargados(Convert.ToInt32(cmbEntidad.SelectedValue.ToString()));
            
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] infoEncargado = new String[5];
            Encargados encargados = new Encargados();
            infoEncargado = encargados.ConsultarInfoEncargados(Convert.ToInt32(cmbNombre.SelectedValue.ToString()));
            txtCargo.Text = infoEncargado[2];
            txtTelefonoEncargado.Text = infoEncargado[3];
            txtEmail.Text = infoEncargado[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] alum = new String[10];
            alum[0] = txtMatricula.Text;
            alum[1] = txtNomAlumno.Text;
            alum[2] = txtAppAlum.Text;
            alum[3] = txtApmAlum.Text;
            alum[4] = txtTelAlum.Text;
            alum[5] = txtEdad.Text;
            alum[6] = txtEmailAlum.Text;
            alum[7] = cmbEstadoCivil.SelectedValue.ToString();
            alum[8] = cmbCarreras.SelectedValue.ToString();
            alum[9] = cmbSemestre.SelectedValue.ToString();

            if(alumno.AltaAlumno(alum)){
                MessageBox.Show("Alumno guardado correctamente");
                cargarEntidades();
                gbEncargado.Enabled = true;
                gbInfoDependencia.Enabled = true;
                dateTime.Enabled = true;
                btnConfirmar.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTime.Value.ToString("dd/MM/yyyy"));
            String matricula = txtMatricula.Text;
            String entidad = cmbEntidad.SelectedValue.ToString();
            String encargado = cmbNombre.SelectedValue.ToString();
            String fecha = dateTime.Value.ToString("yyyy/MM/dd");
            String[] altaAsignacion = new String[4];
            altaAsignacion[0] = matricula; altaAsignacion[1] = entidad; altaAsignacion[2] = encargado; altaAsignacion[3] = fecha;
            if(ss.altaAsignacionEntidad(altaAsignacion)){MessageBox.Show("Conceptos guardados correctamente");}
        }

        private void cmbEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


    }
}
