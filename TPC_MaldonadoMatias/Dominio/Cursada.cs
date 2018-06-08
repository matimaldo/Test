using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cursada
    {

        public Cursada()
        {
            Curso = new Curso();
            Comision = new Comision();
            //Turno = new Turno();
            Anio = new AnioLectivo();
            //Aula = new Aula();
            Profesor = new Empleado();
        }

        public int IdCursada { get; set; }
        public Curso Curso { get; set; }
        public Comision Comision { get; set; }
        //public Turno Turno { get; set; }
        public AnioLectivo Anio { get; set; }
        public Empleado Profesor { get; set; }
        public IList<Alumno> Alumnos { get; set; }
        public IList<Examen> Examenes { get; set; }
        public IList<Dia> Dias { get; set; }
        //public Aula Aula { get; set; }
        public int CantidadMaxima { get; set; }
        public bool Estado { get; set; }

        private string acc;

        public string ACC
        {

            get
            {
                return acc;
            }
            set
            {
                acc = Anio.Anio + " - " + Curso.NombreCurso + " - "+ Comision.NombreComision;
            }
        }


        public override string ToString()
        {
            return Curso.NombreCurso;
        }

    }
}
