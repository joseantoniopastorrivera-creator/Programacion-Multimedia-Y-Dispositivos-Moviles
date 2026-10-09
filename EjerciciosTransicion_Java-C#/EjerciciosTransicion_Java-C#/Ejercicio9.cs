//Programa que muestra el día que será mañana sin tener en cuenta años bisiestos.

using System.ComponentModel;

class Ejercicio9
{
    public static void Ejecutar()
    {
        int dia = 0, mes = 0, anio = 0, diasMes = 0;
        bool esValido = false;
        //Comprobamos si el usuario ha introducido números enteros o cero(NA en años).
        while (true)
        {
            Console.WriteLine("Introduce el día: ");
            string respuestaDia = Console.ReadLine();
            esValido = int.TryParse(respuestaDia, out dia);
            if (!esValido || dia == 0 || dia > 31)
            {
                Console.WriteLine("ERROR, introduzca un número de día válido.\n");
                continue;
            }
            Console.WriteLine("Introduzca el mes: ");
            string respuestaMes = Console.ReadLine();
            esValido = int.TryParse(respuestaMes, out mes);
            if (!esValido || mes == 0 || mes > 12)
            {
                Console.WriteLine("ERROR, introduzca un número de mes válido.\n");
                continue;
            }
            Console.WriteLine("Introduzca el año: ");
            string respuestaAnio = Console.ReadLine();
            esValido = int.TryParse(respuestaAnio, out anio);
            if (!esValido)
            {
                Console.WriteLine("ERROR, introduzca un número entero.\n");
                continue;
            }
            //Catalogamos el tamaño de los meses según el número
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
            //Comprobamos que el día seleccionado no sobrepase la cantidad de días en el mes seleccionado.
            if (dia > diasMes)
            {
                Console.WriteLine("ERROR. El mes número " + mes + " tiene " + diasMes + " días. \nIntroduce un número de día correcto.\n");
                continue;
            }
            break;
        }
        //Comprobamos si es el ultimo día del año
        if (dia == diasMes && mes == 12)
        {
            dia = 1;
            mes = 1;
            anio++;
        }
        //Comprobamos si el ultimo día del mes
        else if (dia == diasMes)
        {
            dia = 1;
            mes++;
        }
        //El resto de casos
        else
        {
            dia++;
        }
        string nombreMes = "";
        switch (mes)
        {
            case 1:
                nombreMes = "Enero";
                break;
            case 2:
                nombreMes = "Febrero";
                break;
            case 3:
                nombreMes = "Marzo";
                break;
            case 4:
                nombreMes = "Abril";
                break;
            case 5:
                nombreMes = "Mayo";
                break;
            case 6:
                nombreMes = "Junio";
                break;
            case 7:
                nombreMes = "Julio";
                break;
            case 8:
                nombreMes = "Agosto";
                break;
            case 9:
                nombreMes = "Septiembre";
                break;
            case 10:
                nombreMes = "Octubre";
                break;
            case 11:
                nombreMes = "Noviembre";
                break;
            case 12:
                nombreMes = "Diciembre";
                break;
        }

        //Imprimimos el resultado por pantalla
        Console.WriteLine("El día siguiente a la fecha introducida corresponde a: " + dia + " de " + nombreMes + " de " + anio + ".");
        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();

    }
}