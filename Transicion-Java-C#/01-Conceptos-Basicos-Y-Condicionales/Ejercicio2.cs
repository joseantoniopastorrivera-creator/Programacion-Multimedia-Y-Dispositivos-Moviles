//Pedir al usuario que introduzca un número. Indicar si es positivo o negativo.

class Ejercicio2
{
    public static void Ejecutar()
    {
        float numero;
        bool esValido;

        do
        {
            Console.WriteLine("Introduzca un número: ");
            string respuesta = Console.ReadLine();

            esValido = float.TryParse(respuesta, out numero);

            if (!esValido)
            {
                Console.WriteLine("ERROR, introduce un número.\n");
            }
        } while (!esValido);

        if (numero < 0)
        {
            Console.WriteLine("El número " + numero + " es negativo.");
        }
        else
        {
            Console.WriteLine("El número " + numero + " es positivo.");
        }
        Console.WriteLine();
        Console.WriteLine("Pulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();




    }
}