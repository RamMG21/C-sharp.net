using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Envio_de_parametros_por_refrencia
{
    class Program
    {
        static int x = 5; //Variable global
        static void Main(string[] args)
        {
            int y = 13;//Variable local
            Console.WriteLine("\nx=" + x);
            //Llamada al metodo y envio por referencia
            Metodo(ref y);

            Console.WriteLine("\nx=" + x);
            Console.WriteLine("\ny=" + y);
            Console.ReadLine();

        }
        //El parametro "a" recibe la ref. de "y"
        static void Metodo(ref int a)
        {
            a = a + 3;
            Console.WriteLine("\na=" + a);
            x = x * 2;
        }
    }
}
