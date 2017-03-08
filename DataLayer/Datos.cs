﻿using System;
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
                            drControl.Densidad, drControl.IDEmpleado, drControl.Ph, drControl.Observaciones);
            return controles.ToList();
        }
        public List<Empleado> TodosLosEmpleados()
        {
            var empleados = from drEmpleado in dsRasmia.Empleado
                            select new Empleado(drEmpleado.IdEmpleado, drEmpleado.Nombre);
            return empleados.ToList();
        }

    }
}
