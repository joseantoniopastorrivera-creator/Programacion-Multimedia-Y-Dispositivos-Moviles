//Mostrar los números pares entre 0 y 100.

using System;

class Ejercicio2
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Números pares entre 0 y 100.{MenuEjercicios.Reset}");
        for (int i = 2; i < 101; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }

        }
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}