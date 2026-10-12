// Programa que determina si un texto es palíndromo

using System;

class Ejercicio23
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa determina si un texto es un palíndromo.{MenuEjercicios.Reset}\n");

        bool ok = false;
        string textoOriginal = "";

        // 1. Validación de entrada
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce un texto o frase: {MenuEjercicios.Reset}");
            textoOriginal = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textoOriginal))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error: El texto no puede estar vacío.{MenuEjercicios.Reset}\n");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // 2. Limpieza y normalización del texto
        // Reemplazamos todos los espacios por "nada" y convertimos a minúsculas
        string textoLimpio = textoOriginal.Replace(" ", "").ToLower();

        // 3. Comprobación de palíndromo (Técnica de los dos punteros)
        bool esPalindromo = true;
        int izquierda = 0; // Apunta al primer carácter
        int derecha = textoLimpio.Length - 1; // Apunta al último carácter

        while (izquierda < derecha)
        {
            // Comparamos los extremos hacia el centro
            if (textoLimpio[izquierda] != textoLimpio[derecha])
            {
                esPalindromo = false;
                break; // Si un solo carácter no coincide, detenemos el bucle
            }

            // Movemos los punteros hacia el centro
            izquierda++;
            derecha--;
        }

        // 4. Salida de resultados
        if (esPalindromo)
        {
            Console.WriteLine($"\n{MenuEjercicios.Verde}¡Correcto! El texto introducido ES un palíndromo.{MenuEjercicios.Reset}");
        }
        else
        {
            Console.WriteLine($"\n{MenuEjercicios.Rojo}El texto introducido NO es un palíndromo.{MenuEjercicios.Reset}");
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}