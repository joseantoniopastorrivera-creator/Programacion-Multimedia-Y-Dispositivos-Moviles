//Pedir al usuario que introduzca un número. Mostrar la raíz cuadrada del mismo. El número
//debe ser mayor que cero, en caso contrario debe aparecer el mensaje "ERROR. Los números
//negativos no tienen raíz cuadrada real.

using System;
using System.Globalization;
class Ejercicio1
{
    public static void Ejecutar()
    {
        Console.WriteLine("Introduce un número: ");
        double respuesta = Convert.ToDouble(Console.ReadLine());

        while (respuesta < 0)
        {
            Console.WriteLine("Introduzca un número mayor o igual que cero: ");
            respuesta = Convert.ToDouble(Console.ReadLine());
        }
        double raiz = Math.Sqrt(respuesta);
        Console.WriteLine("La raiz cuadrada del número es: " + raiz);
        Console.WriteLine();
        Console.WriteLine("Pulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}
