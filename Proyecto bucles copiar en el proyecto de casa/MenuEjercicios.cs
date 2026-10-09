using System;

class MenuEjercicios
{
    // Colores
    public const string Emeral = "\x1b[92m";
    public const string Pomerade = "\x1b[31m";
    public const string AzulClaro = "\x1b[94m";
    public const string Reset = "\x1b[0m";

    public static void Main(string[] args)
    {
        int opcion = 0;

        while (opcion != -1)
        {
            Console.WriteLine(AzulClaro + "\n--- MENÚ DE EJERCICIOS ---" + Reset);
            Console.WriteLine("0. Cuenta atrás de cohete desde 10.");
            Console.WriteLine("1. Mostrar los números impares entre 0 y 100.");
            Console.WriteLine("2. Mostrar los números pares entre 0 y 100.");
            Console.WriteLine("3. Mostrar los números del 0 al 100.");
            Console.WriteLine("4. Mostrar los números del 100 al 0.");
            Console.WriteLine("5. Mostrar los múltiplos de 3 del 0 al 100.");
            Console.WriteLine("6. Mostrar los múltiplos de 3 y de 2 entre 0 y 100.");
            Console.WriteLine("7. Suma de los números desde 0 hasta N.");
            Console.WriteLine("8. Tabla de cuadrados y cubos del 0 al 10.");
            Console.WriteLine("9. Mostrar los números del 1 hasta N.");
            Console.WriteLine("10. Contar números positivos y negativos (0 para salir).");
            Console.WriteLine("11. Media y varianza de N números (0 para salir).");
            Console.WriteLine("12. Mostrar los divisores de un número.");
            Console.WriteLine("13. Determinar si un número es primo.");
            Console.WriteLine("14. Mostrar los números primos entre 2 y 100.");
            Console.WriteLine("15. Contar las vocales de una frase.");
            Console.WriteLine("16. Cambiar todas las vocales de un texto por una dada.");
            Console.WriteLine("17. Calcular el factorial de un número.");
            Console.WriteLine("18. Generar tablero 8x8 de 0s y 1s por probabilidad.");
            Console.WriteLine("19. Mostrar cuadrados de números separados por comas.");
            Console.WriteLine("20. Leer un texto y escribirlo al revés.");
            Console.WriteLine("21. Registro de 10 personas y menú de búsqueda.");
            Console.WriteLine("22. Determinar si un número es capicúa.");
            Console.WriteLine("23. Determinar si un texto es palíndromo.");
            Console.WriteLine("24. Contar cada tipo de vocal en un texto.");
            Console.WriteLine("25. Leer N números e imprimirlos en orden inverso.");
            Console.WriteLine("26. Cambiar vocales por números (a=4, e=3, i=1, o=0).");
            Console.WriteLine(Emeral + "-1. Salir." + Reset);

            Console.Write("\nIntroduce una opción: ");
            string respuesta = Console.ReadLine();

            if (!int.TryParse(respuesta, out opcion) || opcion < -1 || opcion > 26)
            {
                Console.WriteLine(Pomerade + "ERROR: Introduce una opción válida entre -1 y 26." + Reset);
            }
            else if (opcion != -1)
            {
                Console.WriteLine();
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine(Emeral + "Ejecutando Ejercicio 0..." + Reset);
                        Ejercicio0.Ejecutar();
                        break;
                    default:
                        Console.WriteLine(Pomerade + "Opción válida, pero ejercicio no implementado todavía." + Reset);
                        break;

                        /* DESCOMENTAR SEGÚN VAYAS CREANDO LAS CLASES
                        case 1: Ejercicio1.Ejecutar(); break;
                        case 2: Ejercicio2.Ejecutar(); break;
                        case 3: Ejercicio3.Ejecutar(); break;
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
                        case 18: Ejercicio18.Ejecutar(); break;
                        case 19: Ejercicio19.Ejecutar(); break;
                        case 20: Ejercicio20.Ejecutar(); break;
                        case 21: Ejercicio21.Ejecutar(); break;
                        case 22: Ejercicio22.Ejecutar(); break;
                        case 23: Ejercicio23.Ejecutar(); break;
                        case 24: Ejercicio24.Ejecutar(); break;
                        case 25: Ejercicio25.Ejecutar(); break;
                        case 26: Ejercicio26.Ejecutar(); break;
                        */
                }
            }
        }

        Console.WriteLine(Emeral + "Saliendo del programa..." + Reset);
    }
}