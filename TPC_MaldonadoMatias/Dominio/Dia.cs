﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Dia
    {
        public int IdDia { get; set; }
        public string NombreDia { get; set; }
        public IList<Horario> Horarios { get; set; }
    }
}
