using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class LotControl : IEquatable<LotControl>
    {
        public int idControl { get; set; }
        public int idLot { get; set; }
        public String temperature { get; set; }
        public String density { get; set; }
        public String employee { get; set; }

        public LotControl(int idControl, int idLot, String temperature, String density, String employee)
        {
            this.idControl = idControl;
            this.idLot = idLot;
            this.temperature = temperature;
            this.density = density;
            this.employee = employee;
        }
        public bool Equals(LotControl other)
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
