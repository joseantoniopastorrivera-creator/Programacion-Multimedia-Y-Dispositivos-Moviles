//Pedir al usuario que introduzca su nota en un examen. Escribir la categoría asociada
//(Suspenso, Aprobado, Notable, Sobresaliente).

class Ejercicio5
{
    public static void Ejecutar()
    {
        float nota;
        bool esValido;

        do
        {
            Console.WriteLine("Introduzca la nota de su examen: ");
            string respuesta = Console.ReadLine();

            esValido = float.TryParse(respuesta, out nota);

            if (!esValido || nota > 10 || nota < 0)
            {
                Console.WriteLine("ERROR, introduce una nota válida entre 0 y 10.\n");
            }
        } while (!esValido);

        switch (nota)
        {
            case < 5:
                Console.WriteLine("Suspenso.");
                break;
            case >= 5 and < 7:
                Console.WriteLine("Aprobado.");
                break;
            case >= 7 and < 9:
                Console.WriteLine("Notable.");
                break;
            case >= 9:
                Console.WriteLine("Sobresaliente.");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Pulsa cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}