//Mostrar los números del 100 al 0.

using System;

class Ejercicio4
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Números entre el 100 y el 0.{MenuEjercicios.Reset}");
        for (int i = 100; i >= 0; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}