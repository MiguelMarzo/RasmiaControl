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

namespace FormsLayer
{
    public partial class frmLotesActivos : Form
    {
        private Negocio _negocio = new Negocio();
        public frmLotesActivos()
        {
            InitializeComponent();
        }

        private void frmLotesActivos_Load(object sender, EventArgs e)
        {
            dgvLotesActivos.DataSource = _negocio.LotesActivos().Select(o => new
            {
                IdLote = o.idLote,
                Variedad = o.variedad,
                Miel = o.miel,
                Litros = o.litros,
                FechaInicio = o.fechaInicio
            }).ToList();
        }
    }
}
