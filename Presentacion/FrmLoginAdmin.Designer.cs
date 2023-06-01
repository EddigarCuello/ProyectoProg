namespace Presentacion
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Size = new System.Drawing.Size(1011, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.panel1.Size = new System.Drawing.Size(267, 581);
            this.panel1.TabIndex = 1;
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
            this.btnConsultar.Text = "Consultar Datos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 207);
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
            this.dgEmpleados.Location = new System.Drawing.Point(267, 257);
            this.dgEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.ReadOnly = true;
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmpleados.Size = new System.Drawing.Size(744, 324);
            this.dgEmpleados.TabIndex = 2;
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
            this.pnCLientes.Controls.Add(this.textBox3);
            this.pnCLientes.Controls.Add(this.textBox8);
            this.pnCLientes.Controls.Add(this.textBox9);
            this.pnCLientes.Controls.Add(this.button2);
            this.pnCLientes.Controls.Add(this.label15);
            this.pnCLientes.Controls.Add(this.label17);
            this.pnCLientes.Controls.Add(this.label18);
            this.pnCLientes.Location = new System.Drawing.Point(442, 12);
            this.pnCLientes.Name = "pnCLientes";
            this.pnCLientes.Size = new System.Drawing.Size(439, 218);
            this.pnCLientes.TabIndex = 20;
            // 
            // CB_CALLES
            // 
            this.CB_CALLES.FormattingEnabled = true;
            this.CB_CALLES.Location = new System.Drawing.Point(300, 136);
            this.CB_CALLES.Name = "CB_CALLES";
            this.CB_CALLES.Size = new System.Drawing.Size(121, 24);
            this.CB_CALLES.TabIndex = 31;
            // 
            // CB_BARRIOS
            // 
            this.CB_BARRIOS.FormattingEnabled = true;
            this.CB_BARRIOS.Location = new System.Drawing.Point(300, 79);
            this.CB_BARRIOS.Name = "CB_BARRIOS";
            this.CB_BARRIOS.Size = new System.Drawing.Size(121, 24);
            this.CB_BARRIOS.TabIndex = 30;
            // 
            // CB_CIUDADES
            // 
            this.CB_CIUDADES.FormattingEnabled = true;
            this.CB_CIUDADES.Location = new System.Drawing.Point(300, 21);
            this.CB_CIUDADES.Name = "CB_CIUDADES";
            this.CB_CIUDADES.Size = new System.Drawing.Size(121, 24);
            this.CB_CIUDADES.TabIndex = 29;
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
            this.label16.Location = new System.Drawing.Point(222, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ciudad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(111, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(111, 23);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "telefono";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "pr_apellido";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "pr_nombre";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(142, 409);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(94, 20);
            this.lbPass.TabIndex = 42;
            this.lbPass.Text = "Password";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(142, 361);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(49, 20);
            this.lbUser.TabIndex = 41;
            this.lbUser.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 408);
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
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 581);
            this.ControlBox = false;
            this.Controls.Add(this.pnCLientes);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}