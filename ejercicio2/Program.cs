﻿using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int n,mayor = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    mayor = n;
                }else if (n > mayor)
                {
                    mayor = n;
                }
            }
            Console.WriteLine("El mayor de los números ingresados es: " + mayor);
        }
    }
}
