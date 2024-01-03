using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_de__0__y_comentarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("Introduce el primer número para multiplicar");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número para multiplicar");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número para multiplicar");
            number3 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2 * number3;

            Console.WriteLine("Hola! esto es un comentario antes del resultado");
            Console.WriteLine();
            Console.WriteLine("Result: {0} x {1} x {2} = {3}", number1, number2, number3, result);

            Console.ReadLine();
            

        }
    }
}
