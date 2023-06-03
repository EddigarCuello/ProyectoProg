namespace Presentacion
{
    partial class FrmSelectNewEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectNewEmpleado));
            this.CB_NewEmpleado = new System.Windows.Forms.ComboBox();
            this.lbNombres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_NewEmpleado
            // 
            this.CB_NewEmpleado.FormattingEnabled = true;
            this.CB_NewEmpleado.Location = new System.Drawing.Point(220, 134);
            this.CB_NewEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.CB_NewEmpleado.Name = "CB_NewEmpleado";
            this.CB_NewEmpleado.Size = new System.Drawing.Size(92, 21);
            this.CB_NewEmpleado.TabIndex = 33;
            this.CB_NewEmpleado.SelectedIndexChanged += new System.EventHandler(this.CB_NewEmpleado_SelectedIndexChanged);
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.BackColor = System.Drawing.Color.Transparent;
            this.lbNombres.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(80, 50);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(406, 36);
            this.lbNombres.TabIndex = 32;
            this.lbNombres.Text = "Seleccione Un Empleado";
            // 
            // FrmSelectNewEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 326);
            this.ControlBox = false;
            this.Controls.Add(this.CB_NewEmpleado);
            this.Controls.Add(this.lbNombres);
            this.Name = "FrmSelectNewEmpleado";
            this.Text = "FrmSelectNewEmpleado";
            this.Load += new System.EventHandler(this.FrmSelectNewEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_NewEmpleado;
        private System.Windows.Forms.Label lbNombres;
    }
}