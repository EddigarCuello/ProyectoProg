﻿namespace Presentacion
{
    partial class FrmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_CALLES = new System.Windows.Forms.ComboBox();
            this.CB_BARRIOS = new System.Windows.Forms.ComboBox();
            this.CB_CIUDADES = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrNombre = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpVersion = new System.Windows.Forms.DateTimePicker();
            this.tbTipoVeh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCilindraje = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.CB_CALLES);
            this.panel1.Controls.Add(this.CB_BARRIOS);
            this.panel1.Controls.Add(this.CB_CIUDADES);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPrApellido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbPrNombre);
            this.panel1.Controls.Add(this.tbCedula);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(54, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 341);
            this.panel1.TabIndex = 13;
            // 
            // CB_CALLES
            // 
            this.CB_CALLES.FormattingEnabled = true;
            this.CB_CALLES.Location = new System.Drawing.Point(478, 207);
            this.CB_CALLES.Name = "CB_CALLES";
            this.CB_CALLES.Size = new System.Drawing.Size(121, 24);
            this.CB_CALLES.TabIndex = 25;
            this.CB_CALLES.SelectedIndexChanged += new System.EventHandler(this.CB_CALLES_SelectedIndexChanged);
            // 
            // CB_BARRIOS
            // 
            this.CB_BARRIOS.FormattingEnabled = true;
            this.CB_BARRIOS.Location = new System.Drawing.Point(478, 150);
            this.CB_BARRIOS.Name = "CB_BARRIOS";
            this.CB_BARRIOS.Size = new System.Drawing.Size(121, 24);
            this.CB_BARRIOS.TabIndex = 24;
            this.CB_BARRIOS.SelectedIndexChanged += new System.EventHandler(this.CB_BARRIOS_SelectedIndexChanged);
            // 
            // CB_CIUDADES
            // 
            this.CB_CIUDADES.FormattingEnabled = true;
            this.CB_CIUDADES.Location = new System.Drawing.Point(478, 92);
            this.CB_CIUDADES.Name = "CB_CIUDADES";
            this.CB_CIUDADES.Size = new System.Drawing.Size(121, 24);
            this.CB_CIUDADES.TabIndex = 23;
            this.CB_CIUDADES.SelectedIndexChanged += new System.EventHandler(this.CB_CIUDADES_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Barrio";
            // 
            // tbPrApellido
            // 
            this.tbPrApellido.Location = new System.Drawing.Point(207, 128);
            this.tbPrApellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrApellido.Name = "tbPrApellido";
            this.tbPrApellido.Size = new System.Drawing.Size(160, 22);
            this.tbPrApellido.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Primer Nombre";
            // 
            // tbPrNombre
            // 
            this.tbPrNombre.Location = new System.Drawing.Point(207, 59);
            this.tbPrNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrNombre.Name = "tbPrNombre";
            this.tbPrNombre.Size = new System.Drawing.Size(160, 22);
            this.tbPrNombre.TabIndex = 10;
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(207, 197);
            this.tbCedula.Margin = new System.Windows.Forms.Padding(4);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(160, 22);
            this.tbCedula.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(207, 252);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(160, 22);
            this.tbTelefono.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cedula";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.dtpVersion);
            this.panel2.Controls.Add(this.tbTipoVeh);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbCilindraje);
            this.panel2.Controls.Add(this.tbMarca);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbPlaca);
            this.panel2.Controls.Add(this.tbModelo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(731, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 341);
            this.panel2.TabIndex = 26;
            // 
            // dtpVersion
            // 
            this.dtpVersion.Location = new System.Drawing.Point(189, 253);
            this.dtpVersion.Name = "dtpVersion";
            this.dtpVersion.Size = new System.Drawing.Size(200, 22);
            this.dtpVersion.TabIndex = 29;
            // 
            // tbTipoVeh
            // 
            this.tbTipoVeh.Location = new System.Drawing.Point(562, 224);
            this.tbTipoVeh.Margin = new System.Windows.Forms.Padding(4);
            this.tbTipoVeh.Name = "tbTipoVeh";
            this.tbTipoVeh.Size = new System.Drawing.Size(160, 22);
            this.tbTipoVeh.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tipo De Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cilindraje";
            // 
            // tbCilindraje
            // 
            this.tbCilindraje.Location = new System.Drawing.Point(533, 141);
            this.tbCilindraje.Margin = new System.Windows.Forms.Padding(4);
            this.tbCilindraje.Name = "tbCilindraje";
            this.tbCilindraje.Size = new System.Drawing.Size(160, 22);
            this.tbCilindraje.TabIndex = 26;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(207, 128);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(160, 22);
            this.tbMarca.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Marca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Placa";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(207, 59);
            this.tbPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(160, 22);
            this.tbPlaca.TabIndex = 10;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(207, 197);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(160, 22);
            this.tbModelo.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 250);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Version";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Modelo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.tbUser);
            this.panel3.Controls.Add(this.TbPass);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(487, 458);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 202);
            this.panel3.TabIndex = 29;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(243, 64);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(160, 22);
            this.tbUser.TabIndex = 9;
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(243, 119);
            this.TbPass.Margin = new System.Windows.Forms.Padding(4);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(160, 22);
            this.TbPass.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(79, 117);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "Contraseña";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(79, 64);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Usuario";
            // 
            // pbSalir
            // 
            this.pbSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbSalir.Image")));
            this.pbSalir.Location = new System.Drawing.Point(1471, 13);
            this.pbSalir.Margin = new System.Windows.Forms.Padding(4);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(43, 38);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 30;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 600);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(232, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Datos Del Cliente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(992, 13);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 25);
            this.label15.TabIndex = 32;
            this.label15.Text = "Datos Del Vehiculo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(662, 422);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "Cuenta";
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarC.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarC.Location = new System.Drawing.Point(638, 685);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(203, 50);
            this.btnAgregarC.TabIndex = 34;
            this.btnAgregarC.Text = "AGREGAR";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // FrmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 748);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarCliente";
            this.Text = "FrmAgregarEmpleado";
            this.Load += new System.EventHandler(this.FrmAgregarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrNombre;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_CALLES;
        private System.Windows.Forms.ComboBox CB_BARRIOS;
        private System.Windows.Forms.ComboBox CB_CIUDADES;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTipoVeh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCilindraje;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpVersion;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAgregarC;
    }
}