using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Aula
    {
        public int IdAula { get; set; }
        public string NombreAula { get; set; }
        public Disponibilidad Disponibilidad { get; set; }
    }
}