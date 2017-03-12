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
            lotes = _negocio.TodosLosLotes();
            dgvLotes.DataSource = lotes.Select(o => new
            {
                IdLote = o.idLote,
                Variedad = o.variedad,
                Miel = o.miel,
                Litros = o.litros,
                FechaInicio = o.fechaInicio
            }).ToList();
            if (dgvLotes.Rows.Count > 0) { dgvLotes.Rows[0].Selected = true; }
        }
        private void CellEnterLotes(object sender, DataGridViewCellEventArgs e)
        {
            dgvLotes.Rows[dgvLotes.SelectedCells[0].RowIndex].Selected = true;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInit inicio = new frmInit();
            inicio.Show();
            this.Close();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Lote loteSeleccionado = lotes.Find(a => a.idLote.ToString() == dgvLotes.SelectedRows[0].Cells[0].Value.ToString());
            frmEstadisticasLote estats = new frmEstadisticasLote(loteSeleccionado);            
            estats.Show();
            this.Close();
        }
    }
}
