using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public Persona()
        {
            tipoPersona = new TipoPersona();
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Mail { get; set; }
        public string Huella1 { get; set; }
        public string Huella2 { get; set; }
        public string Huella3 { get; set; }
        TipoPersona tipoPersona { get; set; }

    }
}
