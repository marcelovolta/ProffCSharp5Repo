﻿// ==++==

using System;

namespace MecanismosDeSoloLectura
{
    class Program
    {
        static void Main(string[] args)
        {
            EncabezadoYPieConsola _separador = new EncabezadoYPieConsola();

            #region Ejemplo 1: Propiedades y campos de sólo lectura
            _separador.EscribirEncabezado("Ejemplo 1: Propiedades y campos de sólo lectura");

            Casa casaDeSherlock = new Casa("221B Baker Street, London", 221);
            Persona sherlock = new Persona("Sherlock", "Holmes", casaDeSherlock);

            Console.WriteLine("Valores antes de pasarle el objeto a ClaseConfiable");
            ImprimirDetalles(sherlock);
            //Ahora le pasamos el objeto a ClaseConfiable, confiando en que no va a cambiarlo
            //apoyados en la protección que le pusimos a las propiedades y a su único campo
            ClaseConfiable.LeerSinCambiar(sherlock);
            //Veamos ahora si cambió algo
            Console.WriteLine("Valores después de pasarle el objeto a ClaseConfiable");
            ImprimirDetalles(sherlock);

            _separador.EscribirPie("Fin Ejemplo 1");
            #endregion


        }


        private static void ImprimirDetalles(Persona unaPersona)
        {
            Console.WriteLine("Nombre: {0}", unaPersona.Nombre + " " + unaPersona.Apellido);
            Console.WriteLine("Hogar: {0}", unaPersona.Hogar.Direccion + ", " + unaPersona.Hogar.Superficie.ToString() + " metros cuadrados");
        }

    }
    /// <summary>
    struct EncabezadoYPieConsola
    {
        public void EscribirEncabezado(string Titulo)
        {
            string encabezado = PrepararString(Titulo, '*');
            Console.WriteLine(encabezado);
            Console.WriteLine("");
        }

        public void EscribirPie(string Titulo)
        {
            string pie = PrepararString(Titulo, '-');
            Console.WriteLine("");
            Console.WriteLine(pie);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private string PrepararString(string Literal, char Caracter)
        {
            if (Literal.Length > 80)
                Literal = Literal.Substring(1, 80);
            int numeroDeAsteriscos = 80 - Literal.Length;
            string preparada = new string(Caracter, (int)(numeroDeAsteriscos / 2)) + Literal +
            new string(Caracter, (int)(numeroDeAsteriscos / 2));
            return preparada;
        }
    }



}