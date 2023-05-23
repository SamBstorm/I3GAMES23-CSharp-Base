namespace ExoTab_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 4, 3, 8, 8, 9, 21, 8, 1 };

            Console.WriteLine("Quelle valeur cherchez-vous?");
            int searched_value = int.Parse(Console.ReadLine());
            List<int> founded = new List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == searched_value)
                {
                    //Console.WriteLine($"La valeur recherchée se trouve en indice {i}.");
                    founded.Add(i);
                }
            }
            if (founded.Count == 0)
            {
                Console.WriteLine("La valeur recherchée n'est pas dans ce tableau...");
            }
            else
            {
                Console.Write("La valeur recherchée se trouve en indice :");
                foreach (int i in founded)
                {
                    Console.Write( $" {i}," );
                }
                Console.WriteLine("\b.");
            }
        }
    }
}