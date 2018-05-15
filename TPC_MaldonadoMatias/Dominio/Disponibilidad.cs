using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disponibilidad
    {
        public int Id_Disponibilidad { get; set; }
        public IList<Dia> Dias { get; set; }

    }
}
