using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miconsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Numero a invertir");
            int a;
            int aux;
            int i;
            a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.Write("Este numero no se puede invertir\n");
                Console.ReadKey();
            }
            else
            {
                aux = a;
                int aux2;
                while (aux != 0)
                {
                    aux2 = aux % 10;
                    Console.Write(aux2);
                    aux = aux / 10;
                }
            }  
        }
    }
}
