namespace ExoTab_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 5, 3, 8, 1, 123, 5, 9};

            bool sorted = false;

            for (int turn = 0; !sorted; turn++)
            {
                sorted = true;
                for (int i = 0; i < tab.Length-1-turn; i++)
                {
                    if (tab[i] > tab[i+1])
                    {
                        int temp = tab[i];
                        tab[i] = tab[i+1];
                        tab[i+1] = temp;
                        sorted = false;
                    }
                }
            }

            foreach (int number in tab)
            {
                Console.WriteLine(number);
            }

        }
    }
}