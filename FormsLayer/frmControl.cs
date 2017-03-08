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
        private List<Empleado> empleados = new List<Empleado>();
        private Lote lote;

        public frmControl(Lote loteElegido)
        {
            InitializeComponent();
            lote = loteElegido;

        }

        private void frmControl_Load(object sender, EventArgs e)
        {
            empleados = _negocio.TodosLosEmpleados();
            cmbEmpleado.DataSource = empleados;
            cmbEmpleado.DisplayMember = "nombre";
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

        private void btnControl_Click(object sender, EventArgs e)
        {
            ControlLote cntrlLote = new ControlLote();
            Empleado emp = (Empleado)cmbEmpleado.SelectedItem;
            cntrlLote.idEmpleado = emp.idEmpleado;
            cntrlLote.idLote = lote.idLote;
            cntrlLote.ph = txtPH.Text;
            cntrlLote.temperatura = txtTemperatura.Text;
            cntrlLote.observaciones = txtObservaciones.Text;
            cntrlLote.densidad = txtDensidad.Text;
            cntrlLote.fecha = calendarFecha.SelectionEnd;
            if (cmbControles.SelectedIndex != 0)
            {
                ControlLote cntrlSeleccionado = new ControlLote();
                cntrlSeleccionado = (ControlLote)cmbControles.SelectedItem;
                cntrlLote.idControl = cntrlSeleccionado.idControl;
                MessageBox.Show(_negocio.EditarControl(cntrlLote));
            } else
            {
                MessageBox.Show(_negocio.AñadirControl(cntrlLote));
            }
        }

        private void cmbControles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbControles.SelectedIndex > 0)
            {
                ControlLote cntrlSeleccionado = new ControlLote();
                cntrlSeleccionado = (ControlLote)cmbControles.SelectedItem;
                txtDensidad.Text = cntrlSeleccionado.densidad;
                txtObservaciones.Text = cntrlSeleccionado.observaciones;
                txtPH.Text = cntrlSeleccionado.ph;
                txtTemperatura.Text = cntrlSeleccionado.temperatura;
                calendarFecha.SelectionEnd = cntrlSeleccionado.fecha;
            } else
            {
                txtDensidad.Text = "";
                txtObservaciones.Text = "";
                txtPH.Text = "";
                txtTemperatura.Text = "";
                calendarFecha.SelectionEnd = DateTime.Today;
            }          
        }
    }
}
