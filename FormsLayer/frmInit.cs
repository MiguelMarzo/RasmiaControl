using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLayer
{
    public partial class frmInit : Form
    {
        public frmInit()
        {
            InitializeComponent();
        }

        private void frmInit_Load(object sender, EventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            frmLotesActivos lotesActivos = new frmLotesActivos();            
            lotesActivos.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            frmEstadisticas estats = new frmEstadisticas();
            estats.Show();
            this.Close();
        }
    }
}
