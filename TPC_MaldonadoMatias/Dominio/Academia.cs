using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Academia
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Telefono Telefono { get; set; }
        public string Mail { get; set; }
        public List<Aula> Aulas { get; set; }
    }
}
