using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ControlLote : IEquatable<ControlLote>
    {
        public int idControl { get; set; }
        public int idLote { get; set; }
        public String temperatura { get; set; }
        public String densidad { get; set; }
        public int idEmpleado { get; set; }
        public String ph { get; set; }
        public String observaciones { get; set; }


        public ControlLote()
        {

        }
        public ControlLote(int idControl, int idLote, String temperatura, String densidad, int empleado, String ph, String observaciones)
        {
            this.idControl = idControl;
            this.idLote = idLote;
            this.temperatura = temperatura;
            this.densidad = densidad;
            this.idEmpleado = empleado;
            this.ph = ph;
            this.observaciones = observaciones;
        }
        public bool Equals(ControlLote other)
        {
            if (other == null)
                return false;

            if (this.idControl == other.idControl)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return idControl.ToString();
        }
    }
}
