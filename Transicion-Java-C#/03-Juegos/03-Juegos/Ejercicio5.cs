/*“JUEGO DE LA VIDA”.
Investiga el juego de la vida de Conway.
El juego solicita al usuario el ancho y alto de tablero para jugar, y el porcentaje de
célula inicial en cada casilla.
Inicializar el tablero aplicando la probabilidad introducida.
Cada vez que el jugador pulsa intro, se avanza una generación en el tablero.
En un HUD de texto se indica la generación actual y el número de células vivas.*/

using System;

class Ejercicio5
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuJuegos.Azul}=== JUEGO 5: EL JUEGO DE LA VIDA (CONWAY) ==={MenuJuegos.Reset}\n");

        // 1. Configuración inicial con cláusulas de guarda
        int ancho = PedirParametro("Introduce el ancho del tablero (ej. 40): ", 10, 100);
        int alto = PedirParametro("Introduce el alto del tablero (ej. 20): ", 10, 50);
        int porcentaje = PedirParametro("Porcentaje inicial de células vivas (1-99): ", 1, 99);

        // 2. Inicialización del tablero
        bool[,] tablero = InicializarTablero(ancho, alto, porcentaje);
        int generacion = 1;

        // 3. Bucle principal de simulación
        while (true)
        {
            Console.Clear();
            int celulasVivas = ContarCelulasVivasTablero(tablero, ancho, alto);

            // HUD
            Console.WriteLine($"{MenuJuegos.Azul}Generación: {generacion} | Células vivas: {celulasVivas}{MenuJuegos.Reset}");
            Console.WriteLine("Pulsa [INTRO] para avanzar generación o [ESC] para salir al menú.\n");

            DibujarTablero(tablero, ancho, alto);

            // Control de teclado interactivo
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.Escape)
            {
                break; // Salida limpia al menú principal
            }
            else if (tecla.Key == ConsoleKey.Enter)
            {
                tablero = CalcularSiguienteGeneracion(tablero, ancho, alto);
                generacion++;
            }
        }

        Console.Clear();
    }

    // --- MÉTODOS MODULARES ---

    private static int PedirParametro(string mensaje, int min, int max)
    {
        int valor;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out valor) && valor >= min && valor <= max)
            {
                return valor;
            }
            Console.WriteLine($"{MenuJuegos.Rojo}Error: Introduce un valor numérico entre {min} y {max}.{MenuJuegos.Reset}");
        }
    }

    private static bool[,] InicializarTablero(int ancho, int alto, int porcentaje)
    {
        bool[,] nuevoTablero = new bool[ancho, alto];
        Random rng = new Random();

        for (int y = 0; y < alto; y++)
        {
            for (int x = 0; x < ancho; x++)
            {
                // Si el número aleatorio es menor o igual al porcentaje, nace una célula
                if (rng.Next(1, 101) <= porcentaje)
                {
                    nuevoTablero[x, y] = true;
                }
            }
        }
        return nuevoTablero;
    }

    private static void DibujarTablero(bool[,] tablero, int ancho, int alto)
    {
        for (int y = 0; y < alto; y++)
        {
            for (int x = 0; x < ancho; x++)
            {
                if (tablero[x, y])
                {
                    Console.Write($"{MenuJuegos.Verde}■ {MenuJuegos.Reset}"); // Célula viva
                }
                else
                {
                    Console.Write("· "); // Espacio vacío
                }
            }
            Console.WriteLine();
        }
    }

    private static bool[,] CalcularSiguienteGeneracion(bool[,] tableroActual, int ancho, int alto)
    {
        // Creamos una matriz completamente nueva para no contaminar los cálculos
        bool[,] siguienteTablero = new bool[ancho, alto];

        for (int y = 0; y < alto; y++)
        {
            for (int x = 0; x < ancho; x++)
            {
                int vecinasVivas = ContarVecinas(tableroActual, x, y, ancho, alto);
                bool estadoActual = tableroActual[x, y];

                // Aplicación estricta de las reglas de Conway
                if (estadoActual && (vecinasVivas == 2 || vecinasVivas == 3))
                {
                    siguienteTablero[x, y] = true; // Sobrevive
                }
                else if (!estadoActual && vecinasVivas == 3)
                {
                    siguienteTablero[x, y] = true; // Nace
                }
                else
                {
                    siguienteTablero[x, y] = false; // Muere por soledad o sobrepoblación
                }
            }
        }
        return siguienteTablero;
    }

    private static int ContarVecinas(bool[,] tablero, int posX, int posY, int ancho, int alto)
    {
        int vecinas = 0;

        // Recorremos la cuadrícula 3x3 alrededor de la célula central
        for (int y = posY - 1; y <= posY + 1; y++)
        {
            for (int x = posX - 1; x <= posX + 1; x++)
            {
                // 1. Evitamos contarnos a nosotros mismos como vecinos
                if (x == posX && y == posY) continue;

                // 2. Protegemos los límites de la matriz (Guard clause para bordes)
                if (x >= 0 && x < ancho && y >= 0 && y < alto)
                {
                    if (tablero[x, y])
                    {
                        vecinas++;
                    }
                }
            }
        }
        return vecinas;
    }

    private static int ContarCelulasVivasTablero(bool[,] tablero, int ancho, int alto)
    {
        int total = 0;
        for (int y = 0; y < alto; y++)
        {
            for (int x = 0; x < ancho; x++)
            {
                if (tablero[x, y]) total++;
            }
        }
        return total;
    }
}