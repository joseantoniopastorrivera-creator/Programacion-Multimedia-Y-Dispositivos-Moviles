//Pedir al usuario que introduzca un número. Indicar si es par o impar.

class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.WriteLine("Introduzca un número: ");
        int respuesta = Convert.ToInt32(Console.ReadLine());

        if (respuesta % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
        Console.WriteLine();
        Console.WriteLine("Pulse una tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}