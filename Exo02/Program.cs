namespace Exo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercice 2 : slide 104
             */
            /* Version Parse(...) : Version décomposée
            Console.WriteLine("Introduire un premier nombre :");
            string? nb1_str = Console.ReadLine();

            int nb1 = int.Parse(nb1_str);

            Console.WriteLine("Introduire un second nombre :");
            string? nb2_str = Console.ReadLine();

            int nb2 = int.Parse(nb2_str);

            int sum = nb1 + nb2;

            Console.WriteLine($"{nb1} + {nb2} = {sum}");
            */

            /* Version Parse(...) : Version simplifié 
             
            Console.WriteLine("Introduire un premier nombre:");
            int nb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduire un second nombre:");
            int nb2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
            */

            /* Version TryParse(...) : Version décomposée
            Console.WriteLine("Entrer un nombre :");
            string nb1_str = Console.ReadLine();

            int nb1;
            bool nb1_isConvert = int.TryParse(nb1_str, out nb1);

            Console.WriteLine("Entrer un nombre :");
            string nb2_str = Console.ReadLine();

            int nb2;
            bool nb2_isConvert = int.TryParse(nb2_str, out nb2);

            Console.WriteLine($"La conversion du premier nombre : {nb1_isConvert}");
            Console.WriteLine($"La conversion du second nombre : {nb2_isConvert}");
            Console.WriteLine($"L'addition des 2 nombres est : {nb1 + nb2}");
            */

            /* Version TryParse(...) : Version simplifié*/

            Console.WriteLine("Entrer un nombre :");
            int.TryParse(Console.ReadLine(), out int nb1);

            Console.WriteLine("Entrer un nombre :");
            int.TryParse(Console.ReadLine(), out int nb2);

            Console.WriteLine($"L'addition des 2 nombres est : {nb1 + nb2}");
        }
    }
}