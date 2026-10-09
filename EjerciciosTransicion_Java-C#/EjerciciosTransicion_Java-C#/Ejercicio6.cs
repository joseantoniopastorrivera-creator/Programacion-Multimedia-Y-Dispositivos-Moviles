//6. Pedir al usuario que introduzca tres números. Indicar cuál es el de valor intermedio.

class Ejercicio6
{
    public static void Ejecutar()
    {
        float num1 = 0, num2 = 0, num3 = 0;

        while (true)
        {
            Console.WriteLine("Introduce el primer número: ");
            string respuesta1 = Console.ReadLine();
            if (!float.TryParse(respuesta1, out num1))
            {
                Console.WriteLine("ERROR, introduce un valor numérico.\n");
                continue;
            }
            Console.WriteLine("Introduce el segundo número: ");
            string respuesta2 = Console.ReadLine();
            if (!float.TryParse(respuesta2, out num2))
            {
                Console.WriteLine("ERROR, introduce un valor numérico.\n");
                continue;
            }

            Console.WriteLine("Introduce el tercer número: ");
            string respuesta3 = Console.ReadLine();
            if (!float.TryParse(respuesta3, out num3))
            {
                Console.WriteLine("ERROR, introduce un valor numérico.\n");
                continue;
            }
            break;
        }
        if ((num2 < num1 && num1 < num3) || (num3 < num1 && num1 < num2))
        {
            Console.WriteLine("El número " + num1 + " es el número de valor intermedio de los tres dados por el usuario.");
        }
        else if ((num1 < num2 && num2 < num3) || (num3 < num2 && num2 < num1))
        {
            Console.WriteLine("El número " + num2 + " es el número de valor intermedio de los tres dados por el usuario.");

        }
        else if ((num1 < num3 && num3 < num2) || (num2 < num3 && num3 < num1))
        {
            Console.WriteLine("El número " + num3 + " es el número de valor intermedio de los tres dados por el usuario.");

        }
        else
        {
            Console.WriteLine("ERROR, al menos dos números tienen valor idéntico. \n- " + num1 + "\n- " + num2 + "\n- " + num3);

        }
        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();

    }
}