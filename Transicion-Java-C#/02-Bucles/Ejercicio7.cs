//Suma de los números desde 0 hasta N

using System;

class Ejercicio7
{
    public static void Ejecutar()
    {
        bool ok = false;
        int numero = 0;
        int suma = 0;
        do
        {
            Console.WriteLine($"{MenuEjercicios.Azul}Este programa suma los números desde 0 a N, introduzca N: {MenuEjercicios.Reset}");
            string respuesta = Console.ReadLine();
            if (!int.TryParse(respuesta, out numero))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error, introduzca un número entero.{MenuEjercicios.Rojo}\n");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        if (numero >= 0)
        {
            for (int i = 0; i <= numero; i++)
            {
                suma += i;
            }
        }
        else
        {
            for (int i = numero; i < 0; i++)
            {
                suma += i;
            }
        }
        Console.WriteLine($"{MenuEjercicios.Verde}La suma todos los números desde {(numero >= 0 ? $"0 hasta {numero}" : $"{numero} hasta 0")} es: {suma}.{MenuEjercicios.Reset}");
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}