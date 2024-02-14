using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular el promedio de 5 notas ingresadas
            int n,suma = 0;
            float promedio;
            for(int x = 0; x < 5; x ++){
                Console.WriteLine("Ingrese una nota:");
                n = int.Parse(Console.ReadLine());
                suma += n;
            }
            promedio = suma / 5F;
            Console.WriteLine("El promedio de las notas es igual a "  + promedio.ToString("0.00"));
        }
    }
}
