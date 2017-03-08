namespace FormsLayer
{
    partial class frmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControl));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.lblIDLote = new System.Windows.Forms.Label();
            this.lblIDControl = new System.Windows.Forms.Label();
            this.txtIDLote = new System.Windows.Forms.TextBox();
            this.cmbControles = new System.Windows.Forms.ComboBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtDensidad = new System.Windows.Forms.TextBox();
            this.lblDensidad = new System.Windows.Forms.Label();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.lblPH = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Tan;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(258, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 37);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Control";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(44, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 37);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnControl
            // 
            this.btnControl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.Location = new System.Drawing.Point(465, 163);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(112, 82);
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "Realizar Control";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // lblIDLote
            // 
            this.lblIDLote.AutoSize = true;
            this.lblIDLote.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLote.Location = new System.Drawing.Point(177, 81);
            this.lblIDLote.Name = "lblIDLote";
            this.lblIDLote.Size = new System.Drawing.Size(66, 19);
            this.lblIDLote.TabIndex = 8;
            this.lblIDLote.Text = "ID Lote:";
            // 
            // lblIDControl
            // 
            this.lblIDControl.AutoSize = true;
            this.lblIDControl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDControl.Location = new System.Drawing.Point(165, 122);
            this.lblIDControl.Name = "lblIDControl";
            this.lblIDControl.Size = new System.Drawing.Size(90, 19);
            this.lblIDControl.TabIndex = 9;
            this.lblIDControl.Text = "ID Control:";
            // 
            // txtIDLote
            // 
            this.txtIDLote.Enabled = false;
            this.txtIDLote.Location = new System.Drawing.Point(289, 80);
            this.txtIDLote.Name = "txtIDLote";
            this.txtIDLote.Size = new System.Drawing.Size(121, 20);
            this.txtIDLote.TabIndex = 10;
            // 
            // cmbControles
            // 
            this.cmbControles.FormattingEnabled = true;
            this.cmbControles.Location = new System.Drawing.Point(289, 121);
            this.cmbControles.Name = "cmbControles";
            this.cmbControles.Size = new System.Drawing.Size(121, 21);
            this.cmbControles.TabIndex = 11;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(289, 163);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(121, 20);
            this.txtTemperatura.TabIndex = 13;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(138, 164);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(145, 19);
            this.lblTemperatura.TabIndex = 12;
            this.lblTemperatura.Text = "Temperatura (Cº):";
            // 
            // txtDensidad
            // 
            this.txtDensidad.Location = new System.Drawing.Point(289, 204);
            this.txtDensidad.Name = "txtDensidad";
            this.txtDensidad.Size = new System.Drawing.Size(121, 20);
            this.txtDensidad.TabIndex = 15;
            // 
            // lblDensidad
            // 
            this.lblDensidad.AutoSize = true;
            this.lblDensidad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensidad.Location = new System.Drawing.Point(168, 205);
            this.lblDensidad.Name = "lblDensidad";
            this.lblDensidad.Size = new System.Drawing.Size(84, 19);
            this.lblDensidad.TabIndex = 14;
            this.lblDensidad.Text = "Densidad:";
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(289, 245);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(121, 20);
            this.txtPH.TabIndex = 17;
            // 
            // lblPH
            // 
            this.lblPH.AutoSize = true;
            this.lblPH.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH.Location = new System.Drawing.Point(193, 246);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(34, 19);
            this.lblPH.TabIndex = 16;
            this.lblPH.Text = "PH:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(289, 283);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(316, 81);
            this.txtObservaciones.TabIndex = 19;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(148, 284);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(124, 19);
            this.lblObservaciones.TabIndex = 18;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(461, 21);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(89, 19);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(556, 21);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 21;
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(711, 406);
            this.ControlBox = false;
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtPH);
            this.Controls.Add(this.lblPH);
            this.Controls.Add(this.txtDensidad);
            this.Controls.Add(this.lblDensidad);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.cmbControles);
            this.Controls.Add(this.txtIDLote);
            this.Controls.Add(this.lblIDControl);
            this.Controls.Add(this.lblIDLote);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Control";
            this.Load += new System.EventHandler(this.frmControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label lblIDLote;
        private System.Windows.Forms.Label lblIDControl;
        private System.Windows.Forms.TextBox txtIDLote;
        private System.Windows.Forms.ComboBox cmbControles;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtDensidad;
        private System.Windows.Forms.Label lblDensidad;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.Label lblPH;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
    }
}