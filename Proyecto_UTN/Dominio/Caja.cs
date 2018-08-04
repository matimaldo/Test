using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Caja
    {
        public DateTime Dia { get; set; }
        public DateTime HoraApertura { get; set; }
        public DateTime HoraCierre { get; set; }
        public float MontoApertura { get; set; }
        public float MontoCierre { get; set; }
        public float MontoConteo { get; set; }

    }
}
