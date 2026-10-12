/*Integrar los juegos 1 y 2, para que se realicen de forma alternativa, con marcadores de
puntuación Player vs IA.*/

using System;

class Ejercicio3
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuJuegos.Azul}=== JUEGO 3: PLAYER vs IA (Batalla Alterna) ==={MenuJuegos.Reset}\n");
        Console.WriteLine("Los juegos 1 y 2 se alternarán. El primero en llegar a 3 puntos gana la partida.\n");

        int puntosPlayer = 0;
        int puntosIA = 0;
        int ronda = 1;

        // 1. Bucle principal de la partida (hasta que alguien llegue a 3 puntos)
        while (puntosPlayer < 3 && puntosIA < 3)
        {
            Console.WriteLine($"{MenuJuegos.Azul}--- RONDA {ronda} ---{MenuJuegos.Reset}");
            Console.WriteLine($"MARCADOR: Player [{puntosPlayer}] - [{puntosIA}] IA\n");

            // Alternancia de turnos usando el módulo (rondas impares Player, rondas pares IA)
            if (ronda % 2 != 0)
            {
                Console.WriteLine($"{MenuJuegos.Verde}Turno 1: El ordenador piensa, TÚ adivinas.{MenuJuegos.Reset}");
                bool victoriaPlayer = RondaPlayerAdivina();

                // Asignación de puntos según el resultado de la ronda
                if (victoriaPlayer) puntosPlayer++;
                else puntosIA++;
            }
            else
            {
                Console.WriteLine($"{MenuJuegos.Rojo}Turno 2: Tú piensas, la IA adivina.{MenuJuegos.Reset}");
                bool victoriaIA = RondaIAAdivina();

                if (victoriaIA) puntosIA++;
                else puntosPlayer++;
            }

            ronda++;
            Console.WriteLine("\nPulsa cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        // 2. Pantalla de resultados finales
        Console.WriteLine($"{MenuJuegos.Azul}=== RESULTADO FINAL ==={MenuJuegos.Reset}");
        Console.WriteLine($"MARCADOR DEFINITIVO: Player [{puntosPlayer}] - [{puntosIA}] IA\n");

        if (puntosPlayer > puntosIA)
        {
            Console.WriteLine($"{MenuJuegos.Verde}¡VICTORIA! Has derrotado a la máquina.{MenuJuegos.Reset}");
        }
        else
        {
            Console.WriteLine($"{MenuJuegos.Rojo}DERROTA. La IA ha demostrado ser superior esta vez.{MenuJuegos.Reset}");
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú principal...");
        Console.ReadKey();
        Console.Clear();
    }

    // --- MÉTODOS MODULARES PARA MANTENER EL MAIN LIMPIO ---

    private static bool RondaPlayerAdivina()
    {
        Random rng = new Random();
        int numeroSecreto = rng.Next(1, 11);
        int intentosRestantes = 3;

        while (intentosRestantes > 0)
        {
            int intentoActual = 4 - intentosRestantes;
            Console.Write($"Intento {intentoActual}/3. Introduce tu número (1-10): ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada.Trim(), out int numeroUsuario) || numeroUsuario < 1 || numeroUsuario > 10)
            {
                Console.WriteLine($"{MenuJuegos.Rojo}Entrada no válida.{MenuJuegos.Reset}");
                continue; // Cláusula de guarda
            }

            if (numeroUsuario == numeroSecreto)
            {
                Console.WriteLine($"\n{MenuJuegos.Verde}¡Acertaste! El número era {numeroSecreto}.{MenuJuegos.Reset}");
                return true;
            }
            else if (numeroUsuario < numeroSecreto)
            {
                Console.WriteLine("Pista: Es MAYOR.");
            }
            else
            {
                Console.WriteLine("Pista: Es MENOR.");
            }

            intentosRestantes--;
        }

        Console.WriteLine($"\n{MenuJuegos.Rojo}Fallaste. El número era {numeroSecreto}.{MenuJuegos.Reset}");
        return false;
    }

    private static bool RondaIAAdivina()
    {
        Console.WriteLine("Piensa un número del 1 al 10 y pulsa Intro cuando lo tengas...");
        Console.ReadLine();

        int min = 1;
        int max = 10;
        int intentosRestantes = 3;
        Random rng = new Random();

        while (intentosRestantes > 0)
        {
            int intentoActual = 4 - intentosRestantes;
            int prediccion = rng.Next(min, max + 1);

            Console.WriteLine($"Intento {intentoActual}/3 de la IA. ¿Es el {prediccion}?");
            Console.WriteLine("1. ¡Sí! | 2. Mi número es MAYOR | 3. Mi número es MENOR");
            Console.Write("Opción: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada.Trim(), out int respuesta) || respuesta < 1 || respuesta > 3)
            {
                Console.WriteLine($"{MenuJuegos.Rojo}Opción no válida (1-3).{MenuJuegos.Reset}");
                continue; // Cláusula de guarda
            }

            if (respuesta == 1)
            {
                Console.WriteLine($"\n{MenuJuegos.Rojo}La IA ha adivinado tu número.{MenuJuegos.Reset}");
                return true;
            }
            else if (respuesta == 2)
            {
                min = prediccion + 1;
                if (min > max) min = max;
            }
            else
            {
                max = prediccion - 1;
                if (max < min) max = min;
            }

            intentosRestantes--;
        }

        Console.WriteLine($"\n{MenuJuegos.Verde}La IA agotó sus intentos. Has ganado esta ronda.{MenuJuegos.Reset}");
        return false;
    }
}