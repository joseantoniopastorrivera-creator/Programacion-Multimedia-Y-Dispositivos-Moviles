//14. Programa que determina si una fecha (día y mes) es válida, sin tener en cuenta si el año es
//bisiesto.

class Ejercicio14
{
    public static void Ejecutar()
    {
        int mes = 0;
        int dia = 0;
        bool mesValido = false;
        bool diaValido = false;

        //Comprobación del mes
        do
        {
            Console.Write("Introduce el mes (1-12): ");
            if (int.TryParse(Console.ReadLine(), out mes) && mes >= 1 && mes <= 12)
            {
                mesValido = true;
            }
            else
            {
                Console.WriteLine("ERROR: El mes debe ser un número entre 1 y 12.\n");
            }
        } while (!mesValido);

        // Calculamos el límite de días del mes introducido
        int diasMes = 0;
        switch (mes)
        {
            case 1 or 3 or 5 or 7 or 8 or 10 or 12:
                diasMes = 31;
                break;
            case 4 or 6 or 9 or 11:
                diasMes = 30;
                break;
            case 2:
                diasMes = 28; // El enunciado excluye años bisiestos
                break;
        }

        //Comprobación del día en base al mes
        do
        {
            Console.Write($"Introduce el día (1-{diasMes}): ");
            if (int.TryParse(Console.ReadLine(), out dia) && dia >= 1 && dia <= diasMes)
            {
                diaValido = true;
            }
            else
            {
                Console.WriteLine($"ERROR: Has introducido un día incorrecto. El mes {mes} tiene un máximo de {diasMes} días.\n");
            }
        } while (!diaValido);

        // Resultado
        Console.WriteLine($"\nLa fecha {dia}/{mes} es una fecha válida.");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}