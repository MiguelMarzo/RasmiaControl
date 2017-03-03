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
    }
}
