// Mostrar los números primos entre el 2 y 100.

using System;
using System.Collections.Generic;

class Ejercicio14
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa calcula y muestra los números primos entre el 2 y el 100.{MenuEjercicios.Reset}\n");

        List<int> primos = new List<int>();

        // 1. Bucle exterior: recorremos todos los números candidatos desde el 2 hasta el 100
        for (int numero = 2; numero <= 100; numero++)
        {
            bool esPrimo = true;

            // 2. Lógica optimizada: calculamos el límite (raíz cuadrada) para el número actual
            int limite = (int)Math.Sqrt(numero);

            // 3. Bucle interior: comprobamos si el número actual tiene divisores
            // Se detiene si llega al límite O si descubre que ya no es primo (sin usar break)
            for (int i = 2; i <= limite && esPrimo; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                }
            }

            // Si después de pasar por el motor de evaluación la bandera sigue siendo true, es primo
            if (esPrimo)
            {
                primos.Add(numero);
            }
        }

        // 4. Salida de resultados
        Console.WriteLine($"{MenuEjercicios.Verde}Los números primos entre 2 y 100 son:{MenuEjercicios.Reset}");
        Console.WriteLine(string.Join(", ", primos));

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}