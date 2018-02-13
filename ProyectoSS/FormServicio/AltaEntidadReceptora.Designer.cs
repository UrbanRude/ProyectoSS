namespace ProyectoSS.FormServicio
{
    partial class AltaEntidadReceptora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnDF = new System.Windows.Forms.RadioButton();
            this.rbnEstado = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.Municipio = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoInt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoExt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalle2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalle1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnDF);
            this.groupBox1.Controls.Add(this.rbnEstado);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbMunicipio);
            this.groupBox1.Controls.Add(this.Municipio);
            this.groupBox1.Controls.Add(this.txtReferencia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtColonia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNoInt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNoExt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCalle2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCalle1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Entidad Receptora";
            // 
            // rbnDF
            // 
            this.rbnDF.AutoSize = true;
            this.rbnDF.Location = new System.Drawing.Point(167, 178);
            this.rbnDF.Name = "rbnDF";
            this.rbnDF.Size = new System.Drawing.Size(140, 21);
            this.rbnDF.TabIndex = 24;
            this.rbnDF.TabStop = true;
            this.rbnDF.Text = "Ciudad de Mexico";
            this.rbnDF.UseVisualStyleBackColor = true;
            this.rbnDF.CheckedChanged += new System.EventHandler(this.rbnDF_CheckedChanged);
            // 
            // rbnEstado
            // 
            this.rbnEstado.AutoSize = true;
            this.rbnEstado.Location = new System.Drawing.Point(9, 178);
            this.rbnEstado.Name = "rbnEstado";
            this.rbnEstado.Size = new System.Drawing.Size(140, 21);
            this.rbnEstado.TabIndex = 23;
            this.rbnEstado.TabStop = true;
            this.rbnEstado.Text = "Estado de Mexico";
            this.rbnEstado.UseVisualStyleBackColor = true;
            this.rbnEstado.CheckedChanged += new System.EventHandler(this.rbnEstado_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(435, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(397, 175);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(192, 24);
            this.cmbMunicipio.TabIndex = 17;
            // 
            // Municipio
            // 
            this.Municipio.AutoSize = true;
            this.Municipio.Location = new System.Drawing.Point(321, 180);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(60, 17);
            this.Municipio.TabIndex = 16;
            this.Municipio.Text = "Entidad:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(93, 138);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(498, 22);
            this.txtReferencia.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Referencia:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(324, 101);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(266, 22);
            this.txtColonia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Colonia:";
            // 
            // txtNoInt
            // 
            this.txtNoInt.Location = new System.Drawing.Point(196, 101);
            this.txtNoInt.Name = "txtNoInt";
            this.txtNoInt.Size = new System.Drawing.Size(60, 22);
            this.txtNoInt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. int:";
            // 
            // txtNoExt
            // 
            this.txtNoExt.Location = new System.Drawing.Point(68, 101);
            this.txtNoExt.Name = "txtNoExt";
            this.txtNoExt.Size = new System.Drawing.Size(60, 22);
            this.txtNoExt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. ext:";
            // 
            // txtCalle2
            // 
            this.txtCalle2.Location = new System.Drawing.Point(481, 69);
            this.txtCalle2.Name = "txtCalle2";
            this.txtCalle2.Size = new System.Drawing.Size(110, 22);
            this.txtCalle2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Entre Calle:";
            // 
            // txtCalle1
            // 
            this.txtCalle1.Location = new System.Drawing.Point(279, 69);
            this.txtCalle1.Name = "txtCalle1";
            this.txtCalle1.Size = new System.Drawing.Size(110, 22);
            this.txtCalle1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entre Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(55, 69);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(131, 22);
            this.txtCalle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calle:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(195, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(396, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la dependencia:\r\n";
            // 
            // AltaEntidadReceptora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaEntidadReceptora";
            this.Text = "AltaEntidadReceptora";
            this.Load += new System.EventHandler(this.AltaEntidadReceptora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalle1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoInt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoExt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalle2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbnDF;
        private System.Windows.Forms.RadioButton rbnEstado;
        private System.Windows.Forms.Label Municipio;
    }
}