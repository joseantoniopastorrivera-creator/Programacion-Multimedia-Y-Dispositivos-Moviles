//Introducir un nombre y el programa dice si empieza por vocal o consonante

class Ejercicio16
{
    public static void Ejecutar()
    {
        bool ok = false;
        string respuesta;
        char primeraLetra;
        do
        {
            Console.WriteLine("Introduce un nombre: ");
            respuesta = Console.ReadLine().Trim().ToLower();
            primeraLetra = respuesta[0];

            if (char.IsDigit(primeraLetra) || string.IsNullOrEmpty(respuesta))
            {
                Console.WriteLine("ERROR, Introduce un nombre correcto.\n");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        string vocales = "aeiou";
        bool empiezaPorVocal = false;
        for (int i = 0; i < 5; i++)
        {
            if (primeraLetra == vocales[i])
            {
                empiezaPorVocal = true;
            }
        }
        string empiezaPorTexto = empiezaPorVocal ? "vocal" : "consonante";
        Console.WriteLine($"El nombre '{respuesta}' empieza por {empiezaPorTexto}.");
        Console.WriteLine("\nPulse cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();

    }
}