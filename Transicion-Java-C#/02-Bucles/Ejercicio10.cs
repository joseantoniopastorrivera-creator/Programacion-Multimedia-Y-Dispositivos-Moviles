using System;

class Ejercicio10
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa pide números hasta introducir 0 y cuenta positivos y negativos.{MenuEjercicios.Reset}\n");

        int numero = -1;
        int contPositivos = 0;
        int contNegativos = 0;

        do
        {
            bool ok = false;

            // Validación de entrada para cada número
            while (!ok)
            {
                Console.Write($"{MenuEjercicios.Azul}Introduce un número (0 para terminar): {MenuEjercicios.Reset}");
                string respuesta = Console.ReadLine();

                if (!int.TryParse(respuesta, out numero))
                {
                    Console.WriteLine($"{MenuEjercicios.Rojo}Error, introduce un número entero válido.\n{MenuEjercicios.Reset}");
                }
                else
                {
                    ok = true;
                }
            }

            // Si no es 0, evaluamos si es positivo o negativo
            if (numero > 0)
            {
                contPositivos++;
            }
            else if (numero < 0)
            {
                contNegativos++;
            }

        } while (numero != 0);

        // Mostrar resultados finales
        Console.WriteLine($"\n{MenuEjercicios.Verde}--- RESULTADOS ---{MenuEjercicios.Reset}");
        Console.WriteLine($"Números positivos introducidos: {contPositivos}");
        Console.WriteLine($"Números negativos introducidos: {contNegativos}");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}