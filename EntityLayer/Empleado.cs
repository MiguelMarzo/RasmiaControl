using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Empleado : IEquatable<Empleado>
    {
        public int idEmpleado { get; set; }
        public String nombre { get; set; }

        public Empleado() { }

        public Empleado(int idEmpleado, String nombre)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
        }

        public bool Equals(Empleado other)
        {
            if (other == null)
                return false;

            if (this.idEmpleado == other.idEmpleado)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return nombre.ToString();
        }
    }
}
