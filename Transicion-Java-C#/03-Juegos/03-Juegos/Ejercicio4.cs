/*Juego “REFLEJOS”. Medir la velocidad de reacción del jugador. Un Beep sonará en un tiempo
aleatorio a partir del inicio del programa. El jugador deberá pulsar lo más rápido posible.
Indicar el tiempo, e indicar si se quiere salir o volver a jugar.*/

using System;
using System.Diagnostics;
using System.Threading;

class Ejercicio4
{
    public static void Ejecutar()
    {
        bool jugarDeNuevo = true;
        Random rng = new Random();

        while (jugarDeNuevo)
        {
            Console.Clear();
            Console.WriteLine($"{MenuJuegos.Azul}=== JUEGO 4: PRUEBA DE REFLEJOS ==={MenuJuegos.Reset}\n");
            Console.WriteLine("Pon a prueba tu velocidad de reacción.");
            Console.WriteLine("Cuando escuches el BEEP y veas la señal, ¡pulsa cualquier tecla lo más rápido posible!");
            Console.WriteLine("\nPulsa Intro cuando estés listo para empezar...");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Espera...");

            // 1. Limpiar el buffer de entrada para evitar trampas previas
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            // 2. Pausa aleatoria entre 2 y 7 segundos (2000 a 7000 milisegundos)
            int tiempoEspera = rng.Next(2000, 7001);
            Thread.Sleep(tiempoEspera);

            // Segunda limpieza justo antes de la señal por si pulsaron durante la espera
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            // 3. Emisión de la señal y arranque del cronómetro
            Console.WriteLine($"\n{MenuJuegos.Verde}¡¡¡YA!!! Pulsa una tecla.{MenuJuegos.Reset}");
            Console.Beep(1000, 300); // Emite un pitido de 1000Hz durante 300ms

            Stopwatch cronometro = new Stopwatch();
            cronometro.Start();

            // 4. Esperamos el impacto del jugador y detenemos el reloj
            Console.ReadKey(true);
            cronometro.Stop();

            // 5. Cálculo y visualización de resultados
            long tiempoReaccion = cronometro.ElapsedMilliseconds;
            Console.WriteLine($"\nTu tiempo de reacción ha sido: {MenuJuegos.Azul}{tiempoReaccion} milisegundos{MenuJuegos.Reset}.");

            if (tiempoReaccion < 200) Console.WriteLine("¡Nivel Dios! Eres increíblemente rápido.");
            else if (tiempoReaccion < 350) Console.WriteLine("Muy buenos reflejos.");
            else if (tiempoReaccion < 500) Console.WriteLine("Nada mal, pero puedes mejorar.");
            else Console.WriteLine("Demasiado lento. Tienes que estar más atento.");

            // 6. Bucle de reinicio con validación
            bool opcionValida = false;
            do
            {
                Console.Write("\n¿Quieres volver a jugar? (S/N): ");
                string respuesta = Console.ReadLine()?.Trim().ToUpper();

                if (respuesta == "S")
                {
                    jugarDeNuevo = true;
                    opcionValida = true;
                }
                else if (respuesta == "N")
                {
                    jugarDeNuevo = false;
                    opcionValida = true;
                    Console.WriteLine($"\n{MenuJuegos.Verde}Saliendo de la prueba de reflejos...{MenuJuegos.Reset}");
                }
                else
                {
                    Console.WriteLine($"{MenuJuegos.Rojo}Error: Introduce 'S' para Sí o 'N' para No.{MenuJuegos.Reset}");
                }
            } while (!opcionValida);
        }

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}