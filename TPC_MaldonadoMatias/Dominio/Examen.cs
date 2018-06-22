using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Examen
    {
        public Examen()
        {
            TipoExamen = new TipoExamen();
            Cursada = new Cursada();
        }


        public int IdExamen { get; set; }
        public TipoExamen TipoExamen { get; set; }
        public string NombreExamen { get; set; }
        public DateTime Fecha { get; set; }
        public Cursada Cursada { get; set; }
        public Alumno Alumno { get; set; }
        public decimal Nota { get; set; }
    }
}
