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
    public partial class AltaEntidadReceptora : Form
    {
        public AltaEntidadReceptora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntidadesReceptoras entidad = new EntidadesReceptoras();
            String[] arreglo = new String[9];
            arreglo[0] = txtNombre.Text;
            arreglo[1] = txtCalle.Text;
            arreglo[2] = txtCalle1.Text;
            arreglo[3] = txtCalle2.Text;
            arreglo[4] = txtNoExt.Text;
            arreglo[5] = txtNoInt.Text;
            arreglo[6] = txtColonia.Text;
            arreglo[7] = txtReferencia.Text;
            arreglo[8] = cmbMunicipio.SelectedValue.ToString();
            if (entidad.AltaEntidad(arreglo))
            {
                MessageBox.Show("Entidad guardad correctamente");
                //this.Close();
            }
            else { MessageBox.Show("Error"); }
        }

        public void cargarMunicipio()
        {
            try
            {
                EntidadesReceptoras entidad = new EntidadesReceptoras();
                MySqlDataAdapter dt = new MySqlDataAdapter();
                dt = entidad.ConsultarMunicipios();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbMunicipio.ValueMember = "id";
                cmbMunicipio.DisplayMember = "Municipio";
                cmbMunicipio.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        public void cargarDelegaciones()
        {
            try
            {
                EntidadesReceptoras entidad = new EntidadesReceptoras();
                MySqlDataAdapter dt = new MySqlDataAdapter();
                dt = entidad.ConsultarDelegaciones();
                DataTable table = new DataTable();
                dt.Fill(table);
                cmbMunicipio.ValueMember = "id";
                cmbMunicipio.DisplayMember = "Municipio";
                cmbMunicipio.DataSource = table;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error >> " + e.ToString());
            }
        }

        private void AltaEntidadReceptora_Load(object sender, EventArgs e)
        {
            rbnEstado.Checked = true;
        }

      
        private void rbnDF_CheckedChanged(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = null;
            cargarDelegaciones();
        }

        private void rbnEstado_CheckedChanged(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = null;
            cargarMunicipio();
        }
    }
}
