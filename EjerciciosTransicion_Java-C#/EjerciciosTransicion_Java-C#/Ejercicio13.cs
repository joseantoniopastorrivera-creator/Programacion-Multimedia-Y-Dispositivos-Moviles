//Programa que determina los días de un mes, teniendo en cuenta si el año es bisiesto.

class Ejercicio13
{
    public static void Ejecutar()
    {
        //Comprobar si es bisiesto con la bandera 'esBisiesto'
        bool ok = false;
        bool esBisiesto = false;
        int anio = 0;
        int mes = 0;
        while (!ok)
        {
            Console.WriteLine("Introduce un año: ");
            string respuesta = Console.ReadLine();
            if (!int.TryParse(respuesta, out anio))
            {
                Console.WriteLine("ERROR, introduce un número entero.");
            }
            else
            {
                //Un año es bisiesto si es divisible por 4 pero no divisible por 100(por ej: 1900 no lo es).
                //A menos que sea divisible por 400 entonces si es bisiesto directamente.
                esBisiesto = ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0);
                ok = true;
            }
        }

        //Comprobar si es un mes válido
        bool mesvalido = false;
        do
        {
            Console.Write("Introduce un mes (1-12): ");
            if (int.TryParse(Console.ReadLine(), out mes) && mes >= 1 && mes <= 12)
            {
                mesvalido = true;
            }
            else
            {
                Console.WriteLine("ERROR, escribe un més válido.");
            }
        } while (!mesvalido);

        //Switch para el número de días de cada mes.
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
                diasMes = esBisiesto ? 29 : 28;
                break;
        }

        //Optimización para que salgan los nombres de los meses con un Array
        string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        string nombreMes = nombresMeses[mes - 1]; // Restamos 1 porque el índice de los arrays empieza en 0

        //Resultados
        Console.WriteLine($"El mes {nombreMes} del año {anio} tiene {diasMes} días.");
        string esBisiestoTexto = esBisiesto ? "si" : "no";
        Console.WriteLine($"Dicho año {esBisiestoTexto} es bisiesto.");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}
