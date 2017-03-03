using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Nutriente : IEquatable<Nutriente>
    {
        public int idNutriente { get; set; }
        public String nombreNutriente { get; set; }

        public Nutriente(int idNutriente, String nombreNutriente)
        {
            this.idNutriente = idNutriente;
            this.nombreNutriente = nombreNutriente;
        }

        public bool Equals(Nutriente other)
        {
            if (other == null)
                return false;

            if (this.idNutriente == other.idNutriente)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return nombreNutriente.ToString();
        }
    }
}
