using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ejercicio 4) Escribir un algoritmo que permita leer cinco valores numericos reales (con decimales)
Calcule y muestre la suma de esos cinco valores.
*/

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba cinco valores reales (pueden contener decimales)");
            Console.WriteLine("El numero debe estar dentro del rango:");
            Console.WriteLine($"{double.MinValue} y {double.MaxValue}\n");

            Console.WriteLine("Ingrese el 1er nro:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el 2do nro:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el 3er nro:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el 4to nro:");
            double n4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el 5to nro:");
            double n5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La suma de los 5 numeros es: {0}",
                n1 + n2 + n3 + n4 + n5);

            Console.WriteLine("Presiones una tecla para salir");
            Console.ReadLine();           
        }
    }
}
