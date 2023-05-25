using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char operador;

            Console.WriteLine("Bienvenido a nuestro programa");
            Console.WriteLine("Este programa permite operaciones basicas sobre dos numeros");
            Console.WriteLine("------------------");

            Console.WriteLine("Introduzca el primer valor");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo valor");
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Indique la operacion (*,+,-,/)");
            operador = char.Parse(Console.ReadLine());
            //identifique el tipo de operacion arealizar haciendo uso del condicional if*/
            if (operador == '*') ;
            {
                Console.WriteLine("La multipliacion es de: " + (num1 * num2));
            }
            if (operador == '+') ;
            {
                Console.WriteLine("La suma es de: " + (num1 + num2));
            }
            if (operador == '-') ;
            {
                Console.WriteLine("La resta es de:" + (num1 - num2));
            }
            if (operador == '/') ;
            {   Console.WriteLine("La division es de:" + (num1 / num2));

            }
            Console.ReadLine();

            // Enviamos un mensaje de bienvenida y una descripcion del programa


        }
    }
}
