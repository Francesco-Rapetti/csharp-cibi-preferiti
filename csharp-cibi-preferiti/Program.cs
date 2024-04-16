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
            int media = CibiPreferiti.Length / 2;
            if (CibiPreferiti.Length % 2 == 0)
            {
                Console.WriteLine($"Cibo in mezzo: {CibiPreferiti[media - 1]} e {CibiPreferiti[media]}");
            } else
            {
                Console.WriteLine($"Cibo in mezzo: {CibiPreferiti[media]}");
            }
        }
    }
}
