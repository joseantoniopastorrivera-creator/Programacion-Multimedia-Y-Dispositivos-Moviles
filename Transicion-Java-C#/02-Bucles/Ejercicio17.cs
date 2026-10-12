//Calcular el factorial de un número introducido por teclado

using System;

class Ejercicio17
{
    public static void Ejecutar()
    {
        bool ok = false;
        int numero = 0;

        // 1. Validación para asegurar que es un número entero positivo o cero
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce un número entero para calcular su factorial: {MenuEjercicios.Reset}");
            string respuesta = Console.ReadLine();

            if (!int.TryParse(respuesta, out numero) || numero < 0)
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, introduce un número entero mayor o igual a 0.\n{MenuEjercicios.Reset}");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // 2. Cálculo del factorial usando long para evitar desbordamientos si N es grande
        long factorial = 1;

        for (int i = numero; i > 1; i--)
        {
            factorial *= i;
        }

        // 3. Resultado
        Console.WriteLine($"\n{MenuEjercicios.Verde}El factorial de {numero} es: {factorial}{MenuEjercicios.Reset}");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}