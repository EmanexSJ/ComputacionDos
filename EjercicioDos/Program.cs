using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Escribir un algortimo que permita leer un valor real que represente el radio de una
circunferencia. Calcule y muestre el perimetro y la superficie de la misma.
Recordar que P=2*PI*R y que S=PI*R*R;
*/
namespace EjercicioDos
{
    class Program
    {
        public const double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el valor del radio de la circunferencia");
            Console.WriteLine("Para poder calcular su Perimetro y Superficie");
            double radio = Convert.ToDouble(Console.ReadLine());
            double perimetro = 2 * Pi * radio;
            double superficie = Pi * radio * radio;
            Console.WriteLine("\n\n");
            Console.WriteLine("El perimetro de la circunferencia es: {0}",perimetro);
            Console.WriteLine("La superficie de la circunferencia es: {0}", superficie);

            //Usando la constante de la clase Math y Interpolacion de Cadenas
            Console.WriteLine("\nAhora los valores usando las funciones de la clase Math");

            Console.WriteLine($"El perimetro de la circunferencia es: " +
                $"{2 * Math.PI * radio:.00}");//muestra resultado con dos decimales
            Console.WriteLine($"La superficie de la circunferencia es: " +
                $"{Math.PI * Math.Pow(radio, 2):.00}");//muestra resultado con dos decimales

            Console.WriteLine("\nPresiones una Tecla para salir.");
            Console.ReadLine();
        }
    }
}
