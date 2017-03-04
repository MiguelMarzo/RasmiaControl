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
    public partial class frmLotesActivos : Form
    {
        private Negocio _negocio = new Negocio();
        private List<Lote> lotes = new List<Lote>();
        public frmLotesActivos()
        {
            InitializeComponent();
        }

        private void frmLotesActivos_Load(object sender, EventArgs e)
        {
            lotes = _negocio.LotesActivos();
            dgvLotesActivos.DataSource = lotes.Select(o => new
            {
                IdLote = o.idLote,
                Variedad = o.variedad,
                Miel = o.miel,
                Litros = o.litros,
                FechaInicio = o.fechaInicio
            }).ToList();
            if (dgvLotesActivos.Rows.Count > 0 ) { dgvLotesActivos.Rows[0].Selected = true; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInit inicio = new frmInit();            
            inicio.Show();
            this.Close();
        }

        private void CellEnterLotes(object sender, DataGridViewCellEventArgs e)
        {
            dgvLotesActivos.Rows[dgvLotesActivos.SelectedCells[0].RowIndex].Selected = true;
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Lote lote = lotes.Find(a => a.idLote.ToString() == dgvLotesActivos.SelectedRows[0].Cells[0].Value.ToString());
            frmControl frmControl = new frmControl(lote);
            frmControl.Show();
        }
    }
}
