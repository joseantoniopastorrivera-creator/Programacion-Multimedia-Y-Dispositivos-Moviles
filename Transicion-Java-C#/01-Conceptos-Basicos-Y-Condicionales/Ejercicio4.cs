//Pedir al usuario que introduzca dos números y dividirlos. Si el resultado es un número
//entero, mostrar un número entero. Si la división no es entera, muestra el resultado con
//decimales.

class Ejercicio4
{
    public static void Ejecutar()
    {
        float num1 = 0, num2 = 0;

        while (true)
        {
            Console.WriteLine("Introduzca el primer número: ");
            string respuesta1 = Console.ReadLine();

            if (!float.TryParse(respuesta1, out num1))
            {

                Console.WriteLine("ERROR, Introduce un valor númerico.\n");
                continue;
            }
            Console.WriteLine("Introduzca el segundo número: ");
            string respuesta2 = Console.ReadLine();

            if (!float.TryParse(respuesta2, out num2))
            {
                Console.WriteLine("ERROR, introduce un valor numérico.\n");
                continue;
            }

            if (num2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0.\n");
                continue;
            }
            break;

        }
        float resultado = num1 / num2;
        Console.WriteLine("La división de: " + num1 + " / " + num2 + " = " + resultado + ".");
        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}