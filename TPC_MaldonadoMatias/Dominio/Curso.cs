﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }

        public override string ToString()
        {
            return NombreCurso;
        }
    }
}
