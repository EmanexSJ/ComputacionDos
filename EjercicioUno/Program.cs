using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ejercicio 1) Escribir un algoritmo que permita asignar los numeros 10, 15 y 20 a tres
variables numericas. Calcule y muestre el promedio de ellas.
*/

namespace EjercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int variableUno, variableDos, VariableTres;
            variableUno = 10;
            variableDos = 15;
            VariableTres = 20;
            decimal promedio = (variableUno + variableDos + VariableTres) / 3;
            Console.WriteLine("VariableUno = 10\r\nVariableDos = 15,\r\nVariableTres = 20,");
            Console.WriteLine("El promedio de las 3 variables es: {0}", promedio);
            Console.WriteLine("\nPresione una tecla para salir.");
            Console.ReadLine();
        }
    }
}
