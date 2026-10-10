// Programa que solicita un número por teclado, y a continuación muestra por pantalla la lista de sus divisores.

using System;
using System.Collections.Generic;

class Ejercicio12
{
    public static void Ejecutar()
    {
        bool ok = false;
        int numero = 0;

        // 1. Validación de entrada limpia con do-while
        do
        {
            Console.WriteLine($"{MenuEjercicios.Azul}Este programa muestra la lista de divisores de un número. Introduzca N: {MenuEjercicios.Reset}");
            string respuesta = Console.ReadLine();

            if (!int.TryParse(respuesta, out numero))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, introduzca un número entero válido.\n{MenuEjercicios.Reset}");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        if (numero == 0)
        {
            Console.WriteLine($"{MenuEjercicios.Rojo}El número 0 tiene infinitos divisores.{MenuEjercicios.Reset}\n");
        }
        else
        {
            List<int> divisores = new List<int>();
            int valorAbsoluto = Math.Abs(numero);

            // 2. Calculamos el límite (la raíz cuadrada)
            int limite = (int)Math.Sqrt(valorAbsoluto);

            for (int i = 1; i <= limite; i++)
            {
                if (valorAbsoluto % i == 0)
                {
                    divisores.Add(i); // Añadimos el divisor que hemos encontrado (el pequeño)

                    // Calculamos y añadimos su "pareja" (el grande), evitando duplicados si el número es un cuadrado perfecto (ej. 25 -> 5 y 5)
                    int par = valorAbsoluto / i;
                    if (par != i)
                    {
                        divisores.Add(par);
                    }
                }
            }

            // 3. Al meter los números en pares (uno pequeño y uno muy grande), la lista queda desordenada. La ordenamos nativamente.
            divisores.Sort();

            Console.WriteLine($"\n{MenuEjercicios.Verde}Los divisores de {numero} son:{MenuEjercicios.Reset}");
            Console.WriteLine(string.Join(", ", divisores));
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}