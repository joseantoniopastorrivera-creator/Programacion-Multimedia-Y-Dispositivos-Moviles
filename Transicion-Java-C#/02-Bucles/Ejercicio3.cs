//Mostrar los números del 0 al 100.

using System;

class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Números entre el 0 y el 100.{MenuEjercicios.Reset}");
        for (int i = 0; i <= 100; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}