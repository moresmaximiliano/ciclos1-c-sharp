using System;

namespace ejemplowhile
{
    class Program
    {
        static void Main(string[] args)
        {
           // Cargar números hasta que se ingrese un 0, y contar el número de cargas hechas
           int n,con = 0;
           Console.WriteLine("Ingrese un número:");
           n = int.Parse(Console.ReadLine());
           while (n != 0){
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                con ++;
           }
           Console.WriteLine("El número de ingesos fue de " + con);
        }
    }
}
