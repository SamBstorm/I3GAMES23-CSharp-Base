namespace Exo06_IBAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire un numéro BBAN valide (12 chiffres):");
            string bban_str = Console.ReadLine();
            if(bban_str.Length == 12 && long.TryParse(bban_str, out _))
            {
                string two_last = bban_str.Substring(10);
                //string bban_conc = two_last + two_last + 111400;
                //OU
                //string bban_conc = two_last + two_last + "111400";
                //OU
                string bban_conc = $"{two_last}{two_last}111400";
                long code_iban_lg = long.Parse(bban_conc);
                short modulo = (short)(code_iban_lg % 97);
                short bban_sous = (short)(98 - modulo);
                Console.WriteLine($"IBAN : BE{((bban_sous < 10)? "0":"")}{bban_sous} {bban_str}");
            }
            else
            {
                Console.WriteLine("Numéro BBAN non-valide...");
            }
        }
    }
}