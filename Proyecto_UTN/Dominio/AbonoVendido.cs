using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AbonoVendido
    {
        public AbonoVendido()
        {
            Persona = new Persona();
            Abono = new Abono();
            MedioPago = new MedioPago();
        }

        public int IdAbonoVendido { get; set; }
        public DateTime FechaVenta { get; set; }
        Persona Persona { get; set; }
        Abono Abono { get; set; }
        MedioPago MedioPago { get; set; }
        public int NroComprobante { get; set; }
    }
}
