/*1. Juego "PIENSA Y ADIVINA":
El ordenador piensa un número al azar del 1 al 10 y el jugador tiene que acertarlo.
Cada vez que no lo acierte, el ordenador indica si el número pensado es mayor o
menor que el que ha dicho el jugador.
Solo hay 3 intentos para adivinarlo
*/

using System;

class Ejercicio1
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuJuegos.Azul}=== JUEGO 1: PIENSA Y ADIVINA ==={MenuJuegos.Reset}\n");
        Console.WriteLine("El ordenador ha pensado un número del 1 al 10.");
        Console.WriteLine("¡Tienes 3 intentos para adivinarlo!\n");

        // 1. Inicialización de variables y generación del número aleatorio
        Random rng = new Random();
        int numeroSecreto = rng.Next(1, 11); // Genera de 1 a 10 (el límite superior es exclusivo)

        int intentosRestantes = 3;
        bool victoria = false;

        // 2. Bucle principal del juego
        while (intentosRestantes > 0)
        {
            // Calculamos el intento actual de forma dinámica (1, 2, 3)
            int intentoActual = 4 - intentosRestantes;
            Console.Write($"Intento {intentoActual}/3. Introduce tu número: ");

            string entrada = Console.ReadLine();

            // Cláusula de guarda: Validamos que sea un número y esté en el rango 1-10
            if (!int.TryParse(entrada.Trim(), out int numeroUsuario) || numeroUsuario < 1 || numeroUsuario > 10)
            {
                Console.WriteLine($"{MenuJuegos.Rojo}Error: Entrada no válida. Introduce un número del 1 al 10.{MenuJuegos.Reset}\n");
                continue; // No restamos intento si mete una letra por error
            }

            // 3. Lógica de comparación y pistas
            if (numeroUsuario == numeroSecreto)
            {
                victoria = true;
                break; // El usuario acertó, rompemos el bucle prematuramente
            }
            else if (numeroUsuario < numeroSecreto)
            {
                Console.WriteLine("Pista: El número que he pensado es MAYOR.\n");
            }
            else
            {
                Console.WriteLine("Pista: El número que he pensado es MENOR.\n");
            }

            // Restamos un intento solo si la jugada fue válida y fallida
            intentosRestantes--;
        }

        // 4. Resolución final del juego
        if (victoria)
        {
            Console.WriteLine($"\n{MenuJuegos.Verde}¡ENHORABUENA! Has acertado, el número era el {numeroSecreto}.{MenuJuegos.Reset}");
        }
        else
        {
            Console.WriteLine($"\n{MenuJuegos.Rojo}¡GAME OVER! Has agotado tus intentos. El número era el {numeroSecreto}.{MenuJuegos.Reset}");
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}