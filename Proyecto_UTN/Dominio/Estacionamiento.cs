using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estacionamiento : IngresoEgreso
    {
        public float Valor { get; set; }
        public bool PagoHoy { get; set; }
    }
}
