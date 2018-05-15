using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Telefono
    {

        public Telefono()
        {
            TipoTelefono = new TipoTelefono();
        }
        
        public int IdTelefono { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public string Numero { get; set; }
        public string Contacto { get; set; }


        public override string ToString()
        {
            return Numero;
        }

    }
}
