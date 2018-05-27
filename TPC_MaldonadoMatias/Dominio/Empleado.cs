using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado : Persona
    {

        public override string ToString()
        {
            return Apellido +", "+Nombre;
        }

    }
}
