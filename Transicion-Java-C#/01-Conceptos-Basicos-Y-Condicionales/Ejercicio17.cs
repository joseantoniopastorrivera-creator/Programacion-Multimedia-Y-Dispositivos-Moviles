//Pedir 2 números. Después preguntar al usuario qué quiere hacer con ellos. 
//  1.- Encontrar y decir cuál es el mayor y cuál el menor. 
//  2.- Encontrar la distancia entre ambos. 
//  3.- La media entre ambos.

class Ejercicio17
{
    public static void Ejecutar()
    {
        //Variables
        float num1;
        float num2;
        bool ok1 = false;
        bool ok2 = false;

        //Comprobamos el primer número
        do
        {
            Console.WriteLine("Introduce el primer número: ");
            string respuesta = Console.ReadLine().Trim();
            if (!float.TryParse(respuesta, out num1))
            {
                Console.WriteLine("ERROR, Introduce un número.");
            }
            else
            {
                ok1 = true;
            }
        } while (!ok1);

        //Comprobamos el segundo número
        do
        {
            Console.WriteLine("Introduce el segundo número: ");
            string respuesta = Console.ReadLine().Trim();
            if (!float.TryParse(respuesta, out num2))
            {
                Console.WriteLine("ERROR, Introduce un número.");
            }
            else
            {
                ok2 = true;
            }
        } while (!ok2);

        //Menú de opciones
        int opcion = -1;
        float distancia;
        float media;
        do
        {
            Console.WriteLine("\n---MENÚ DE OPCIONES---");
            Console.WriteLine("1.- Encontrar y decir cuál es el mayor y cuál el menor.");
            Console.WriteLine("2.- Encontrar la distancia entre ambos.");
            Console.WriteLine("3.- La media entre ambos.");
            Console.WriteLine("0.- Salir.");

            string respuesta = Console.ReadLine();
            if (!int.TryParse(respuesta, out opcion) || opcion < 0 || opcion > 3)
            {
                Console.WriteLine("ERROR, Introduce una opción válida.");
            }
            else
            {
                switch (opcion)
                {
                    case 1:
                        if (num1 < num2)
                        {
                            Console.WriteLine($"{num1} es menor que {num2}");
                        }
                        else if (num1 > num2)
                        {
                            Console.WriteLine($"{num2} es menor que {num1}");
                        }
                        else
                        {
                            Console.WriteLine($"{num1} es igual que {num2}");
                        }
                        break;
                    case 2:
                        if (num1 > num2)
                        {
                            distancia = num1 - num2;
                        }
                        else if (num2 > num1)
                        {
                            distancia = num2 - num1;
                        }
                        else
                        {
                            distancia = 0;
                        }
                        Console.WriteLine($"La distancia entre {num1} y {num2} es {distancia}.");
                        break;
                    case 3:
                        media = (num1 + num2) / 2;
                        Console.WriteLine($"La media de {num1} y {num2} es {media}.");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del menú..");
                        break;
                    default:
                        Console.WriteLine("ERROR, Introduce una opción válida.");
                        break;
                }
            }

        } while (opcion != 0);

        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}