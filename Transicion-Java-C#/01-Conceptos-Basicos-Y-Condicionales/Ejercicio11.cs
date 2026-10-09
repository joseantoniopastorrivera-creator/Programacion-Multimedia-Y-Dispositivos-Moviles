//Programa que determina si un año es bisiesto o no.
class Ejercicio11
{
    public static void Ejecutar()
    {
        bool ok = false;
        while (!ok)
        {
            Console.WriteLine("Introduce un año: ");
            string respuesta = Console.ReadLine();
            int anio;
            if (!int.TryParse(respuesta, out anio))
            {
                Console.WriteLine("ERROR, introduce un número entero.");
            }
            else
            {
                //Un año es bisiesto si es divisible por 4. 
                //Si es divisible por 100 no es bisiesto(por ej: 1900).
                //A menos que sea divisible por 400 entonces si es bisiesto.
                if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                {
                    Console.WriteLine($"El año {anio} es bisiesto.");

                }
                else
                {
                    Console.WriteLine($"El año {anio} NO es bisiesto.");
                }
                ok = true;

            }
        }
        Console.WriteLine("\nPulse cualquier tecla para voler al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}
