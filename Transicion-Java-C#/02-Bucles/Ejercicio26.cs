//Programa que recibe un texto y cambia las aes por 4, las es por 3, las íes por 1 y las oes por 0.

using System;

class Ejercicio26
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa cambia las vocales (a, e, i, o) por números (4, 3, 1, 0).{MenuEjercicios.Reset}\n");

        bool ok = false;
        string textoOriginal = "";

        // 1. Validación inicial con cláusula de guarda para la entrada
        do
        {
            Console.Write("Introduce el texto a codificar: ");
            textoOriginal = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textoOriginal))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error: El texto no puede estar vacío.{MenuEjercicios.Reset}\n");
                continue; // Salida anticipada del intento actual
            }

            ok = true;

        } while (!ok);

        // 2. Procesamiento: Reemplazo en cascada (soporta minúsculas y mayúsculas)
        string textoCodificado = textoOriginal
            .Replace("a", "4").Replace("A", "4")
            .Replace("á", "4").Replace("Á", "4") // Soporte ortográfico profesional
            .Replace("e", "3").Replace("E", "3")
            .Replace("é", "3").Replace("É", "3")
            .Replace("i", "1").Replace("I", "1")
            .Replace("í", "1").Replace("Í", "1")
            .Replace("o", "0").Replace("O", "0")
            .Replace("ó", "0").Replace("Ó", "0");

        // 3. Salida de resultados
        Console.WriteLine($"\n{MenuEjercicios.Verde}Texto codificado resultante:{MenuEjercicios.Reset}");
        Console.WriteLine(textoCodificado);

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}