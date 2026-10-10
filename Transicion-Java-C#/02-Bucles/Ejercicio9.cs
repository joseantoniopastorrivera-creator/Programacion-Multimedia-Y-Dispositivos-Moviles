//Mostrar los números del 1 hasta N.


using System;

class Ejercicio9
{
    public static void Ejecutar()
    {
        bool ok = false;
        int numero = 0;
        do
        {
            Console.WriteLine($"{MenuEjercicios.Azul}Este programa muestra los números desde 1 a N, introduzca N: {MenuEjercicios.Reset}");
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
            for (int i = 1; i <= numero; i++)
            {
                Console.Write($"{i} ");
            }
        }
        else
        {
            for (int i = 1; i >= numero; i--)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}