//Programa que lee una ristra de números separados por comas y escribe sus cuadrados
//separados también por comas.

using System;
using System.Collections.Generic;

class Ejercicio19
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa lee una ristra de números separados por comas y muestra sus cuadrados.{MenuEjercicios.Reset}\n");

        bool ok = false;
        string entrada = "";

        // 1. Validación para asegurar que el usuario no introduce una cadena vacía
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce números separados por comas (ej: 2, 4, 5.5): {MenuEjercicios.Reset}");
            entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, la entrada no puede estar vacía.\n{MenuEjercicios.Reset}");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // 2. Procesamiento de la ristra tolerante a errores por posición
        string[] partes = entrada.Split(',');
        List<string> resultados = new List<string>();

        foreach (string parte in partes)
        {
            // Intentamos convertir cada fragmento a número
            if (double.TryParse(parte.Trim(), out double numero))
            {
                double cuadrado = numero * numero;
                resultados.Add(cuadrado.ToString()); // Guardamos el cuadrado como texto
            }
            else
            {
                resultados.Add("false"); // Si hay una letra o símbolo, indicamos false en su hueco
            }
        }

        // Salida de resultados unida por comas
        Console.WriteLine($"\n{MenuEjercicios.Verde}Resultados procesados:{MenuEjercicios.Reset}");
        Console.WriteLine(string.Join(", ", resultados));
    }
}