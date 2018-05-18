using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {

        public Usuario()
        {
            Persona = new Persona();
        }

        public int IdUsuario { get; set; }
        public string NMUsuario { get; set; }
        public string Clave { get; set; }
        public Persona Persona { get; set; }
    }
}
