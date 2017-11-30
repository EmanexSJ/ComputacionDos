using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ejercicio 3) Escribir un algoritmo que permita leer un numero entero.
Calcule y muestre mediante un mensaje si el nro ingresado es par o impar.
*/

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un nro entero para determinar si es par o impar");
            
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

            Console.WriteLine("Presiones una Tecla para salir.");
            Console.ReadLine();
        }
    }
}
