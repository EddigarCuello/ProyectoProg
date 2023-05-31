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
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSalir
            // 
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(991, 24);
            this.pbSalir.Margin = new System.Windows.Forms.Padding(4);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(43, 38);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 22;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "Datos Del Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
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
            this.panel1.Location = new System.Drawing.Point(250, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 502);
            this.panel1.TabIndex = 28;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(288, 358);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(55, 20);
            this.lb_Total.TabIndex = 37;
            this.lb_Total.Text = "Total";
            // 
            // lbFechaFact
            // 
            this.lbFechaFact.AutoSize = true;
            this.lbFechaFact.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFact.Location = new System.Drawing.Point(261, 277);
            this.lbFechaFact.Name = "lbFechaFact";
            this.lbFechaFact.Size = new System.Drawing.Size(160, 20);
            this.lbFechaFact.TabIndex = 36;
            this.lbFechaFact.Text = "Fecha De Factura";
            // 
            // lbPrc_Revision
            // 
            this.lbPrc_Revision.AutoSize = true;
            this.lbPrc_Revision.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrc_Revision.Location = new System.Drawing.Point(261, 225);
            this.lbPrc_Revision.Name = "lbPrc_Revision";
            this.lbPrc_Revision.Size = new System.Drawing.Size(142, 20);
            this.lbPrc_Revision.TabIndex = 35;
            this.lbPrc_Revision.Text = "Precio Revision";
            // 
            // lbPrc_Servicios
            // 
            this.lbPrc_Servicios.AutoSize = true;
            this.lbPrc_Servicios.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrc_Servicios.Location = new System.Drawing.Point(261, 175);
            this.lbPrc_Servicios.Name = "lbPrc_Servicios";
            this.lbPrc_Servicios.Size = new System.Drawing.Size(139, 20);
            this.lbPrc_Servicios.TabIndex = 34;
            this.lbPrc_Servicios.Text = "Precio Servicio";
            // 
            // lbCoidgoFact
            // 
            this.lbCoidgoFact.AutoSize = true;
            this.lbCoidgoFact.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoidgoFact.Location = new System.Drawing.Point(261, 127);
            this.lbCoidgoFact.Name = "lbCoidgoFact";
            this.lbCoidgoFact.Size = new System.Drawing.Size(68, 20);
            this.lbCoidgoFact.TabIndex = 33;
            this.lbCoidgoFact.Text = "Codigo";
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.Location = new System.Drawing.Point(93, 277);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(160, 20);
            this.textbox.TabIndex = 32;
            this.textbox.Text = "Fecha De Factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Precio Revision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Precio Servicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(93, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Codigo";
            // 
            // FrmLoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 643);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "FrmLoginCliente";
            this.Text = "FrmLoginCliente";
            this.Load += new System.EventHandler(this.FrmLoginCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}