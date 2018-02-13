using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoSS.FormServicio;

namespace ProyectoSS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void paso1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaVerificacion listaVerificacion = new ListaVerificacion();
            listaVerificacion.MdiParent = this;
            listaVerificacion.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
        }

        private void generarCartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCartaPresentacion carta = new AltaCartaPresentacion();
            carta.MdiParent = this;
            carta.Show();
        }

        private void entrgablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entregables entregable = new Entregables();
            entregable.MdiParent = this;
            entregable.Show();
        }

        private void registroAutorizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarAlumnoRegistroAutorizacion agregar = new AgregarAlumnoRegistroAutorizacion();
            agregar.MdiParent = this;
            agregar.Show();
            //RegistroAuto registroAutorizacion = new RegistroAuto();
            //registroAutorizacion.MdiParent = this;
            //registroAutorizacion.Show();
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
