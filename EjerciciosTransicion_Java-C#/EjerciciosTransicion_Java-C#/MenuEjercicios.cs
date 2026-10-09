using System;
using System.ComponentModel;
using System.Globalization;

class MenuEjercicios
{
    static void Main(string[] args)
    {
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("---Menú de Ejercicios de Transición de JAVA a C#---");
            Console.WriteLine("1. Calcular Raíz Cuadrada de un número.");
            Console.WriteLine("2. Calcular si un número es positivo o negativo.");
            Console.WriteLine("3. Calcular si un número es par o impar.");
            Console.WriteLine("4. Dividir dos números (mostrando decimales solo si es necesario).");
            Console.WriteLine("5. Valorar la nota de un examen por la puntuación obtenida en el mismo.");
            Console.WriteLine("6. Indicar el valor intermedio de tres números.");
            Console.WriteLine("7. Indicar si un número es divisible por 2, 3, 5, 7 y 11.");
            Console.WriteLine("8. Clasificar 10 números en mayores o menores que cero.");
            Console.WriteLine("9. Mostrar que día será mañana.");
            //Console.WriteLine();
            Console.WriteLine("0. Salir.");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio1.Ejecutar();
                    break;
                case 2:
                    Ejercicio2.Ejecutar();
                    break;

                case 3:
                    Ejercicio3Mejorado.Ejecutar();
                    break;
                case 4:
                    Ejercicio4.Ejecutar();
                    break;
                case 5:
                    Ejercicio5.Ejecutar();
                    break;
                case 6:
                    Ejercicio6.Ejecutar();
                    break;
                case 7:
                    Ejercicio7.Ejecutar();
                    break;
                case 8:
                    Ejercicio8.Ejecutar();
                    break;
                case 9:
                    Ejercicio9.Ejecutar();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa..");
                    break;
                default:
                    Console.Write("Opción no válida.");
                    break;
            }
        }
    }
}
