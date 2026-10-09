// Programa que solicita números entre 1 y 10. Si se salen de ese rango, el programa da
// mensaje de error. Si el número es correcto, el programa te dice si es o no un número primo[cite: 1]
class Ejercicio15
{
    public static void Ejecutar()
    {
        // Pedimos el número y comprobamos si está en rango
        int numero = 0;
        bool ok = false;
        do
        {
            Console.WriteLine("Introduce un número entre 1 y 10 (ambos inclusive): ");
            string respuesta = Console.ReadLine();
            if (!int.TryParse(respuesta, out numero) || numero > 10 || numero < 1)
            {
                Console.WriteLine("ERROR, introduzca un número entre 1 y 10.\n");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // Comprobamos si es primo o no (un número mayor que 1 es candidato)
        bool esPrimo = numero > 1;

        // El bucle se repite mientras 'i' sea mayor que 1 Y 'esPrimo' siga siendo true
        for (int i = (numero - 1); i > 1 && esPrimo; i--)
        {
            if (numero % i == 0)
            {
                esPrimo = false; // Encontramos un divisor, ya no es primo y el bucle termina
            }
        }

        // Resultado
        string esPrimoTexto = esPrimo ? "sí" : "no";
        Console.WriteLine($"El número {numero} {esPrimoTexto} es primo.");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}