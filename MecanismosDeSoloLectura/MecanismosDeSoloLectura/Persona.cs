﻿// ==++==


using System;

namespace MecanismosDeSoloLectura
{
    class Persona
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        public int Hash { get; private set; }

        public readonly Casa Hogar;

        public Persona(string nombre, string apellido, Casa hogar)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Hash = (nombre.GetHashCode() ^ rnd.Next(713) +
                apellido.GetHashCode() ^ rnd.Next(713));
            Nombre = nombre;
            Apellido = apellido;
            Hogar = hogar;

        }

    }
}