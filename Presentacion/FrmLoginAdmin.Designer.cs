﻿namespace Presentacion
{
    partial class FrmLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.pnCLientes = new System.Windows.Forms.Panel();
            this.CB_CALLES = new System.Windows.Forms.ComboBox();
            this.CB_BARRIOS = new System.Windows.Forms.ComboBox();
            this.CB_CIUDADES = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbPr_apellido = new System.Windows.Forms.TextBox();
            this.tbPr_nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.pnCLientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbNombres);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 571);
            this.panel1.TabIndex = 1;
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(0, 187);
            this.lbNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(182, 29);
            this.lbNombres.TabIndex = 43;
            this.lbNombres.Text = "Admin nombres";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(141, 409);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(94, 20);
            this.lbPass.TabIndex = 42;
            this.lbPass.Text = "Password";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(141, 361);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(49, 20);
            this.lbUser.TabIndex = 41;
            this.lbUser.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(36, 512);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(193, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(36, 257);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(193, 54);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "RELOAD";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgEmpleados.Location = new System.Drawing.Point(267, 247);
            this.dgEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.ReadOnly = true;
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmpleados.Size = new System.Drawing.Size(741, 324);
            this.dgEmpleados.TabIndex = 2;
            this.dgEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellClick);
            this.dgEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellDoubleClick);
            // 
            // pnCLientes
            // 
            this.pnCLientes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnCLientes.Controls.Add(this.CB_CALLES);
            this.pnCLientes.Controls.Add(this.CB_BARRIOS);
            this.pnCLientes.Controls.Add(this.CB_CIUDADES);
            this.pnCLientes.Controls.Add(this.label9);
            this.pnCLientes.Controls.Add(this.label3);
            this.pnCLientes.Controls.Add(this.label16);
            this.pnCLientes.Controls.Add(this.tbTelefono);
            this.pnCLientes.Controls.Add(this.tbPr_apellido);
            this.pnCLientes.Controls.Add(this.tbPr_nombre);
            this.pnCLientes.Controls.Add(this.button2);
            this.pnCLientes.Controls.Add(this.label15);
            this.pnCLientes.Controls.Add(this.label17);
            this.pnCLientes.Controls.Add(this.label18);
            this.pnCLientes.Location = new System.Drawing.Point(443, 12);
            this.pnCLientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCLientes.Name = "pnCLientes";
            this.pnCLientes.Size = new System.Drawing.Size(439, 218);
            this.pnCLientes.TabIndex = 20;
            // 
            // CB_CALLES
            // 
            this.CB_CALLES.FormattingEnabled = true;
            this.CB_CALLES.Location = new System.Drawing.Point(300, 135);
            this.CB_CALLES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_CALLES.Name = "CB_CALLES";
            this.CB_CALLES.Size = new System.Drawing.Size(121, 24);
            this.CB_CALLES.TabIndex = 31;
            this.CB_CALLES.SelectedIndexChanged += new System.EventHandler(this.CB_CALLES_SelectedIndexChanged);
            // 
            // CB_BARRIOS
            // 
            this.CB_BARRIOS.FormattingEnabled = true;
            this.CB_BARRIOS.Location = new System.Drawing.Point(300, 79);
            this.CB_BARRIOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_BARRIOS.Name = "CB_BARRIOS";
            this.CB_BARRIOS.Size = new System.Drawing.Size(121, 24);
            this.CB_BARRIOS.TabIndex = 30;
            this.CB_BARRIOS.SelectedIndexChanged += new System.EventHandler(this.CB_BARRIOS_SelectedIndexChanged);
            // 
            // CB_CIUDADES
            // 
            this.CB_CIUDADES.FormattingEnabled = true;
            this.CB_CIUDADES.Location = new System.Drawing.Point(300, 21);
            this.CB_CIUDADES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_CIUDADES.Name = "CB_CIUDADES";
            this.CB_CIUDADES.Size = new System.Drawing.Size(121, 24);
            this.CB_CIUDADES.TabIndex = 29;
            this.CB_CIUDADES.SelectedIndexChanged += new System.EventHandler(this.CB_CIUDADES_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Barrio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(221, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ciudad";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(111, 126);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefono.MaxLength = 10;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 22);
            this.tbTelefono.TabIndex = 16;
            // 
            // tbPr_apellido
            // 
            this.tbPr_apellido.Location = new System.Drawing.Point(111, 70);
            this.tbPr_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPr_apellido.MaxLength = 10;
            this.tbPr_apellido.Name = "tbPr_apellido";
            this.tbPr_apellido.Size = new System.Drawing.Size(100, 22);
            this.tbPr_apellido.TabIndex = 14;
            // 
            // tbPr_nombre
            // 
            this.tbPr_nombre.Location = new System.Drawing.Point(111, 23);
            this.tbPr_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPr_nombre.MaxLength = 10;
            this.tbPr_nombre.Name = "tbPr_nombre";
            this.tbPr_nombre.Size = new System.Drawing.Size(100, 22);
            this.tbPr_nombre.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 178);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "telefono";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "pr_apellido";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "pr_nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(275, 91);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 60);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerRegistro
            // 
            this.btnVerRegistro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVerRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRegistro.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerRegistro.Location = new System.Drawing.Point(267, 180);
            this.btnVerRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerRegistro.Name = "btnVerRegistro";
            this.btnVerRegistro.Size = new System.Drawing.Size(101, 50);
            this.btnVerRegistro.TabIndex = 40;
            this.btnVerRegistro.Text = "Registro";
            this.btnVerRegistro.UseVisualStyleBackColor = false;
            this.btnVerRegistro.Click += new System.EventHandler(this.btnVerRegistro_Click);
            // 
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerRegistro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnCLientes);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1026, 618);
            this.MinimumSize = new System.Drawing.Size(1026, 618);
            this.Name = "FrmLoginAdmin";
            this.Text = "FrmLoginAdmin";
            this.Load += new System.EventHandler(this.FrmLoginAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.pnCLientes.ResumeLayout(false);
            this.pnCLientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Panel pnCLientes;
        private System.Windows.Forms.ComboBox CB_CALLES;
        private System.Windows.Forms.ComboBox CB_BARRIOS;
        private System.Windows.Forms.ComboBox CB_CIUDADES;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbPr_apellido;
        private System.Windows.Forms.TextBox tbPr_nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerRegistro;
    }
}