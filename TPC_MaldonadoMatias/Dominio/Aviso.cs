using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Aviso
    {
        public int IdAviso { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Usuario { get; set; }
        public string Asunto { get; set; }
        public string Detalle { get; set; }

    }
}
