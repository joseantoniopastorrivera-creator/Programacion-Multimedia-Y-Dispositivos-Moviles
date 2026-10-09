//Pedir al usuario que introduzca 10 números. Indicar cuántos son mayores que cero y cuántos
//son menores que cero.

using System;
using System.Collections.Generic;
class Ejercicio8
{
    public static void Ejecutar()
    {
        List<int> positivos = new List<int>();
        List<int> negativos = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            int numero;
            while (true)
            {
                Console.Write($"Introduce el número {i}/10: ");
                string respuesta = Console.ReadLine();
                if (int.TryParse(respuesta, out numero))
                {
                    break;
                }
                Console.WriteLine("ERROR, introduce un número entero válido.\n");
            }
            if (numero > 0)
            {
                positivos.Add(numero);
            }
            else if (numero < 0)
            {
                negativos.Add(numero);
            }
        }
        Console.WriteLine("---RESULTADOS---");
        Console.WriteLine("Positivos: ");
        for (int i = 0; i < positivos.Count(); i++)
        {
            Console.Write($"{positivos[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("Negativos: ");
        for (int i = 0; i < negativos.Count(); i++)
        {
            Console.Write($"{negativos[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("---RESULTADOS ORDENADOS---");

        positivos.Sort();
        negativos.Sort();
        negativos.Reverse();
        Console.WriteLine("Positivos: ");
        for (int i = 0; i < positivos.Count(); i++)
        {
            Console.Write($"{positivos[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("Negativos: ");
        for (int i = 0; i < negativos.Count(); i++)
        {
            Console.Write($"{negativos[i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("Contador de números positivos: " + positivos.Count());
        Console.WriteLine("Contador de números negativos: " + negativos.Count());
        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}