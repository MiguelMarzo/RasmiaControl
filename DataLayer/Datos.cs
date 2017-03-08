using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer.DSRasmiaTableAdapters;

namespace DataLayer
{
    public class Datos
    {
        private DSRasmia dsRasmia;
        private LoteTableAdapter daLote;
        private ControlLoteTableAdapter daControl;
        private NutrienteTableAdapter daNutriente;
        private LevaduraTableAdapter daLevadura;
        private NutrientesLoteTableAdapter daNutrientesLote;
        private LevadurasLoteTableAdapter daLevadursaLote;
        private EmpleadoTableAdapter daEmpleado;

        public Datos()
        {
            CrearDataSetCompleto();
        }

        private void CrearDataSetCompleto()
        {
            dsRasmia = new DSRasmia();

            daLote = new DSRasmiaTableAdapters.LoteTableAdapter();
            daLote.Fill(dsRasmia.Lote);

            daControl = new DSRasmiaTableAdapters.ControlLoteTableAdapter();
            daControl.Fill(dsRasmia.ControlLote);

            daNutriente = new DSRasmiaTableAdapters.NutrienteTableAdapter();
            daNutriente.Fill(dsRasmia.Nutriente);

            daLevadura = new DSRasmiaTableAdapters.LevaduraTableAdapter();
            daLevadura.Fill(dsRasmia.Levadura);

            daNutrientesLote = new DSRasmiaTableAdapters.NutrientesLoteTableAdapter();
            daNutrientesLote.Fill(dsRasmia.NutrientesLote);

            daLevadursaLote = new DSRasmiaTableAdapters.LevadurasLoteTableAdapter();
            daLevadursaLote.Fill(dsRasmia.LevadurasLote);

            daEmpleado = new DSRasmiaTableAdapters.EmpleadoTableAdapter();
            daEmpleado.Fill(dsRasmia.Empleado);
        }

        //SELECTS (DEVOLVER REGISTROS)
        public List<Lote> LotesActivos()
        {
            var lotes = from drLote in dsRasmia.Lote
                        where drLote.Activo == "Activo"
                        select new Lote(drLote.Id, drLote.Miel, drLote.Litros, drLote.FechaInicio, drLote.FechaFinal,
                        drLote.Variedad, drLote.Activo);
            return lotes.ToList();
        }
        public List<ControlLote> ControlesDeUnLote(Lote lote)
        {
            var controles = from drControl in dsRasmia.ControlLote
                            where drControl.idLote == lote.idLote
                            select new ControlLote(drControl.idControl, drControl.idLote, drControl.Temperatura,
                            drControl.Densidad, drControl.IDEmpleado, drControl.Ph, drControl.Observaciones, drControl.Fecha);
            return controles.ToList();
        }
        public List<Empleado> TodosLosEmpleados()
        {
            var empleados = from drEmpleado in dsRasmia.Empleado
                            select new Empleado(drEmpleado.IdEmpleado, drEmpleado.Nombre);
            return empleados.ToList();
        }


        //UPDATES 
        //TODO: implementar try catchs
        public String EditarControl(ControlLote control)
        {
            var drControl = dsRasmia.ControlLote.FindByidControl(control.idControl);
            drControl.IDEmpleado = control.idEmpleado;
            drControl.Densidad = control.densidad;
            drControl.Observaciones = control.observaciones;
            drControl.Ph = control.ph;
            drControl.Temperatura = control.temperatura;
            drControl.Fecha = control.fecha;
            daControl.Update(drControl);
            dsRasmia.ControlLote.GetChanges();
            drControl.AcceptChanges();
            return "Lote actualizado";
        }


        //INSERTS
        //TODO: implementar try catchs
        public String AñadirControl(ControlLote control)
        {
            DSRasmia.ControlLoteRow drControl = dsRasmia.ControlLote.NewControlLoteRow();
            drControl.idControl = MaxIdControl();
            drControl.idLote = control.idLote;
            drControl.IDEmpleado = control.idEmpleado;
            drControl.Temperatura = control.temperatura;
            drControl.Ph = control.ph;
            drControl.Densidad = control.densidad;
            drControl.Observaciones = control.observaciones;
            drControl.Fecha = control.fecha;
            dsRasmia.ControlLote.AddControlLoteRow(drControl);
            daControl.Update(drControl);
            return "Control añadido";
        }


        //AUXILIARES private
        //TODO: Cambiar MaxIdControl y Control en general para que tenga un id dependiente del idLote
        //      O sino, cambiar el cmbControl para que muestre la fecha
        //      En cualquier caso hay que añadir fecha a la tabla Control y a su entidad correspondiente
        private int MaxIdControl()
        {
            var maxID = dsRasmia.ControlLote.OrderByDescending(x => x.idControl).First().idControl;
            return maxID + 1;
        }
    }
}
