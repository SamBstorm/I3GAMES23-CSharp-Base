namespace Exo10_PlusOuMoins01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bienvenue au jeu du Juste Prix!");
            Console.WriteLine("Veuillez indiquer le Juste prix à l'abris des regards :");
            ushort juste_prix = ushort.Parse(Console.ReadLine());
            ushort proposition;
            Console.Clear();
            string message = "Joueur! Quel est selon vous le Juste Prix?";
            do
            {
                Console.WriteLine(message);
                proposition = ushort.Parse(Console.ReadLine());
                if (proposition > juste_prix)
                {
                    message = "C'est moins! (nouvelle proposition)";
                }
                else if (proposition < juste_prix)
                {
                    message = "C'est plus! (nouvelle proposition)";
                } 
            } while (proposition != juste_prix);

            Console.WriteLine("Bravo! Vous avez deviné le Juste Prix!");
        }
    }
}