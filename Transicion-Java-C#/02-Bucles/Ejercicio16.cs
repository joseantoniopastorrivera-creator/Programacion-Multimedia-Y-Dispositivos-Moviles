// El usuario introduce un texto y una vocal y el programa cambia todas las vocales del texto por la vocal introducida.

using System;

class Ejercicio16
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa cambia todas las vocales de un texto por la vocal que elijas.{MenuEjercicios.Reset}\n");

        bool okTexto = false;
        string frase = "";
        char vocalElegida = ' ';
        string diccionarioVocales = "aeiouáéíóúüAEIOUÁÉÍÓÚÜ";

        // 1. Validación del texto (que no esté vacío o sea solo espacios)
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce un texto: {MenuEjercicios.Reset}");
            frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, el texto no puede estar vacío.\n{MenuEjercicios.Reset}");
            }
            else
            {
                okTexto = true;
            }
        } while (!okTexto);

        // 2. Validación de la vocal (asegurar que es un solo carácter y es una vocal)
        bool okVocal = false;
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce la vocal por la que quieres sustituir el resto: {MenuEjercicios.Reset}");
            string respuestaVocal = Console.ReadLine();

            // Comprobamos que hayan metido exactamente 1 letra y que esa letra esté en nuestro diccionario de vocales
            if (respuestaVocal.Length == 1 && diccionarioVocales.Contains(respuestaVocal[0]))
            {
                vocalElegida = respuestaVocal[0];
                okVocal = true;
            }
            else
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, debes introducir una única vocal válida (a, e, i, o, u).\n{MenuEjercicios.Reset}");
            }
        } while (!okVocal);

        // 3. Reemplazo iterativo
        // Recorremos nuestro diccionario y reemplazamos cualquier ocurrencia por la vocal elegida.
        // Es vital reasignar el resultado a la variable 'frase' en cada pasada.
        foreach (char vocalDiccionario in diccionarioVocales)
        {
            frase = frase.Replace(vocalDiccionario, vocalElegida);
        }

        // 4. Salida del resultado
        Console.WriteLine($"\n{MenuEjercicios.Verde}El texto modificado es:{MenuEjercicios.Reset}");
        Console.WriteLine(frase);

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}