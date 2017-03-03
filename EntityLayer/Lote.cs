using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Lote : IEquatable<Lote>
    {
        public int idLote { get; set; }
        public String miel { get; set; }
        public decimal litros { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public String variedad { get; set; }
        public String activo { get; set; }

        public Lote(int idLote, String miel, decimal litros, DateTime fechaInicio, DateTime fechaFin, String variedad, String activo)
        {
            this.idLote = idLote;
            this.miel = miel;
            this.litros = litros;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.variedad = variedad;
            this.activo = activo;
        }
        public bool Equals(Lote other)
        {
            if (other == null)
                return false;

            if (this.idLote == other.idLote)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return idLote.ToString();
        }
    }
}
