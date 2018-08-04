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
            PagoAbono = new PagoAbono();
        }

        public int idAbonoVendido { get; set; }
        public DateTime FechaVenta { get; set; }
        Persona Persona { get; set; }
        PagoAbono PagoAbono { get; set; }
        public int CantUtilizado { get; set; }
        public bool Consumido { get; set; }
    }
}
