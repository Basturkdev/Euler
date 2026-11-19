/*
Problem 3:
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143?

Problema 3:
Los factores primos de 13195 son 5, 7, 13 y 29.
¿Cuál es el mayor factor primo del número 600851475143?
*/

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Transactions;

/*
Se usaron funciones independientes para cada seccion del problema

EsPrimo:
Se encarga de validar si un numero es primo, tomando las medidas de precaucion
Cualquier numero menos a 2 automaticamente falso
2 -> True
3 en adelante se usa el recorrido for hasta la raiz cuadrada 
usando el modulo como condicion, de ser positivo el numero no es primo

Recorrido: Hace el recorrido hasta el numero X ingresado por el usuario.
*/

namespace Problema_3
{
    class Program
    {
        static bool EsPrimo(int NumeroIngresado)
        {
            if (NumeroIngresado < 2)
            {
                return false;
            }
            else if (NumeroIngresado == 2)
            {
                return true;
            }
            else
            {
                int Limite = (int)Math.Sqrt(NumeroIngresado);
                for (int i = 2; i <= Limite; i++)
                {
                    if (NumeroIngresado % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static long Recorrido(long NumeroFinal)
        {
            long Respuesta = 0;
            for (long i = 1; i < Math.Sqrt(NumeroFinal); i++)
            {
                if (EsPrimo((int)i) && (NumeroFinal % i == 0))
                {
                    Respuesta = i;
                }
            }
            return Respuesta;
        }
        static void  Main(string[] args)
        {
            Console.WriteLine("Respuesta: " + Recorrido(600851475143));
        }
    }
}