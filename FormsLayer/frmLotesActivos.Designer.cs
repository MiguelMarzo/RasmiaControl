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
            this.btnVolver = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(232, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(425, 83);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lotes Activos";
            // 
            // dgvLotesActivos
            // 
            this.dgvLotesActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLotesActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgvLotesActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotesActivos.Location = new System.Drawing.Point(13, 110);
            this.dgvLotesActivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLotesActivos.Name = "dgvLotesActivos";
            this.dgvLotesActivos.Size = new System.Drawing.Size(644, 377);
            this.dgvLotesActivos.TabIndex = 2;
            this.dgvLotesActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellEnterLotes);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnControl.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnControl.Location = new System.Drawing.Point(694, 132);
            this.btnControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(225, 134);
            this.btnControl.TabIndex = 3;
            this.btnControl.Text = "Realizar Control";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn2.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Location = new System.Drawing.Point(694, 338);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(225, 134);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Mas";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnVolver.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolver.Location = new System.Drawing.Point(13, 22);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(169, 50);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.LightSalmon;
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Image = global::FormsLayer.Properties.Resources.icon;
            this.picIcon.Location = new System.Drawing.Point(756, 9);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(117, 113);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 6;
            this.picIcon.TabStop = false;
            // 
            // frmLotesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(948, 500);
            this.ControlBox = false;
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.dgvLotesActivos);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(966, 547);
            this.Name = "frmLotesActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rasmia - Lotes Activos";
            this.Load += new System.EventHandler(this.frmLotesActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotesActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLotesActivos;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox picIcon;
    }
}