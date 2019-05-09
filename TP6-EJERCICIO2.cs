using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Write("\n1. SUMAR\n");
                Console.Write("2. RESTART\n");
                Console.Write("3. MULTIPLICAR\n");
                Console.Write("4. DIVIDIR\n");
                Console.Write("0. SALIR\n");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                    {
                            int numeros, aux = 0, num;
                            int i;
                            Console.Write("Para dejar de sumar Ingrese 00\n");
                            Console.Write("\n\n");
                            num = int.Parse(Console.ReadLine());
                            aux = num;
                            while(num != 00)
                            { 
                                Console.Write("+ \n");
                                num = int.Parse(Console.ReadLine());
                                aux += num;
                            }
                            Console.Write("=");
                            Console.Write(aux);
                    }
                    break;
                    case 2:
                    {
                        int numeros, aux = 0, num;
                        int i;
                        Console.Write("Para dejar de Restar Ingrese 00\n");
                        Console.Write("\n\n");
                        num = int.Parse(Console.ReadLine());
                        aux = num;
                        while (num != 00)
                        {
                            Console.Write(" - \n");
                            num = int.Parse(Console.ReadLine());
                            aux -= num;
                        }
                        Console.Write("=");
                        Console.Write(aux);
                    }
                    break;
                    case 3:
                    {
                        int numeros, aux = 0, num;
                        int i;
                        Console.Write("Para dejar de Multiplicar Ingrese 1\n");
                        Console.Write("\n\n");
                        num = int.Parse(Console.ReadLine());
                        aux = num;
                        while (num != 1)
                        {
                            Console.Write(" * \n");
                            num = int.Parse(Console.ReadLine());
                            aux *= num;
                        }
                        Console.Write("=");
                        Console.Write(aux);
                    }
                    break;
                    case 4:
                    {
                        int A,B, aux = 0;
                        Console.Write("Ingrese Numero A\n");
                        A = int.Parse(Console.ReadLine());
                        Console.Write("Numero B, B != 0\n");
                        B = int.Parse(Console.ReadLine());
                        if (B == 0)
                        {
                            Console.Write("No se puede dividir en 0\n");
                            break;
                        }
                        else
                        {
                                aux = A / B;
                                Console.WriteLine("La division es : ");
                                Console.Write(aux);
                            }
                    }
                    break;
                }
            }
            while (opcion != 0);
            Console.ReadKey();
        }
    }
}
