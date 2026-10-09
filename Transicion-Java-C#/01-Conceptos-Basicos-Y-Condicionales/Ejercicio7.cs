//Pedir al usuario que introduzca un número. Indicar si es divisible por 2, 3, 5, 7 y 11.

class Ejercicio7
{
    public static void Ejecutar()
    {
        int numero = 0;
        bool esValido = false, esDivisible = false;
        do
        {
            Console.WriteLine("Introduce un número: ");
            string respuesta = Console.ReadLine();
            esValido = int.TryParse(respuesta, out numero);
            if (!esValido)
            {
                Console.WriteLine("ERROR, introduzca un número entero.");
            }
        } while (!esValido);

        Console.WriteLine("El número " + numero + " es divisile por: ");
        if (numero % 2 == 0)
        {
            Console.WriteLine(" -2");
            esDivisible = true;
        }
        if (numero % 3 == 0)
        {
            Console.WriteLine(" -3");
            esDivisible = true;
        }
        if (numero % 5 == 0)
        {
            Console.WriteLine(" -5");
            esDivisible = true;
        }
        if (numero % 7 == 0)
        {
            Console.WriteLine(" -7");
            esDivisible = true;
        }
        if (numero % 11 == 0)
        {
            Console.WriteLine(" -11");
            esDivisible = true;
        }
        if (!esDivisible)
        {
            Console.WriteLine("El número no es divisible por 2, 3, 5, 7 u 11.");
        }
        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}