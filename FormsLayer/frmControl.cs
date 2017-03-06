using System;
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
    public partial class frmControl : Form
    {
        private Negocio _negocio = new Negocio();
        private List<ControlLote> controles = new List<ControlLote>();
        private Lote lote;

        public frmControl(Lote loteElegido)
        {
            InitializeComponent();
            lote = loteElegido;
        }

        private void frmControl_Load(object sender, EventArgs e)
        {
            controles = _negocio.ControlesDeUnLote(lote);
            txtIDLote.Text = lote.idLote.ToString();
            cmbControles.Items.Add("Nuevo Control");
            foreach (ControlLote contr in controles)
            {
                cmbControles.Items.Add(contr);
            }
            cmbControles.DisplayMember = "idControl";            
            cmbControles.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLotesActivos lotesActivos = new frmLotesActivos();
            lotesActivos.Show();
            this.Close();
        }
    }
}
