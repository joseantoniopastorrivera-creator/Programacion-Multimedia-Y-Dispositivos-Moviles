//Mostrar los múltiplos de 3 y de 2 entre 0 y 100.

using System;

class Ejercicio6
{
    public static void Ejecutar()
    {
        Console.WriteLine($"Múltiplos de {MenuEjercicios.Azul}3{MenuEjercicios.Reset}, de {MenuEjercicios.Verde}2{MenuEjercicios.Reset} o de {MenuEjercicios.Rojo}ambos{MenuEjercicios.Reset} del 0 al 100.{MenuEjercicios.Reset}");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                Console.Write($"{MenuEjercicios.Rojo}{i}{MenuEjercicios.Reset} ");
            }
            else if (i % 3 == 0)
            {
                Console.Write($"{MenuEjercicios.Azul}{i}{MenuEjercicios.Reset} ");
            }
            else if (i % 2 == 0)
            {
                Console.Write($"{MenuEjercicios.Verde}{i}{MenuEjercicios.Reset} ");
            }

        }
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}