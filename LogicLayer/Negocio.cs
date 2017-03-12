using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;

namespace LogicLayer
{
    public class Negocio
    {
        private Datos _datos = new Datos();

        public List<Lote> LotesActivos()
        {
            return _datos.LotesActivos();
        }
        public List<ControlLote> ControlesDeUnLote(Lote lote)
        {
            return _datos.ControlesDeUnLote(lote);
        }
        public List<Empleado> TodosLosEmpleados()
        {
            return _datos.TodosLosEmpleados();
        }
        public String EditarControl(ControlLote control)
        {
            return _datos.EditarControl(control);
        }
        public String AñadirControl(ControlLote control)
        {
            return _datos.AñadirControl(control);
        }

        public List<Lote> TodosLosLotes()
        {
            return _datos.TodosLosLotes();
        }
    }
}
