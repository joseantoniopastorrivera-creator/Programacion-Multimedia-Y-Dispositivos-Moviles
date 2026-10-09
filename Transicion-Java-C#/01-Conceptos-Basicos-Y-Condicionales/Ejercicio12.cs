//Programa que determina los días de un mes, sin tener en cuenta si el año es bisiesto.
class Ejercicio12
{
    public static void Ejecutar()
    {
        bool ok = false, ok2 = false;
        int mes;
        do
        {

            Console.WriteLine("Introduce un mes (1-12): ");
            string respuesta = Console.ReadLine();
            ok = int.TryParse(respuesta, out mes);
            if (mes >= 1 && mes <= 12)
            {
                ok2 = true;
            }

        } while (!ok || !ok2);

        int diasMes = 0;
        switch (mes)
        {
            case 1 or 3 or 5 or 7 or 8 or 10 or 12:
                diasMes = 31;
                break;
            case 2:
                diasMes = 28;
                break;
            case 4 or 6 or 9 or 11:
                diasMes = 30;
                break;
        }

        Console.WriteLine($"El mes {mes} tiene {diasMes} días.");
        Console.WriteLine("\nPulsa cualquier tecla para volveral menú..");
        Console.ReadKey();
    }
}