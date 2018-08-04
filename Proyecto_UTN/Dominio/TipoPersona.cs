using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoPersona
    {
        public int IdTipo { get; set; }
        public string NMTipoPersona { get; set; }

        public override string ToString()
        {
            return NMTipoPersona;
        }
    }
}
