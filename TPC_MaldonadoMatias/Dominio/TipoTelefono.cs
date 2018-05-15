using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoTelefono
    {
        public int IdTipoTelefono { get; set; }
        public string NombreTipoTelefono { get; set; }

        public TipoTelefono() { }
        public TipoTelefono(int id, string nombre)
        {
            IdTipoTelefono = id;
            NombreTipoTelefono = nombre;
        }
            
        public override string ToString()
        {
            return NombreTipoTelefono;
        }
    }
}
