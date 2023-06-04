namespace Presentacion
{
    partial class FrmLoginCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginCliente));
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Total = new System.Windows.Forms.Label();
            this.lbFechaFact = new System.Windows.Forms.Label();
            this.lbPrc_Revision = new System.Windows.Forms.Label();
            this.lbPrc_Servicios = new System.Windows.Forms.Label();
            this.lbCoidgoFact = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbNombres = new System.Windows.Forms.Label();
            this.btngenerarPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSalir
            // 
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(743, 20);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(32, 31);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 22;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Datos Del Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btngenerarPdf);
            this.panel1.Controls.Add(this.lb_Total);
            this.panel1.Controls.Add(this.lbFechaFact);
            this.panel1.Controls.Add(this.lbPrc_Revision);
            this.panel1.Controls.Add(this.lbPrc_Servicios);
            this.panel1.Controls.Add(this.lbCoidgoFact);
            this.panel1.Controls.Add(this.textbox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(308, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 408);
            this.panel1.TabIndex = 28;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(216, 291);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(44, 16);
            this.lb_Total.TabIndex = 37;
            this.lb_Total.Text = "Total";
            // 
            // lbFechaFact
            // 
            this.lbFechaFact.AutoSize = true;
            this.lbFechaFact.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFact.Location = new System.Drawing.Point(196, 225);
            this.lbFechaFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaFact.Name = "lbFechaFact";
            this.lbFechaFact.Size = new System.Drawing.Size(128, 16);
            this.lbFechaFact.TabIndex = 36;
            this.lbFechaFact.Text = "Fecha De Factura";
            // 
            // lbPrc_Revision
            // 
            this.lbPrc_Revision.AutoSize = true;
            this.lbPrc_Revision.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrc_Revision.Location = new System.Drawing.Point(196, 183);
            this.lbPrc_Revision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrc_Revision.Name = "lbPrc_Revision";
            this.lbPrc_Revision.Size = new System.Drawing.Size(116, 16);
            this.lbPrc_Revision.TabIndex = 35;
            this.lbPrc_Revision.Text = "Precio Revision";
            // 
            // lbPrc_Servicios
            // 
            this.lbPrc_Servicios.AutoSize = true;
            this.lbPrc_Servicios.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrc_Servicios.Location = new System.Drawing.Point(196, 142);
            this.lbPrc_Servicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrc_Servicios.Name = "lbPrc_Servicios";
            this.lbPrc_Servicios.Size = new System.Drawing.Size(112, 16);
            this.lbPrc_Servicios.TabIndex = 34;
            this.lbPrc_Servicios.Text = "Precio Servicio";
            // 
            // lbCoidgoFact
            // 
            this.lbCoidgoFact.AutoSize = true;
            this.lbCoidgoFact.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoidgoFact.Location = new System.Drawing.Point(196, 103);
            this.lbCoidgoFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCoidgoFact.Name = "lbCoidgoFact";
            this.lbCoidgoFact.Size = new System.Drawing.Size(55, 16);
            this.lbCoidgoFact.TabIndex = 33;
            this.lbCoidgoFact.Text = "Codigo";
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.Location = new System.Drawing.Point(70, 225);
            this.textbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(128, 16);
            this.textbox.TabIndex = 32;
            this.textbox.Text = "Fecha De Factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(111, 291);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Precio Revision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Precio Servicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(70, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Codigo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.lbPass);
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(346, 432);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 162);
            this.panel2.TabIndex = 38;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(146, 119);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(77, 16);
            this.lbPass.TabIndex = 34;
            this.lbPass.Text = "Password";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(146, 80);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(39, 16);
            this.lbUser.TabIndex = 33;
            this.lbUser.Text = "User";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 119);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Contraseña";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 80);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Usuario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(229, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Datos De La Cuenta";
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.BackColor = System.Drawing.Color.Transparent;
            this.lbNombres.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(12, 158);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(164, 21);
            this.lbNombres.TabIndex = 40;
            this.lbNombres.Text = "cliente nombres";
            // 
            // btngenerarPdf
            // 
            this.btngenerarPdf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btngenerarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerarPdf.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarPdf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngenerarPdf.Location = new System.Drawing.Point(66, 345);
            this.btngenerarPdf.Name = "btngenerarPdf";
            this.btngenerarPdf.Size = new System.Drawing.Size(215, 41);
            this.btngenerarPdf.TabIndex = 38;
            this.btngenerarPdf.Text = "Generar un Pdf";
            this.btngenerarPdf.UseVisualStyleBackColor = false;
            this.btngenerarPdf.Click += new System.EventHandler(this.btngenerarPdf_Click);
            // 
            // FrmLoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 604);
            this.ControlBox = false;
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLoginCliente";
            this.Text = "FrmLoginCliente";
            this.Load += new System.EventHandler(this.FrmLoginCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lbFechaFact;
        private System.Windows.Forms.Label lbPrc_Revision;
        private System.Windows.Forms.Label lbPrc_Servicios;
        private System.Windows.Forms.Label lbCoidgoFact;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Button btngenerarPdf;
    }
}