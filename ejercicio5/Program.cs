using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            int n, maxpar = 0,minimpar = 0;
            bool bi = false,bp = false;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    if (!bp)
                    {
                        maxpar = n;
                        bp = true;
                    }else if (n > maxpar)
                    {
                        maxpar = n;
                    }
                }else
                {
                    if (!bi)
                    {
                        minimpar = n;
                        bi = true;
                    }else if (n < minimpar)
                    {
                        minimpar = n;
                    }
                }
                
            }
            Console.WriteLine("El valor máximo par ingresado es " + maxpar + " y el valor mínimo impar ingresado es " + minimpar);
            // también se puede hacer con contador de pares e impares
        }
    }
}
