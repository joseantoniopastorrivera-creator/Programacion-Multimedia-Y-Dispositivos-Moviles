//Programa que lee un texto y lo escribe al revés.

using System;

class Ejercicio20
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa lee un texto y lo escribe al revés.{MenuEjercicios.Reset}\n");

        bool ok = false;
        string texto = "";

        // 1. Validación para asegurar que el usuario no introduce una cadena vacía
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce un texto: {MenuEjercicios.Reset}");
            texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, el texto no puede estar vacío.\n{MenuEjercicios.Reset}");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // 2. Inversión del texto
        // Convertimos la cadena en un array de caracteres, le aplicamos Array.Reverse y creamos un nuevo string.
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        string textoInvertido = new string(caracteres);

        // 3. Salida de resultados
        Console.WriteLine($"\n{MenuEjercicios.Verde}El texto al revés es:{MenuEjercicios.Reset}");
        Console.WriteLine(textoInvertido);

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}