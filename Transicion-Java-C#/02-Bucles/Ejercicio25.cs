// El usuario introduce n números. Cuando escribe 0 el programa escribe los números en
//sentido contrario y termina.

using System;
using System.Collections.Generic;

class Ejercicio25
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa lee números hasta introducir 0 y los muestra en orden inverso.{MenuEjercicios.Reset}\n");

        List<int> numeros = new List<int>();
        int numeroIntroducido = -1; // Inicializamos a un valor distinto de 0

        // 1. Bucle de lectura de datos
        do
        {
            Console.Write("Introduce un número (0 para terminar): ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada.Trim(), out numeroIntroducido))
            {
                // Solo añadimos a la lista si el número no es el 0 que finaliza el bucle
                if (numeroIntroducido != 0)
                {
                    numeros.Add(numeroIntroducido);
                }
            }
            else
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error: Entrada no válida. Introduce un número entero.{MenuEjercicios.Reset}");
            }

        } while (numeroIntroducido != 0);

        // 2. Comprobación y salida de resultados en orden inverso
        Console.WriteLine($"\n{MenuEjercicios.Verde}Números introducidos en sentido contrario:{MenuEjercicios.Reset}");

        if (numeros.Count == 0)
        {
            Console.WriteLine("No se introdujo ningún número antes de finalizar.");
        }
        else
        {
            // Bucle for regresivo para recorrer la lista de atrás hacia adelante
            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                // Imprimimos el número. Si no es el último en imprimirse, añadimos una coma y espacio.
                Console.Write(numeros[i] + (i > 0 ? ", " : ""));
            }
            Console.WriteLine(); // Salto de línea final
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}