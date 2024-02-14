using System;

namespace ejemplodowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cargar números hasta que se ingrese un 0, y contar el número de cargas incluyendo el 0
            int n,con = 0;
            do{
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                con ++;
            }while (n != 0);
            Console.WriteLine("El número de ingresos fue de " + con);
        }
    }
}
