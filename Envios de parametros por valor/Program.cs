using System;

namespace Envios_de_parametros_por_valor
{
    class Program
    {
        static int x = 5; //Varible global

        static void Main(string[] args)
        {
            int y = 13;//variable local
            Console.WriteLine("\nx=" + x);

            //Llamada al metodo y envio por valor 

            Metodo(y);
            Console.WriteLine("\nx=" + x);
            Console.WriteLine("\ny=" + y);
            Console.ReadLine();
        }

        //El parametro "a" recibe el valor de "y"
        static void Metodo(int a)
        {
            a = a + 3;
            Console.WriteLine("\na=" + a);
            x = x * 2;
        }
    }
}
