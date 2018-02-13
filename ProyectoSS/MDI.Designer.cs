namespace ProyectoSS
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paso1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrgablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAutorizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.servicioSocialToolStripMenuItem,
            this.practicasToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paso1ToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // paso1ToolStripMenuItem
            // 
            this.paso1ToolStripMenuItem.Name = "paso1ToolStripMenuItem";
            this.paso1ToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.paso1ToolStripMenuItem.Text = "Paso 1";
            this.paso1ToolStripMenuItem.Click += new System.EventHandler(this.paso1ToolStripMenuItem_Click);
            // 
            // servicioSocialToolStripMenuItem
            // 
            this.servicioSocialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarCartaToolStripMenuItem,
            this.entrgablesToolStripMenuItem,
            this.registroAutorizacionToolStripMenuItem});
            this.servicioSocialToolStripMenuItem.Name = "servicioSocialToolStripMenuItem";
            this.servicioSocialToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.servicioSocialToolStripMenuItem.Text = "Servicio Social";
            // 
            // generarCartaToolStripMenuItem
            // 
            this.generarCartaToolStripMenuItem.Name = "generarCartaToolStripMenuItem";
            this.generarCartaToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.generarCartaToolStripMenuItem.Text = "Generar Carta";
            this.generarCartaToolStripMenuItem.Click += new System.EventHandler(this.generarCartaToolStripMenuItem_Click);
            // 
            // entrgablesToolStripMenuItem
            // 
            this.entrgablesToolStripMenuItem.Name = "entrgablesToolStripMenuItem";
            this.entrgablesToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.entrgablesToolStripMenuItem.Text = "Entrgables";
            this.entrgablesToolStripMenuItem.Click += new System.EventHandler(this.entrgablesToolStripMenuItem_Click);
            // 
            // registroAutorizacionToolStripMenuItem
            // 
            this.registroAutorizacionToolStripMenuItem.Name = "registroAutorizacionToolStripMenuItem";
            this.registroAutorizacionToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.registroAutorizacionToolStripMenuItem.Text = "Registro/Autorizacion";
            this.registroAutorizacionToolStripMenuItem.Click += new System.EventHandler(this.registroAutorizacionToolStripMenuItem_Click);
            // 
            // practicasToolStripMenuItem
            // 
            this.practicasToolStripMenuItem.Name = "practicasToolStripMenuItem";
            this.practicasToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.practicasToolStripMenuItem.Text = "Practicas";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 62);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento de Servicio Social y Practicas Profesionales";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::ProyectoSS.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1035, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio Social y Practicas Profesionales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDI_FormClosed);
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paso1ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem generarCartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrgablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAutorizacionToolStripMenuItem;
    }
}