using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cursada
    {
        public int IdCursada { get; set; }
        public Curso Curso { get; set; }
        public Comision Comision { get; set; }
        public AnioLectivo Anio { get; set; }
        public IList<Alumno> Alumnos { get; set; }
        public IList<Examen> Examenes { get; set; }
        public IList<Dia> Dias { get; set; }
        public Aula Aula { get; set; }
        public int CantidadMaxima { get; set; }
        public bool Estado { get; set; }

    }
}
