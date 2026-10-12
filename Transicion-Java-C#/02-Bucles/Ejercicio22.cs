//Programa que determina si un número es capicúa.

using System;

class Ejercicio22
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa determina si un número es capicúa.{MenuEjercicios.Reset}\n");

        bool ok = false;
        long numeroOriginal = 0;

        // 1. Validación de entrada para números enteros positivos
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce un número entero positivo: {MenuEjercicios.Reset}");
            string entrada = Console.ReadLine();

            // Verificamos que sea un número válido y que no sea negativo
            if (long.TryParse(entrada.Trim(), out numeroOriginal) && numeroOriginal >= 0)
            {
                ok = true;
            }
            else
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error: Debes introducir un número entero positivo válido.{MenuEjercicios.Reset}\n");
            }
        } while (!ok);

        // 2. Proceso matemático para invertir el número
        long numeroTemporal = numeroOriginal;
        long numeroInvertido = 0;

        // Bucle que descompone el número dígito a dígito
        while (numeroTemporal > 0)
        {
            // Extraemos el último dígito de la derecha
            long digito = numeroTemporal % 10;

            // Desplazamos lo que ya tenemos a la izquierda (multiplicando por 10) y sumamos el nuevo dígito
            numeroInvertido = (numeroInvertido * 10) + digito;

            // Eliminamos el último dígito del número temporal (división entera)
            numeroTemporal /= 10;
        }

        // 3. Salida de resultados y comparación final
        if (numeroOriginal == numeroInvertido)
        {
            Console.WriteLine($"\n{MenuEjercicios.Verde}¡El número {numeroOriginal} ES capicúa!{MenuEjercicios.Reset}");
        }
        else
        {
            Console.WriteLine($"\n{MenuEjercicios.Rojo}El número {numeroOriginal} NO es capicúa. Al revés se lee {numeroInvertido}.{MenuEjercicios.Reset}");
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}