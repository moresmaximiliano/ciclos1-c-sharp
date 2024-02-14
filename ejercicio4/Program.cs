using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  
            // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            int n,con = 0;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            for (int x = 0; x < n; x++)
            {
                if (n % (x + 1) == 0)
                    con ++;
            }
                if (con == 2)
                    Console.WriteLine("El número es primo.");
                else
                    Console.WriteLine("El número no es primo.");
                
        } 
    }
}   

