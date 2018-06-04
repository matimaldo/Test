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
            Telefono = new Telefono();
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public string Mail { get; set; }
        public Telefono Telefono { get; set; }
        public string Sexo { get; set; }
        public bool Estado { get; set; }

        private string apno;

        public string Apno
        {

            get
            {
                return apno;
            }
            set
            {
                apno = Apellido + ", " + Nombre;
            }
        }

    }
}
