using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public string NombreTurno { get; set; }

        public override string ToString()
        {
            return NombreTurno;
        }
    }
}
