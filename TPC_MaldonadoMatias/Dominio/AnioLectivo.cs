using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AnioLectivo
    {
        public int IdAnio { get; set; }
        public int Anio { get; set; }

        public override string ToString()
        {
            return Anio.ToString();
        }
    }
}
