/*
Problem 1
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.

Problema 1
Si enumeramos todos los números naturales menores que 10 que son múltiplos de 3 o de 5, obtenemos 3, 5, 6 y 9. La suma de estos múltiplos es 23.
Encuentra la suma de todos los múltiplos de 3 o de 5 menores que 1000.
*/
/*
Planteo: 
EsMultiplo:
para identificar que numero cumple los requisitos pedidos
en este caso la clave de la funcion es el "OR" por logica booleana, siendo verdadero en los 3 casos en que 
el numero "i" es un multiplo:
    1. es divisible entre 3     -> True
    2. es divisible entre 5.    -> True
    3. es divisible entre 3 y 5 -> True

Recorrido:
Hace un recorrido general hasta el numero ingresado.
*/

namespace Problema_1
{
    class Program
    {

        static bool EsMultiplo(int Numero)
        {
            if ((Numero % 3 == 0) || (Numero % 5 == 0)) 
            {
                return true;
            }
            return false;
        }
        static int Recorrido(int NumeroFinal)
        {
            int Resultado = 0;
            for (int i = 0; i < NumeroFinal; i++)
            {
                if (EsMultiplo(i))
                {
                    Resultado += i;
                }
            }
            return Resultado;
        }
        static void Main(string[] args)
        {
            int Resultado = Recorrido(1000);
            Console.WriteLine("Respuesta: " + Resultado);
        }
    }
}