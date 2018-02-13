using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoSS.Class;

namespace ProyectoSS
{
    public partial class login : Form
    {
        DBConn db = new DBConn();
        Usuario usuario = new Usuario();
        MDI mdi = new MDI();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuario.ConsultarUsuario(txtUser.Text, txtPasword.Text))
            {
                this.Hide();
                mdi.Show();
            }
            else { MessageBox.Show("Usuario y/o contraseña incorrecta"); }
        }
    }
}
