/*
Problem 7 - 10001st Prime
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10,001st prime number?
===================================================================================================
Problema 7 - El primo número 10,001
Al enumerar los primeros seis números primos: 2, 3, 5, 7, 11 y 13, podemos ver que el sexto número primo es 13.
¿Cuál es el primo número 10,001?
*/

using System;
using System.Timers;
namespace Problema_7
{
    class Program
    {
        static bool EsPrimo(int NumeroIngresado)    //-> Funcion usada en el ejercicio 3
        {
            if (NumeroIngresado < 2)    //-> Nos aseguramos de solamente aceptar numeros naturales
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
                        return false;   //-> Cortamos el ciclo cuando no cumple
                    }
                }
                return true;
            }
        }
        static int Recorrido(int NumeroFinal)
        {
            int IndiceActual  = 0;
            int ContadorPrimo = 0;
            while (ContadorPrimo < NumeroFinal)
            {
                if (EsPrimo(IndiceActual))
                {
                    ContadorPrimo++;
                }
                if (ContadorPrimo == NumeroFinal)
                {
                    return IndiceActual;
                }
                IndiceActual++;
            }
           return IndiceActual;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Respuesta: " + Recorrido(10001));
        }
    }
}