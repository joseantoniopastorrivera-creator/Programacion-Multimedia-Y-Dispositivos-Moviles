//Pedir al usuario que introduzca un número. Indicar si es par o impar.

using System;
class Ejercicio3Mejorado
{
    public static void Ejecutar()
    {
        int numero;
        bool esvalido;

        do
        {
            Console.WriteLine("Introduce un número entero: ");
            string entrada = Console.ReadLine();

            esvalido = int.TryParse(entrada, out numero);

            if (!esvalido)
            {
                Console.WriteLine("ERROR: Tiene que introducir un número entero.\n");
            }
        } while (!esvalido);

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número " + numero + " es par.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " es impar.");
        }
        Console.WriteLine();
        Console.WriteLine("Pulsa cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }

}