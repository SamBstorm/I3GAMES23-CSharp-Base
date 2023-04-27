using System.Text;

namespace Demo_Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10) {
                Console.WriteLine( $"x vaut : {x}" );
                x++;                                    // x = x + 1
            }

            Console.WriteLine($"Au final x vaudra : {x}");



            #region Démo While : boucle blocante
            /*Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10):");
                string nb1_str = Console.ReadLine();
                short nb1;
                bool is_convert = short.TryParse(nb1_str, out nb1);
                while(!is_convert)
                {
                    Console.WriteLine($"{nb1_str} n'est pas un nombre.");
                    Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10):");
                    nb1_str = Console.ReadLine();
                    is_convert = short.TryParse(nb1_str, out nb1);
                }
                while (nb1 < 1 || nb1 > 10)
                {
                    Console.WriteLine("Ce n'est pas un nombre entre 1 et 10...😔");
                    nb1_str = Console.ReadLine();
                    is_convert = short.TryParse (nb1_str, out nb1);
                    while (!is_convert)
                    {
                        Console.WriteLine($"{nb1_str} n'est pas un nombre.");
                        Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10):");
                        nb1_str = Console.ReadLine();
                        is_convert = short.TryParse(nb1_str, out nb1);
                    }
                }
                Console.WriteLine("C'est bien un nombre entre 1 et 10!");*/
            #endregion
        }
    }
}