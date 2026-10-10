// Escribir un programa que calcule los cuadrados y cubos de los números enteros 0 al 10 y que imprima los valores resultantes en forma de tabla.

using System;

class Ejercicio8
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa calcula los cuadrados y cubos del 0 al 10 en forma de tabla.{MenuEjercicios.Reset}\n");

        // Definimos la línea separadora usando new string como vimos antes
        string separador = "-------------------";

        Console.WriteLine(separador);

        for (int i = 0; i <= 10; i++)
        {
            int cuadrado = i * i;
            int cubo = i * i * i;

            // Imprimimos la fila con formato de tabla y un ancho fijo para evitar desalineaciones
            Console.WriteLine($"| {i,2} | {cuadrado,4} | {cubo,5} |");
            Console.WriteLine(separador);
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}