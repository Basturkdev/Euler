/*
Problem 5:
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

Problema 5:
2520 es el número más pequeño que puede dividirse entre cada uno de los números del 1 al 10 sin dejar residuo.
¿Cuál es el número positivo más pequeño que es divisible exactamente por todos los números del 1 al 20?
*/

using System;
namespace Problema_5
{
    class Program
    {
        static bool DivisionResidual(int Dividendo, int Divisor)
        {
            return (Dividendo % Divisor == 0);
        }
        static int RecorridoDivisor(int CantDivisores)
        {
            int IndiceRecorrido = 1;
            int AuxContador = 0;
            while (AuxContador < CantDivisores)
            {
                for (int i = 1; i < CantDivisores; i++)
                {
                    if (!DivisionResidual(IndiceRecorrido,i))
                    {
                        AuxContador = 0;
                        break;
                    }
                    AuxContador++;
                    if (AuxContador == CantDivisores)
                    {
                        break;
                    }
                }
                IndiceRecorrido++;
            }
            return IndiceRecorrido - 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Respuesta: " + RecorridoDivisor(10));
        }
    }
}