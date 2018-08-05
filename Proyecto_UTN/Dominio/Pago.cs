using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pago
    {
        public Pago()
        {
            Abono = new Abono();
            MedioPago = new MedioPago();
        }

        public DateTime FechaPago { get; set; }
        public int NroComprobante { get; set; }
        Abono Abono { get; set; }
        MedioPago MedioPago { get; set; }
    }
}
