using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Horario
    {
        public int IdHorario { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        public override string ToString()
        {
            string dh = "";
            string dm = "";
            string hh = "";
            string hm = "";

            if (Desde.Hour < 10)
            { dh = "0" + Desde.Hour.ToString(); }
            else { dh = Desde.Hour.ToString(); }

            if (Desde.Minute < 10)
            { dm = "0" + Desde.Minute.ToString(); }
            else { dm = Desde.Minute.ToString(); }

            if (Hasta.Hour < 10)
            { hh = "0" + Hasta.Hour.ToString(); }
            else { hh = Hasta.Hour.ToString(); }

            if (Hasta.Minute < 10)
            { hm = "0" + Hasta.Minute.ToString(); }
            else { hm = Hasta.Minute.ToString(); }

            
            return dh + ":" + dm + " - " + hh + ":" + hm;
        }

    }
}
