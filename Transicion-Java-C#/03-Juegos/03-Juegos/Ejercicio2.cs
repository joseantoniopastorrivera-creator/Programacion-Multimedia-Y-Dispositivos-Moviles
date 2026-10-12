/*Juego "ADIVINA Y PIENSA":
El usuario piensa un número del 1 al 10 y el ordenador tiene que adivinarlo.
Cada vez que no haya acierto, el usuario indica si el que ha pensado es menor o mayor
que el que ha dicho el ordenador.
El ordenador solo tiene 3 intentos para adivinarlo.*/

using System;

class Ejercicio2
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuJuegos.Azul}=== JUEGO 2: ADIVINA Y PIENSA ==={MenuJuegos.Reset}\n");
        Console.WriteLine("Piensa un número del 1 al 10. Yo (la IA) intentaré adivinarlo en 3 intentos.");
        Console.WriteLine("Pulsa Intro cuando lo tengas en mente...");
        Console.ReadLine();

        // 1. Inicialización de límites e intentos
        int min = 1;
        int max = 10;
        int intentosRestantes = 3;
        bool victoriaIA = false;
        Random rng = new Random();

        // 2. Bucle principal de la IA
        while (intentosRestantes > 0)
        {
            int intentoActual = 4 - intentosRestantes;

            // La IA genera una predicción aleatoria dentro del rango acotado
            int prediccion = rng.Next(min, max + 1);

            Console.WriteLine($"\nIntento {intentoActual}/3. ¿Es el {prediccion}?");
            Console.WriteLine("1. ¡Sí, has acertado!");
            Console.WriteLine("2. No, mi número es MAYOR.");
            Console.WriteLine("3. No, mi número es MENOR.");
            Console.Write("Elige una opción (1-3): ");

            string entrada = Console.ReadLine();

            // Cláusula de guarda: Validamos que la respuesta del usuario sea correcta
            if (!int.TryParse(entrada.Trim(), out int respuesta) || respuesta < 1 || respuesta > 3)
            {
                Console.WriteLine($"{MenuJuegos.Rojo}Error: Por favor, introduce 1, 2 o 3 para darme la pista.{MenuJuegos.Reset}");
                continue; // No restamos intento a la IA si el usuario se equivoca al teclear
            }

            // 3. Procesamiento de la pista y reajuste de límites
            if (respuesta == 1)
            {
                victoriaIA = true;
                break; // La IA ha acertado, rompemos el bucle
            }
            else if (respuesta == 2)
            {
                // Si el número del usuario es mayor, el nuevo mínimo posible es la predicción actual + 1
                min = prediccion + 1;

                // Protección por si el jugador miente o se contradice
                if (min > max) min = max;
            }
            else if (respuesta == 3)
            {
                // Si el número del usuario es menor, el nuevo máximo posible es la predicción actual - 1
                max = prediccion - 1;

                if (max < min) max = min;
            }

            intentosRestantes--;
        }

        // 4. Resolución final del juego
        if (victoriaIA)
        {
            Console.WriteLine($"\n{MenuJuegos.Rojo}¡LA IA GANA! He adivinado tu número mediante deducción.{MenuJuegos.Reset}");
        }
        else
        {
            Console.WriteLine($"\n{MenuJuegos.Verde}¡PLAYER GANA! He agotado mis 3 intentos y no logré descubrir tu número.{MenuJuegos.Reset}");
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}