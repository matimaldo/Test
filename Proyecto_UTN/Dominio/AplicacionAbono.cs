using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AplicacionAbono : PagoDia
    {
        AplicacionAbono()
        {
            AbonoVendido = new AbonoVendido();
        }

        AbonoVendido AbonoVendido { get; set; }
    }
}
