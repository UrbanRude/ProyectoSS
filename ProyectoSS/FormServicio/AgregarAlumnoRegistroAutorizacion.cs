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

namespace ProyectoSS.FormServicio
{
    public partial class AgregarAlumnoRegistroAutorizacion : Form
    {
        public static String matricula="";
        public AgregarAlumnoRegistroAutorizacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text == String.Empty)
            {
                errorProvider1.SetError(txtMatricula, "Agrega la matricula");
            }
            else {
                errorProvider1.Clear();
                RegistroAuto registro = new RegistroAuto(txtMatricula.Text);
                registro.MdiParent = this.MdiParent;
                registro.Show();
                this.Close();
                //MessageBox.Show("Echo"); 
            }
        }
    }
}
