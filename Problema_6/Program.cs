/*
Problem 6 - Sum Square Difference
The sum of the squares of the first ten natural numbers is
1² + 2² + ... + 10² = 385
The square of the sum of the first ten natural numbers is
(1 + 2 + ... + 10)² = 55² = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is
3025 - 385 = 2640
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
================================================================================================================================
Problema 6 - Diferencia entre la suma y los cuadrados
La suma de los cuadrados de los primeros diez números naturales es
1² + 2² + ... + 10² = 385
El cuadrado de la suma de los primeros diez números naturales es
(1 + 2 + ... + 10)² = 55² = 3025
Por lo tanto, la diferencia entre la suma de los cuadrados de los primeros diez números naturales y el cuadrado de la suma es
3025 - 385 = 2640
Encuentra la diferencia entre la suma de los cuadrados de los primeros cien números naturales y el cuadrado de la suma.
*/

using System;
namespace Problema_6
{
    class Program
    {
        static int RecorridoPotencia(int RangoN, int Potencia)  //-> Funciona para diferentes potencias y N-Rango
        {
            double AcumuladorCuadrado = 0;
            for (int i = 0; i <= RangoN; i++)   
            {
                AcumuladorCuadrado += Math.Pow(i, Potencia);    //-> se puede evitar usar Math, usando X += i * i
            }
            int ResultadoRecorrido = (int)AcumuladorCuadrado;   //-> Se castea de double a int
            return ResultadoRecorrido;
        }
        static int SumaPotencia(int RangoN, int Potencia)
        {
            int Sumatoria = 0;
            for (int i = 0; i <= RangoN; i++)
            {
                Sumatoria += i;
            }
            double SumatoriaCuadrado = Math.Pow(Sumatoria, Potencia);
            return (int)SumatoriaCuadrado;
        }
        static int Diferencia(int Recorrido, int Sumatoria)
        {
            return Sumatoria - Recorrido;
        }
        static void Main(string[] args)
        {
            int X = RecorridoPotencia(100,2);
            int Y = SumaPotencia(100,2);
            Console.WriteLine("Diferencia: " + Diferencia(X,Y));
        }
    }
}