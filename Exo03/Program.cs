namespace Exo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Version décomposée :

            Console.WriteLine("Veuillez indiquer un nombre :");
            string? nbr_str = Console.ReadLine();

            int nbr;
            bool nbr_isConvert = int.TryParse(nbr_str, out nbr);

            if(nbr_isConvert == true)
            {
                int demi = nbr / 2;
                if( demi + demi == nbr) {
                    Console.WriteLine($"{nbr} est paire!");
                }   
                else {
                    Console.WriteLine($"{nbr} est impaire!");
                }
            }
            else
            {
                Console.WriteLine("On a demandé un chiffre!!! 😔");
            }
            */

            /*Version simplifiée :*/
            Console.WriteLine("Veuillez indiquer un nombre :");

            if (int.TryParse(Console.ReadLine(), out int nbr))
            {
                int demi = nbr / 2;
                if (demi + demi == nbr) Console.WriteLine($"{nbr} est paire!");
                else Console.WriteLine($"{nbr} est impaire!");
            }
            else
            {
                Console.WriteLine("On a demandé un chiffre!!! 😔");
            }
        }
    }
}