namespace FormsLayer
{
    partial class frmLotesActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotesActivos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLotesActivos = new System.Windows.Forms.DataGridView();
            this.btnControl = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Tan;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(184, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lotes Activos";
            // 
            // dgvLotesActivos
            // 
            this.dgvLotesActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLotesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotesActivos.Location = new System.Drawing.Point(12, 67);
            this.dgvLotesActivos.Name = "dgvLotesActivos";
            this.dgvLotesActivos.Size = new System.Drawing.Size(450, 327);
            this.dgvLotesActivos.TabIndex = 2;
            // 
            // btnControl
            // 
            this.btnControl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.Location = new System.Drawing.Point(516, 78);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(169, 109);
            this.btnControl.TabIndex = 3;
            this.btnControl.Text = "Realizar Control";
            this.btnControl.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(516, 260);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(169, 109);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Mas";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // frmLotesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(711, 406);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.dgvLotesActivos);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLotesActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotes Activos";
            this.Load += new System.EventHandler(this.frmLotesActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLotesActivos;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btn2;
    }
}