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
            this.lblFecha = new System.Windows.Forms.Label();
            this.calendarFecha = new System.Windows.Forms.MonthCalendar();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnControl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnControl.Location = new System.Drawing.Point(724, 375);
            this.btnControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(149, 101);
            this.btnControl.TabIndex = 7;
            this.btnControl.Text = "Realizar Control";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // lblIDLote
            // 
            this.lblIDLote.AutoSize = true;
            this.lblIDLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblIDLote.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIDLote.Location = new System.Drawing.Point(116, 128);
            this.lblIDLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDLote.Name = "lblIDLote";
            this.lblIDLote.Size = new System.Drawing.Size(80, 22);
            this.lblIDLote.TabIndex = 8;
            this.lblIDLote.Text = "ID Lote:";
            // 
            // lblIDControl
            // 
            this.lblIDControl.AutoSize = true;
            this.lblIDControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblIDControl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIDControl.Location = new System.Drawing.Point(100, 178);
            this.lblIDControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDControl.Name = "lblIDControl";
            this.lblIDControl.Size = new System.Drawing.Size(110, 22);
            this.lblIDControl.TabIndex = 9;
            this.lblIDControl.Text = "ID Control:";
            // 
            // txtIDLote
            // 
            this.txtIDLote.BackColor = System.Drawing.Color.White;
            this.txtIDLote.Enabled = false;
            this.txtIDLote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIDLote.Location = new System.Drawing.Point(265, 127);
            this.txtIDLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDLote.Name = "txtIDLote";
            this.txtIDLote.Size = new System.Drawing.Size(160, 22);
            this.txtIDLote.TabIndex = 10;
            // 
            // cmbControles
            // 
            this.cmbControles.BackColor = System.Drawing.Color.White;
            this.cmbControles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbControles.FormattingEnabled = true;
            this.cmbControles.Location = new System.Drawing.Point(265, 177);
            this.cmbControles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbControles.Name = "cmbControles";
            this.cmbControles.Size = new System.Drawing.Size(160, 24);
            this.cmbControles.TabIndex = 11;
            this.cmbControles.SelectedIndexChanged += new System.EventHandler(this.cmbControles_SelectedIndexChanged);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BackColor = System.Drawing.Color.White;
            this.txtTemperatura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTemperatura.Location = new System.Drawing.Point(265, 229);
            this.txtTemperatura.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(160, 22);
            this.txtTemperatura.TabIndex = 13;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTemperatura.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTemperatura.Location = new System.Drawing.Point(64, 230);
            this.lblTemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(178, 22);
            this.lblTemperatura.TabIndex = 12;
            this.lblTemperatura.Text = "Temperatura (Cº):";
            // 
            // txtDensidad
            // 
            this.txtDensidad.BackColor = System.Drawing.Color.White;
            this.txtDensidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDensidad.Location = new System.Drawing.Point(265, 279);
            this.txtDensidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtDensidad.Name = "txtDensidad";
            this.txtDensidad.Size = new System.Drawing.Size(160, 22);
            this.txtDensidad.TabIndex = 15;
            // 
            // lblDensidad
            // 
            this.lblDensidad.AutoSize = true;
            this.lblDensidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblDensidad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDensidad.Location = new System.Drawing.Point(104, 281);
            this.lblDensidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDensidad.Name = "lblDensidad";
            this.lblDensidad.Size = new System.Drawing.Size(105, 22);
            this.lblDensidad.TabIndex = 14;
            this.lblDensidad.Text = "Densidad:";
            // 
            // txtPH
            // 
            this.txtPH.BackColor = System.Drawing.Color.White;
            this.txtPH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPH.Location = new System.Drawing.Point(265, 330);
            this.txtPH.Margin = new System.Windows.Forms.Padding(4);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(160, 22);
            this.txtPH.TabIndex = 17;
            // 
            // lblPH
            // 
            this.lblPH.AutoSize = true;
            this.lblPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblPH.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPH.Location = new System.Drawing.Point(137, 331);
            this.lblPH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(41, 22);
            this.lblPH.TabIndex = 16;
            this.lblPH.Text = "PH:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtObservaciones.Location = new System.Drawing.Point(265, 377);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(420, 99);
            this.txtObservaciones.TabIndex = 19;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblObservaciones.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblObservaciones.Location = new System.Drawing.Point(77, 378);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(153, 22);
            this.lblObservaciones.TabIndex = 18;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(615, 26);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(111, 22);
            this.lblEmpleado.TabIndex = 20;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.BackColor = System.Drawing.Color.White;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(741, 26);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(160, 24);
            this.cmbEmpleado.TabIndex = 21;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(457, 228);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 22);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha:";
            // 
            // calendarFecha
            // 
            this.calendarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.calendarFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calendarFecha.Location = new System.Drawing.Point(550, 140);
            this.calendarFecha.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendarFecha.MaxSelectionCount = 1;
            this.calendarFecha.Name = "calendarFecha";
            this.calendarFecha.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(292, 8);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 83);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Control";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnVolver.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolver.Location = new System.Drawing.Point(41, 13);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(169, 50);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(948, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.calendarFecha);
            this.Controls.Add(this.lblFecha);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(966, 547);
            this.Name = "frmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rasmia - Realizar Control";
            this.Load += new System.EventHandler(this.frmControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MonthCalendar calendarFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolver;
    }
}