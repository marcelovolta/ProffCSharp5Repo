﻿// ==++==
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanismosDeSoloLectura
{
    class Casa
    {
        public string Direccion { get; set; }

        public int Superficie { get; set; }

        public Casa(string direccion, int superficie)
        {
            Direccion = direccion;
            Superficie = superficie;
        }
    }
}