//Determinar si un número introducido por teclado es primo o no. (primo para testear:
//323780508946331)

using System;

class Ejercicio13
{
    public static void Ejecutar()
    {
        bool ok = false;
        long numero = 0;

        // 1. Validación usando long.TryParse para admitir números inmensos
        do
        {
            Console.WriteLine($"{MenuEjercicios.Azul}Este programa determina si un número es primo. Introduzca N: {MenuEjercicios.Reset}");
            string respuesta = Console.ReadLine();

            if (!long.TryParse(respuesta, out numero))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, introduzca un número entero válido.\n{MenuEjercicios.Reset}");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // 2. Lógica matemática 
        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false; // 0, 1 y los números negativos no se consideran primos
        }
        else
        {
            long limite = (long)Math.Sqrt(numero);

            // El bucle se detiene si llega al límite O si descubre que ya no es primo)
            for (long i = 2; i <= limite && esPrimo; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                }
            }
        }

        // 3. Salida de resultados
        Console.WriteLine($"\n{(esPrimo ? MenuEjercicios.Verde : MenuEjercicios.Rojo)}El número {numero} {(esPrimo ? "SÍ" : "NO")} es un número primo.{MenuEjercicios.Reset}");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}