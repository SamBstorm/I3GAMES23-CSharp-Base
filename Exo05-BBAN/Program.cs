namespace Exo05_BBAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire une numéro BBAN (12 chiffres) :");
            string bban_str = Console.ReadLine();
            if (bban_str.Length == 12 && long.TryParse(bban_str, out _))
            {
                string ten_first = bban_str.Substring(0, 10);
                string two_last = bban_str.Substring(10);

                long ten = long.Parse(ten_first);
                short two = short.Parse(two_last);

                if (ten % 97 == two || (ten % 97 == 0 && two == 97))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("KO");
                }
            }
            else
            {
                Console.WriteLine("Ce n'est pas un BBAN valide...");
            }
        }
    }
}