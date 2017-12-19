using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ejercicio 5
Escribir un algoritmo que permita leer la cantidad de horas trabajadas por un empleado y
precio de la hora de trabajo. Calcular y mostrar el salario que le corresponde cobrar a ese
empleado (recordar que Salario = CantHoras*PrecioHora).
*/

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de horas trabajadas por el empleado.");
            int cantHoras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio por hora trabajada.");
            decimal precioHora = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("El Salario que le corresponde al empleado es:");
            decimal salario = cantHoras * precioHora;
            Console.WriteLine("Salario: {0}", salario);

            Console.WriteLine("\nPresiones una tecla para salir.");
            Console.ReadLine();
        }
    }
}
