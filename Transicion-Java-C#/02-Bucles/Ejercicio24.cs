//24. Programa al que se introduce un texto y devuelve el número de aes, es, íes, oes y úes que
//el texto contiene

using System;

class Ejercicio24
{
    public static void Ejecutar()
    {
        Console.WriteLine($"{MenuEjercicios.Azul}Este programa cuenta las aes, es, íes, oes y úes de un texto.{MenuEjercicios.Reset}\n");

        bool ok = false;
        string textoOriginal = "";

        // 1. Validación de entrada
        do
        {
            Console.Write($"{MenuEjercicios.Azul}Introduce un texto: {MenuEjercicios.Reset}");
            textoOriginal = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(textoOriginal))
            {
                Console.WriteLine($"{MenuEjercicios.Rojo}Error: El texto no puede estar vacío.{MenuEjercicios.Reset}\n");
            }
            else
            {
                ok = true;
            }
        } while (!ok);

        // 2. Variables de conteo individual
        int contadorA = 0;
        int contadorE = 0;
        int contadorI = 0;
        int contadorO = 0;
        int contadorU = 0;

        // 3. Normalización: pasamos todo a minúsculas para reducir las comprobaciones a la mitad
        string textoLimpio = textoOriginal.ToLower();

        // 4. Recorrido del texto carácter a carácter
        foreach (char letra in textoLimpio)
        {
            // Usamos un switch agrupando casos para contar vocales normales y acentuadas
            switch (letra)
            {
                case 'a':
                case 'á':
                    contadorA++;
                    break;
                case 'e':
                case 'é':
                    contadorE++;
                    break;
                case 'i':
                case 'í':
                    contadorI++;
                    break;
                case 'o':
                case 'ó':
                    contadorO++;
                    break;
                case 'u':
                case 'ú':
                case 'ü':
                    contadorU++;
                    break;
            }
        }

        // 5. Salida de resultados
        Console.WriteLine($"\n{MenuEjercicios.Verde}Desglose de vocales encontradas:{MenuEjercicios.Reset}");
        Console.WriteLine($"- Número de aes (a, á): {contadorA}");
        Console.WriteLine($"- Número de es (e, é):  {contadorE}");
        Console.WriteLine($"- Número de íes (i, í): {contadorI}");
        Console.WriteLine($"- Número de oes (o, ó): {contadorO}");
        Console.WriteLine($"- Número de úes (u, ú, ü): {contadorU}");

        Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }
}