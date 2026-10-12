//Se registran 10 personas con nombre y edad.
// a) Mostrar los datos introducidos de forma formateada.
// b) Crear una función que busque un nombre y devuelva todos los índices de registros con ese nombre.
// c) Crear una función que busque los registros menores que cierta edad introducida.
// d) Hacer un menú que permita buscar por nombre o edad o salir.

using System;
using System.Collections.Generic;

class Ejercicio21
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}=== EJERCICIO 21: GESTIÓN DE REGISTROS (10 PERSONAS) ==={MenuEjercicios.Reset}\n");

        // Declaración de los arrays para almacenar 10 personas
        string[] nombres = new string[10];
        int[] edades = new int[10];

        // 1. Registro de los 10 usuarios con validación básica
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"--- Persona {i + 1} de 10 ---");

            // Pedir nombre
            string nombre;
            do
            {
                Console.Write("Introduce el nombre: ");
                nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine($"{MenuEjercicios.Rojo}El nombre no puede estar vacío.{MenuEjercicios.Reset}");
                }
            } while (string.IsNullOrWhiteSpace(nombre));
            nombres[i] = nombre.Trim();

            // Pedir edad
            int edad = 0;
            bool edadOk = false;
            do
            {
                Console.Write("Introduce la edad: ");
                string inputEdad = Console.ReadLine();
                if (int.TryParse(inputEdad, out edad) && edad >= 0 && edad <= 120)
                {
                    edadOk = true;
                }
                else
                {
                    Console.WriteLine($"{MenuEjercicios.Rojo}Error. Introduce una edad válida (0-120).{MenuEjercicios.Reset}");
                }
            } while (!edadOk);
            edades[i] = edad;

            Console.WriteLine();
        }

        // a) Mostrar datos introducidos de forma formateada
        Console.Clear();
        Console.WriteLine($"{MenuEjercicios.Verde}=== DATOS REGISTRADOS ==={MenuEjercicios.Reset}");
        Console.WriteLine($"{"ID",-5} | {"NOMBRE",-20} | {"EDAD",-5}");
        Console.WriteLine(new string('-', 38));
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i,-5} | {nombres[i],-20} | {edades[i],-5}");
        }
        Console.WriteLine("\nPulsa cualquier tecla para entrar al menú de consultas...");
        Console.ReadKey();

        // d) Menú interactivo
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine($"{MenuEjercicios.Azul}=== MENÚ DE BÚSQUEDA Y CONSULTAS ==={MenuEjercicios.Reset}");
            Console.WriteLine("1. Buscar por nombre (devuelve índices)");
            Console.WriteLine("2. Buscar registros menores que cierta edad");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            string inputOpcion = Console.ReadLine();
            if (!int.TryParse(inputOpcion, out opcion))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Opción no válida. Pulsa una tecla para continuar.{MenuEjercicios.Reset}");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("\nIntroduce el nombre a buscar: ");
                    string nombreBuscado = Console.ReadLine();
                    List<int> indices = BuscarPorNombre(nombres, nombreBuscado);

                    if (indices.Count > 0)
                    {
                        Console.WriteLine($"{MenuEjercicios.Verde}Nombre encontrado en los índices: {string.Join(", ", indices)}{MenuEjercicios.Reset}");
                    }
                    else
                    {
                        Console.WriteLine($"{MenuEjercicios.Rojo}No se ha encontrado ninguna coincidencia con ese nombre.{MenuEjercicios.Reset}");
                    }
                    break;

                case 2:
                    int edadLimite = 0;
                    bool limiteOk = false;
                    do
                    {
                        Console.Write("\nIntroduce la edad límite (mostrará los menores que esta): ");
                        if (int.TryParse(Console.ReadLine(), out edadLimite) && edadLimite >= 0)
                        {
                            limiteOk = true;
                        }
                        else
                        {
                            Console.WriteLine($"{MenuEjercicios.Rojo}Introduce un número válido.{MenuEjercicios.Reset}");
                        }
                    } while (!limiteOk);

                    BuscarMenoresQueEdad(nombres, edades, edadLimite);
                    break;

                case 3:
                    Console.WriteLine($"{MenuEjercicios.Verde}\nSaliendo del programa. ¡Hasta pronto!{MenuEjercicios.Reset}");
                    break;

                default:
                    Console.WriteLine($"{MenuEjercicios.Rojo}Opción fuera de rango (1-3).{MenuEjercicios.Reset}");
                    break;
            }

            if (opcion != 3)
            {
                Console.WriteLine("\nPulsa cualquier tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != 3);

        Console.Clear();
    }

    // b) Función que busca un nombre y devuelve todos los índices de registros con ese nombre
    public static List<int> BuscarPorNombre(string[] nombres, string busqueda)
    {
        List<int> indicesEncontrados = new List<int>();
        for (int i = 0; i < nombres.Length; i++)
        {
            // Usamos StringComparison.OrdinalIgnoreCase para que no distinga entre mayúsculas y minúsculas
            if (nombres[i].Equals(busqueda.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                indicesEncontrados.Add(i);
            }
        }
        return indicesEncontrados;
    }

    // c) Función que busca y muestra los registros menores que cierta edad introducida
    public static void BuscarMenoresQueEdad(string[] nombres, int[] edades, int edadLimite)
    {
        Console.WriteLine($"\n{MenuEjercicios.Verde}=== PERSONAS MENORES DE {edadLimite} AÑOS ==={MenuEjercicios.Reset}");
        bool encontrado = false;

        for (int i = 0; i < edades.Length; i++)
        {
            if (edades[i] < edadLimite)
            {
                Console.WriteLine($"- ID {i}: {nombres[i]} ({edades[i]} años)");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se ha encontrado ninguna persona por debajo de esa edad.");
        }
    }
}