﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDiscos
{
    public class Estilo
    {
        public string Descripcion {  get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}