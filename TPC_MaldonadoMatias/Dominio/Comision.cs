using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comision
    {
        public int IdComision { get; set; }
        public string NombreComision { get; set; }


        public override string ToString()
        {
            return NombreComision;
        }
    }
}
