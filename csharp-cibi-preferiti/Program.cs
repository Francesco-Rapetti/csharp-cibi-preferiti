namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO
            string[] CibiPreferiti = { "Pasta", "Riso", "Pizza", "Panino", "Gelato" };
            // lunghezza classifica
            Console.WriteLine($"Lunghezza della classifica: {CibiPreferiti.Length}\n\n Classifica personale:");
            // classifica
            for (int i = 0; i < CibiPreferiti.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CibiPreferiti[i]}");
            }
            // spaziatore
            Console.WriteLine();
            // cibo preferito
            Console.WriteLine($"Cibo preferito: {CibiPreferiti[0]}");
            // cibo meno preferito
            Console.WriteLine($"Cibo meno preferito: {CibiPreferiti[CibiPreferiti.Length - 1]}");

            // BONUS

        }
    }
}
