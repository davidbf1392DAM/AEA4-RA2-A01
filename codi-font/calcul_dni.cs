using System;

namespace CalculLletraDNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dniText = LlegirNumeroDNI();

            if (!int.TryParse(dniText, out int dniNumero))
            {
                Console.WriteLine("Error inesperat en processar el número.");
                return;
            }

            char lletra = CalcularLletraDNI(dniNumero);

            Console.WriteLine("La lletra del DNI és: " + lletra);
            Console.WriteLine("DNI complet: " + dniText + lletra);
            Console.WriteLine("\nPrem una tecla per sortir...");
            Console.ReadKey();
        }

        static string LlegirNumeroDNI()
        {
            string? dniText;
            bool correcte;

            do
            {
                Console.Write("Introdueix el número del DNI sense lletra: ");
                dniText = Console.ReadLine();

                correcte = ValidarNumeroDNI(dniText);

                if (!correcte)
                {
                    Console.WriteLine("Error: has d'introduir exactament 8 dígits numèrics.");
                    Console.WriteLine();
                }

            } while (!correcte);

            return dniText!.Trim();
        }

        static bool ValidarNumeroDNI(string? dniText)
        {
            if (string.IsNullOrWhiteSpace(dniText)) return false;

            dniText = dniText.Trim();

            return dniText.Length == 8 && dniText.All(char.IsDigit);
        }

        static char CalcularLletraDNI(int numero)
        {
            const string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";

            return lletres[numero % lletres.Length];
        }
    }
}