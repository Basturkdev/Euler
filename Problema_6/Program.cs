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
        static void RecorridoPotencia(int RangoN, int Potencia)
        {
            double AcumuladorCuadrado = 0;
            for (int i = 0; i <= RangoN; i++)
            {
                AcumuladorCuadrado += Math.Pow(i, Potencia);
            }
            Console.WriteLine(AcumuladorCuadrado);
        }
        static void SumaPotencia(int RangoN, int Potencia)
        {
            int SumatoriaCuadrado = 0;
            for (int i = 0; i <= RangoN; i++)
            {
                SumatoriaCuadrado += i;
            }
            double Resultado = Math.Pow(SumatoriaCuadrado, Potencia);
            Console.WriteLine(Resultado);
        }
        static void Main(string[] args)
        {
            RecorridoPotencia(10,2);
            SumaPotencia(10,2);
        }
    }
}