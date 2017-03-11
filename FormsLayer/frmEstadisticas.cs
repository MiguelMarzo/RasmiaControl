using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using EntityLayer;

namespace FormsLayer
{
    public partial class frmEstadisticas : Form
    {
        private Negocio _negocio = new Negocio();
        private List<Lote> lotes = new List<Lote>();
        public frmEstadisticas()
        {
            InitializeComponent();
        }
        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            //lotes = _negocio.TodosLosLotes();
            //dgvLotes.DataSource = lotes;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInit inicio = new frmInit();
            inicio.Show();
            this.Close();
        }
    }
}
