﻿// ==++==

using System;

namespace MecanismosDeSoloLectura
{
    class ClaseConfiable
    {
        public static void LeerSinCambiar(Persona unaPersona)
        {
            Console.WriteLine("Esta persona se llama: {0} {1} y vive en {2}",
                unaPersona.Nombre, unaPersona.Apellido, unaPersona.Hogar.Direccion);

            //Las siguientes dos líneas darían un error
            //unaPersona.Nombre = "Narciso";
            //unaPersona.Apellido = "Ibañez Menta";

            //Si bien no podemos cambiar la referencia (la linea siguiente no compila)
            //unaPersona.Hogar = new Casa("10 Downing Street", 2576);
            //Si puedo cambiar las propiedades de la referencia
            unaPersona.Hogar.Direccion = "10 Downing Street";
            unaPersona.Hogar.Superficie = 2576;

        }
    }
}