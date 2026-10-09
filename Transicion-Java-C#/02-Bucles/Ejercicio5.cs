//Mostrar los múltiplos de 3 del 0 al 100

using System;

class Ejercicio5
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Múltiplos de 3 del 0 al 100.{MenuEjercicios.Reset}");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write($"{i} ");
            }

        }
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}