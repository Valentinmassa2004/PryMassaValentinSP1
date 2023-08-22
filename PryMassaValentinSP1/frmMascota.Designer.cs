namespace PryMassaValentinSP1
{
    partial class frmMascota
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipodemascota = new System.Windows.Forms.Label();
            this.lblFechadenacimiento = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipodemascota
            // 
            this.lblTipodemascota.AutoSize = true;
            this.lblTipodemascota.Location = new System.Drawing.Point(12, 59);
            this.lblTipodemascota.Name = "lblTipodemascota";
            this.lblTipodemascota.Size = new System.Drawing.Size(86, 13);
            this.lblTipodemascota.TabIndex = 2;
            this.lblTipodemascota.Text = "Tipo de mascota";
            // 
            // lblFechadenacimiento
            // 
            this.lblFechadenacimiento.AutoSize = true;
            this.lblFechadenacimiento.Location = new System.Drawing.Point(12, 107);
            this.lblFechadenacimiento.Name = "lblFechadenacimiento";
            this.lblFechadenacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechadenacimiento.TabIndex = 3;
            this.lblFechadenacimiento.Text = "Fecha de nacimiento";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(12, 75);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(314, 20);
            this.txtTipo.TabIndex = 4;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(12, 123);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(314, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(314, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // frmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 205);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblFechadenacimiento);
            this.Controls.Add(this.lblTipodemascota);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button1);
            this.Name = "frmMascota";
            this.Text = "Creador de Mascota";
            this.Load += new System.EventHandler(this.frmMascota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipodemascota;
        private System.Windows.Forms.Label lblFechadenacimiento;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNombre;
    }
}