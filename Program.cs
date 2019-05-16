using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETTAR_AGUSTIN_EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero > 0\n");
         
            float num, resultado;
            num = float.Parse(Console.ReadLine());
            resultado = Math.Abs(num);
            Console.Write($"El valor absoluto es: {resultado}\n\n");
            Console.Write($"El cuadrado es: {Math.Pow(num, 2)}\n\n");
            Console.Write($"La raiz cuadrada es: {Math.Sqrt(Convert.ToSingle(num))}\n\n");
            Console.Write($"El seno es: {Math.Sin(Convert.ToSingle(num))}\n\n");
            Console.Write($"El coseno es: {Math.Cos(Convert.ToSingle(num))}\n\n");
            Console.Write($"La parte entera de un float: {Math.Round(num)}\n\n");
            Console.Write("Ingrese dos numeros \n");
            int[] n = { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            Console.Write($"El MAX ES : {n.Max()} y EL MIN ES : {n.Min()}");

            Console.ReadKey();
        }
    }
}
