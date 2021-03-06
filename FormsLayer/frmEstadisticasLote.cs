﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;

namespace FormsLayer
{
    public partial class frmEstadisticasLote : Form
    {
        private Negocio _negocio = new Negocio();
        private Lote lote;
        private List<ControlLote> controles = new List<ControlLote>();
        public frmEstadisticasLote(Lote loteSeleccionado)
        {
            this.lote = loteSeleccionado;
            InitializeComponent();
        }

        private void frmEstadisticasLote_Load(object sender, EventArgs e)
        {
            controles = _negocio.ControlesDeUnLote(lote);
            foreach (ControlLote control in controles)
            {
                chart1.Series["Series1"].Points.AddXY(control.idControl, control.temperatura);                
            }
            chart1.Series["Series1"].Name = "Temperatura";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmEstadisticas estats = new frmEstadisticas();
            estats.Show();
            this.Close();
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            foreach (ControlLote control in controles)
            {
                chart1.Series[0].Points.AddXY(control.idControl, control.temperatura);
            }
            chart1.Series[0].Name = "Temperatura";
            chart1.Refresh();
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            foreach (ControlLote control in controles)
            {
                chart1.Series[0].Points.AddXY(control.idControl, control.ph);
            }
            chart1.Series[0].Name = "PH";
            chart1.Refresh();
        }

        private void btnDensidad_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            foreach (ControlLote control in controles)
            {
                chart1.Series[0].Points.AddXY(control.idControl, control.densidad);
            }
            chart1.Series[0].Name = "Densidad";
            chart1.Refresh();
        }
    }
}
