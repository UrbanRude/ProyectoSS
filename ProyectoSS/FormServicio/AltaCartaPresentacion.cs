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
using ProyectoSS.rpt;

namespace ProyectoSS.FormServicio
{
    public partial class AltaCartaPresentacion : Form
    {
        Alumnos alumno = new Alumnos();
        public AltaCartaPresentacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] info = new String[2];
            info = alumno.ConsultaAlumno(txtMatricula.Text);
            txtNombreAlumno.Text = info[0];
            txtCarrera.Text = info[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (alumno.ActuAlumnoCarta(txtNSS.Text, txtCreditos.Text, txtPromedio.Text, txtMatricula.Text))
            {
                MessageBox.Show("Actualizacion Correcta");
                //alumno.reporte(txtMatricula.Text);
                alumno.CartaPresentacionAlumno(txtMatricula.Text);
                LimpiarCampos();
                

            }
            else { MessageBox.Show("Actualizacion Incorrecta"); }
        }

        public void LimpiarCampos() {
            txtCarrera.Text = null;
            txtCreditos.Text = null;
            txtMatricula.Text = null;
            txtNombreAlumno.Text = null;
            txtNSS.Text = null;
            txtPromedio.Text = null;
        }

        
    }
}
