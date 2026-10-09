//Programa al que se introduce un carácter y dice si es vocal o consonante, mayúscula o
//minúscula.

class Ejercicio10
{
    public static void Ejecutar()
    {
        string vocales = "aeiou";
        while (true)
        {
            Console.WriteLine("Introduce un carácter: ");
            char caracter = Console.ReadKey().KeyChar;
            //Comprobamos si es letra
            if (!char.IsLetter(caracter))
            {
                Console.WriteLine("\nERROR, introduzca una letra.\n");
                continue;
            }
            //Comprobamos si es vocal
            bool esVocal = true;
            char caracterMinuscula = char.ToLower(caracter);
            if (!vocales.Contains(caracterMinuscula))
            {
                esVocal = false;
            }
            //Imprimimos resultado
            string tipoLetra = esVocal ? "vocal" : "consonante";
            string tipoMayus = char.IsUpper(caracter) ? "mayúscula" : "minúscula";
            Console.WriteLine($"\nLa letra '{caracter}' introducida es una {tipoLetra} y está escrito en {tipoMayus}.");
            break;
        }
        Console.WriteLine("\nPulsa cualquier tecla para volver al menú..");
        Console.ReadKey();
        Console.Clear();
    }
}