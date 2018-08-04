using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Abono
    {
        public int IdAbono { get; set; }
        public int CantIngresos { get; set; }
        public float Valor { get; set; }
        public bool Vigente { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
