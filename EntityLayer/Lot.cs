using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Lot : IEquatable<Lot>
    {
        public int idLot { get; set; }
        public DateTime startDate { get; set; }
        public DateTime finishDate { get; set; }
        public String varierty { get; set; }
        public String active { get; set; }

        public Lot(int idLot, DateTime startDate, DateTime finishDate, String variety, String active)
        {
            this.idLot = idLot;
            this.startDate = startDate;
            this.finishDate = finishDate;
            this.varierty = varierty;
            this.active = active;
        }
        public bool Equals(Lot other)
        {
            if (other == null)
                return false;

            if (this.idLot == other.idLot)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return idLot.ToString();
        }
    }
}
