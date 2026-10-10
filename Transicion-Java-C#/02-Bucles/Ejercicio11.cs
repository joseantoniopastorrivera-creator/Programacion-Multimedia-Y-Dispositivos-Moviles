using System;
using System.Collections.Generic;

class Ejercicio11
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa calcula la media y la varianza de una serie de números (0 para terminar).{MenuEjercicios.Reset}\n");

        List<double> numeros = new List<double>();
        double numero = -1;

        do
        {
            bool ok = false;

            // Validación de entrada para cada número sin usar break/continue en el flujo principal
            while (!ok)
            {
                Console.Write($"{MenuEjercicios.Azul}Introduce un número (0 para terminar): {MenuEjercicios.Reset}");
                string respuesta = Console.ReadLine();

                if (!double.TryParse(respuesta, out numero))
                {
                    Console.WriteLine($"{MenuEjercicios.Rojo}Error, introduce un número válido.\n{MenuEjercicios.Reset}");
                }
                else
                {
                    ok = true;
                }
            }

            // Si no es 0, lo guardamos en la lista para procesar los cálculos estadísticos
            if (numero != 0)
            {
                numeros.Add(numero);
            }

        } while (numero != 0);

        // Verificamos que se hayan introducido números antes de operar
        if (numeros.Count > 0)
        {
            // 1. Cálculo de la Media
            double suma = 0;
            foreach (double n in numeros)
            {
                suma += n;
            }
            double media = suma / numeros.Count;

            // 2. Cálculo de la Varianza (suma de las diferencias al cuadrado dividida entre N)
            double sumaDiferenciasCuadrado = 0;
            foreach (double n in numeros)
            {
                double diferencia = n - media;
                sumaDiferenciasCuadrado += (diferencia * diferencia);
            }
            double varianza = sumaDiferenciasCuadrado / numeros.Count;

            // 3. Salida por consola formateada
            Console.WriteLine($"\n{MenuEjercicios.Verde}--- RESULTADOS ESTADÍSTICOS ---{MenuEjercicios.Reset}");
            Console.WriteLine($"Números introducidos: {numeros.Count}");
            Console.WriteLine($"Media: {media:F2}");
            Console.WriteLine($"Varianza: {varianza:F2}");
        }
        else
        {
            Console.WriteLine($"\n{MenuEjercicios.Rojo}No se ha introducido ningún número para calcular.{MenuEjercicios.Reset}");
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}