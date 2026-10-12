using System;

class MenuJuegos
{
    // Constantes de color para la interfaz
    public const string Azul = "\x1b[38;2;52;152;219m";
    public const string Verde = "\x1b[38;2;46;204;113m";
    public const string Rojo = "\x1b[38;2;231;76;60m";
    public const string Reset = "\x1b[0m";

    public static void Main(string[] args)
    {
        int opcion = -1;
        do
        {
            Console.WriteLine($"{Azul}=== MENÚ DE JUEGOS ==={Reset}");
            Console.WriteLine("1. PIENSA Y ADIVINA (IA piensa, Player adivina)");
            Console.WriteLine("2. ADIVINA Y PIENSA (Player piensa, IA adivina)");
            Console.WriteLine("3. PLAYER vs IA (Juegos 1 y 2 alternados)");
            Console.WriteLine("4. REFLEJOS (Prueba de velocidad)");
            Console.WriteLine("5. JUEGO DE LA VIDA (Conway)");
            Console.WriteLine("0. Salir");
            Console.Write("\nElige un juego a ejecutar: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine($"{Rojo}Entrada no válida. Pulsa una tecla...{Reset}");
                Console.ReadKey();
                Console.Clear();
                continue; // Cláusula de guarda
            }

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Ejercicio1.Ejecutar();
                    break;
                case 2:
                    Ejercicio2.Ejecutar();
                    break;
                case 3:
                    Ejercicio3.Ejecutar();
                    break;
                case 4:
                    Ejercicio4.Ejecutar();
                    break;
                case 5:
                    Ejercicio5.Ejecutar();
                    break;
                case 0:
                    Console.WriteLine($"{Verde}Saliendo de la sala de juegos...{Reset}");
                    break;
                default:
                    Console.WriteLine($"{Rojo}Opción fuera de rango.{Reset}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        } while (opcion != 0);
    }
}