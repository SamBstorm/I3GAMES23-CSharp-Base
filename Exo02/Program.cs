namespace Exo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercice 2 : slide 104
             */
            /* Version 1 : Version décomposée
            Console.WriteLine("Introduire un premier nombre :");
            string? nb1_str = Console.ReadLine();

            int nb1 = int.Parse(nb1_str);

            Console.WriteLine("Introduire un second nombre :");
            string? nb2_str = Console.ReadLine();

            int nb2 = int.Parse(nb2_str);

            int sum = nb1 + nb2;

            Console.WriteLine($"{nb1} + {nb2} = {sum}");
            */

            /* Version 1 : Version simplifié 
             
            Console.WriteLine("Introduire un premier nombre:");
            int nb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduire un second nombre:");
            int nb2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
            */
        }
    }
}