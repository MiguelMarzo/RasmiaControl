﻿namespace FormsLayer
{
    partial class frmEstadisticasLote
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.btnPH = new System.Windows.Forms.Button();
            this.btnDensidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 96);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(633, 373);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperatura.Location = new System.Drawing.Point(674, 114);
            this.btnTemperatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(184, 84);
            this.btnTemperatura.TabIndex = 4;
            this.btnTemperatura.Text = "Temperatura";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            // 
            // btnPH
            // 
            this.btnPH.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPH.Location = new System.Drawing.Point(674, 246);
            this.btnPH.Margin = new System.Windows.Forms.Padding(4);
            this.btnPH.Name = "btnPH";
            this.btnPH.Size = new System.Drawing.Size(184, 84);
            this.btnPH.TabIndex = 5;
            this.btnPH.Text = "PH";
            this.btnPH.UseVisualStyleBackColor = true;
            // 
            // btnDensidad
            // 
            this.btnDensidad.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDensidad.Location = new System.Drawing.Point(674, 378);
            this.btnDensidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnDensidad.Name = "btnDensidad";
            this.btnDensidad.Size = new System.Drawing.Size(184, 84);
            this.btnDensidad.TabIndex = 6;
            this.btnDensidad.Text = "Densidad";
            this.btnDensidad.UseVisualStyleBackColor = true;
            // 
            // frmEstadisticasLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnDensidad);
            this.Controls.Add(this.btnPH);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.chart1);
            this.Name = "frmEstadisticasLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rasmia - Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Button btnPH;
        private System.Windows.Forms.Button btnDensidad;
    }
}