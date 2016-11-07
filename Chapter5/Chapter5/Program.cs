﻿using System.Collections.Generic;

namespace Chapter5
{
    class Program
    {

        static void Main(string[] args)
        {


            //Intercambiar dos enteros usando la función genérica Swap
            //ver la dfinición más abajo
            int x = 2;
            int y = 3;
            System.Console.WriteLine("Inicialmente x es: {0}, e y es {1}", x.ToString(), y.ToString());
            //Esta función se puede llamar como se llama debajo o así: Swap<int>(ref x, ref y);
            Swap(ref x, ref y);
            System.Console.WriteLine("Ahora x es: {0}, e y es {1}", x.ToString(), y.ToString());
            //*****Fin del ejemplo de Swap**********

            //Ejemplo de uso de la función genérica 
            var accounts = new List<Account>()
            {
                new Account("Moe", 11.40M),
                new Account("Curly", 20.50M),
                new Account("Larry", 50.15M)
            };

            decimal sum = Algorithms.SimpleAccumulate(accounts);
            System.Console.WriteLine("Total: {0}", sum.ToString());

            int uno = 1;
            int? algo = uno;
            bool tieneValor = algo.HasValue;

        }

        //Funcion Generica para intercambiar dos Value Types cualesquiera 
        //(notar el atributo ref en los parametros)
        static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static void SwapV2<T>(ref T X, ref T Y) where T : struct
        {

        }
    }
}
