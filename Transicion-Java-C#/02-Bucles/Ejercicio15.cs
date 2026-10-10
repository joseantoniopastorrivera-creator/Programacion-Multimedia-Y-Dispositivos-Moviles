// El usuario introduce una frase y se muestra cuántas vocales tiene.

using System;

class Ejercicio15
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa cuenta el número de vocales en una frase.{MenuEjercicios.Reset}\n");

        bool ok = false;
        string frase = "";

        // 1. Validación para asegurar que el usuario no introduce una cadena vacía
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce una frase: {MenuEjercicios.Reset}");
            frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, la frase no puede estar vacía.\n{MenuEjercicios.Reset}");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // 2. Definimos nuestro "diccionario" de vocales (incluyendo tildes y mayúsculas)
        string vocales = "aeiouáéíóúüAEIOUÁÉÍÓÚÜ";
        int contadorVocales = 0;

        // 3. Recorremos la frase letra por letra
        for (int i = 0; i < frase.Length; i++)
        {
            // Si el carácter actual de la frase existe dentro de nuestra cadena de vocales, sumamos 1
            if (vocales.Contains(frase[i]))
            {
                contadorVocales++;
            }
        }

        // 4. Salida formateada
        Console.WriteLine($"\n{MenuEjercicios.Verde}La frase contiene {contadorVocales} vocales.{MenuEjercicios.Reset}");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}