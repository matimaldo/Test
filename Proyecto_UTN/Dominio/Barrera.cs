using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Barrera
    {
        public Barrera()
        {
            tipoIngresos = new TipoIngresos();
        }

        public int IdBarrera { get; set; }
        public string CodigoBarrera { get; set; }
        TipoIngresos tipoIngresos { get; set; }

    }
}
