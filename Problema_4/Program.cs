/*
Problem 4: Largest Palindrome Product
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.

Problema 4: El mayor producto palíndromo
Un número palíndromo se lee igual de izquierda a derecha que de derecha a izquierda.
El mayor palíndromo obtenido del producto de dos números de 2 cifras es 9009 = 91 × 99.
Encuentra el mayor palíndromo obtenido del producto de dos números de 3 cifras.

*/

using System;
namespace Problema_4
{
    class Program
    {
        static bool EsPalindromo(int Palindromo)
        {
            if (Palindromo == 0)
            {
                return false;
            }
            string AuxString = Palindromo.ToString();
            char[] ArrayNum = AuxString.ToCharArray();
            Array.Reverse(ArrayNum);
            string NumInvertido = new string(ArrayNum);
            return string.Equals(AuxString, NumInvertido);
        }

        //static bool EsMayor()

        static void RecorridoPalindromo(int NumeroF) // -> 999
        {
            int IndiceGeneral = 1;
            int AuxVar = 0;
            int Respuesta = 0;
            while (IndiceGeneral < NumeroF)
            {
                int AuxIdx = IndiceGeneral;
                for (int i = AuxIdx; i <= NumeroF; i++)
                {
                    if (EsPalindromo(IndiceGeneral * i))
                    {
                        AuxVar = IndiceGeneral*i; //-> 8448, Respuesta = 0
                        //hacer bloque que mida el mayor.
                        if (Respuesta < AuxVar)
                        {
                            Respuesta = AuxVar;
                        }
                    }
                }
                IndiceGeneral++;
            }
            Console.WriteLine("Resultado:" + Respuesta);
        }

        //
        static void Main(string[] args)
        {
            /*
            //pruebas es palindromo
            // 5 pruebas positivas
            Console.WriteLine(EsPalindromo(9009));    // True
            Console.WriteLine(EsPalindromo(1221));    // True
            Console.WriteLine(EsPalindromo(8888));    // True
            Console.WriteLine(EsPalindromo(12321));   // True
            Console.WriteLine(EsPalindromo(45654));   // True

            // 5 pruebas negativas
            Console.WriteLine(EsPalindromo(1234));    // False
            Console.WriteLine(EsPalindromo(8856));    // False
            Console.WriteLine(EsPalindromo(12345));   // False
            Console.WriteLine(EsPalindromo(56789));   // False
            Console.WriteLine(EsPalindromo(13195));   // False
            */

            RecorridoPalindromo(999);

            //La funcion se puede generalizar bastante y hacerlas mas interesante.

        }
    }
}