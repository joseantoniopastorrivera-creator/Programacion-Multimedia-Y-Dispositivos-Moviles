//Realizar una cuenta atrás que simule el lanzamiento de un cohete desde el 10. Usar
//Thread.Sleep(1000) de la librería System.Threading

using System;
using System.Threading;

public class Ejercicio0
{
    public static void Ejecutar()
    {
        Console.WriteLine(MenuEjercicios.Azul + "---INICIANDO SECUENCIA DE LANZAMIENTO---" + MenuEjercicios.Reset);
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"{i}...");
            //Pausa de 1 segundo entre cada número
            Thread.Sleep(1000);
        }
        Console.WriteLine(MenuEjercicios.Verde + "¡DESPEGUE!" + MenuEjercicios.Reset);

        Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();


    }
}