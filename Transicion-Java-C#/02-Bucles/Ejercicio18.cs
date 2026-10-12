//Genera y dibuja un tablero de 8x8 de 0's y 1's. En cada posición hay un 25% de
//probabilidades de que se pinte un 1 y un 75% de que se pinte un 0.

using System;

class Ejercicio18
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Tablero 8x8 (25% de unos y 75% de ceros).{MenuEjercicios.Reset}\n");

        Random rnd = new Random();
        int[,] tablero = new int[8, 8];

        // 1. Rellenar el tablero aplicando la probabilidad del 25%
        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                // Menor que 25 (25% de probabilidad) -> 1, de lo contrario -> 0
                tablero[fila, columna] = (rnd.Next(100) < 25) ? 1 : 0;
            }
        }

        // 2. Dibujar el tablero por pantalla de forma ordenada
        for (int fila = 0; fila < 8; fila++)
        {
            Console.Write("| ");
            for (int columna = 0; columna < 8; columna++)
            {
                // Si es 1 lo pintamos de un color para distinguirlo mejor, si es 0 normal
                if (tablero[fila, columna] == 1)
                {
                    Console.Write($"{MenuEjercicios.Verde}{tablero[fila, columna]} {MenuEjercicios.Reset}| ");
                }
                else
                {
                    Console.Write($"{tablero[fila, columna]} | ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}