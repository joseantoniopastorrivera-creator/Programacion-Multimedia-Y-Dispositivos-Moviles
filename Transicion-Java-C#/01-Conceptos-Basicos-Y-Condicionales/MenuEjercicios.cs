using System;
using System.ComponentModel;
using System.Globalization;

class MenuEjercicios
{
    // Códigos ANSI RGB precisos
    public const string emerald = "\x1b[38;2;80;200;120m";
    public const string pomerade = "\x1b[38;2;192;57;43m";
    public const string cyanTitle = "\x1b[38;2;52;152;219m";
    public const string reset = "\x1b[0m";

    static void Main(string[] args)
    {
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine($"{cyanTitle}---MENÚ DE EJERCICIOS---{reset}");
            Console.WriteLine(" 1. Calcular raíz cuadrada de un número (> 0)[cite: 6].");
            Console.WriteLine(" 2. Indicar si un número es positivo o negativo[cite: 6].");
            Console.WriteLine(" 3. Indicar si un número es par o impar[cite: 6].");
            Console.WriteLine(" 4. Dividir dos números (con decimales solo si es necesario)[cite: 6].");
            Console.WriteLine(" 5. Valorar nota de examen (Suspenso, Aprobado, Notable, Sobresaliente)[cite: 6].");
            Console.WriteLine(" 6. Indicar el valor intermedio de tres números[cite: 6].");
            Console.WriteLine(" 7. Indicar si un número es divisible por 2, 3, 5, 7 y 11[cite: 6].");
            Console.WriteLine(" 8. Clasificar 10 números en mayores o menores que cero[cite: 6].");
            Console.WriteLine(" 9. Mostrar qué día será mañana[cite: 6].");
            Console.WriteLine("10. Indicar si un carácter es vocal/consonante y mayúscula/minúscula[cite: 6].");
            Console.WriteLine("11. Determinar si un año es bisiesto o no[cite: 6].");
            Console.WriteLine("12. Determinar los días de un mes (sin bisiestos)[cite: 6].");
            Console.WriteLine("13. Determinar los días de un mes (teniendo en cuenta bisiestos)[cite: 6].");
            Console.WriteLine("14. Determinar si una fecha (día y mes) es válida[cite: 6].");
            Console.WriteLine("15. Solicitar número (1-10) y decir si es primo[cite: 6].");
            Console.WriteLine("16. Indicar si un nombre empieza por vocal o consonante[cite: 6].");
            Console.WriteLine("17. Operaciones con 2 números (mayor/menor, distancia, media)[cite: 6].");
            Console.WriteLine($"{pomerade}0. Salir.{reset}");

            Console.Write($"{emerald}Introduce una opción: {reset}");

            // Usamos TryParse para validar si lo introducido es un número entero válido
            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1: Ejercicio1.Ejecutar(); break;
                case 2: Ejercicio2.Ejecutar(); break;
                case 3: Ejercicio3Mejorado.Ejecutar(); break;
                case 4: Ejercicio4.Ejecutar(); break;
                case 5: Ejercicio5.Ejecutar(); break;
                case 6: Ejercicio6.Ejecutar(); break;
                case 7: Ejercicio7.Ejecutar(); break;
                case 8: Ejercicio8.Ejecutar(); break;
                case 9: Ejercicio9.Ejecutar(); break;
                case 10: Ejercicio10.Ejecutar(); break;
                case 11: Ejercicio11.Ejecutar(); break;
                case 12: Ejercicio12.Ejecutar(); break;
                case 13: Ejercicio13.Ejecutar(); break;
                case 14: Ejercicio14.Ejecutar(); break;
                case 15: Ejercicio15.Ejecutar(); break;
                case 16: Ejercicio16.Ejecutar(); break;
                case 17: Ejercicio17.Ejecutar(); break;
                case 0:
                    Console.WriteLine($"{pomerade}Saliendo del programa...{reset}");
                    break;
                default:
                    Console.WriteLine($"{pomerade}Opción no válida. Introduce un número del 0 al 17.{reset}");
                    Console.WriteLine("Pulsa cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

            if (opcion != 0)
            {
                Console.Clear();
            }
        }
    }
}