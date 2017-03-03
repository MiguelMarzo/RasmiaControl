using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Levadura : IEquatable<Levadura>
    {
        public int idLevadura { get; set; }
        public String nombreLevadura { get; set; }

        public Levadura(int idLevadura, String nombreLevadura)
        {
            this.idLevadura = idLevadura;
            this.nombreLevadura = nombreLevadura;
        }

        public bool Equals(Levadura other)
        {
            if (other == null)
                return false;

            if (this.idLevadura == other.idLevadura)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return nombreLevadura.ToString();
        }
    }
}
