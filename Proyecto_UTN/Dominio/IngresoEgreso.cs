using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class IngresoEgreso
    {
        public IngresoEgreso()
        {
            Persona = new Persona();
            Barrera = new Barrera();
        }

        DateTime FechaIngreso { get; set; }
        DateTime FechaEgreso { get; set; }
        Persona Persona { get; set; }
        Barrera Barrera { get; set; }
    }
}
