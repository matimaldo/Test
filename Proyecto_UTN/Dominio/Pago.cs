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
            MedioPago = new MedioPago();
        }

        public DateTime FechaPago { get; set; }
        public int NroComprobante { get; set; }
        public float Monto { get; set; }
        MedioPago MedioPago { get; set; }
    }
}
