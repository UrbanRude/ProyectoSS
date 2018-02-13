using ProyectoSS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSS.FormServicio
{
    public partial class AltaEncargado : Form
    {
        private int idEntidad;
        Encargados encargado = new Encargados();
        public AltaEncargado(int idEntidad)
        {
            InitializeComponent();
            this.idEntidad = idEntidad;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] infoEncargado = new String[7];
            infoEncargado[0] = txtNom.Text;
            infoEncargado[1] = txtApp.Text;
            infoEncargado[2] = txtApm.Text;
            infoEncargado[3] = txtCargo.Text;
            infoEncargado[4] = txtTel.Text;
            infoEncargado[5] = txtEmail.Text;
            infoEncargado[6] = Convert.ToString(idEntidad);
            if(encargado.AltaEncargado(infoEncargado)){
                MessageBox.Show("Guardado correctamente");
            }
        }
    }
}
