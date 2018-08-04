using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PagoAbono : Pago
    {
        public PagoAbono()
        {
            Abono = new Abono();
        }

        Abono Abono { get; set; }

    }
}
