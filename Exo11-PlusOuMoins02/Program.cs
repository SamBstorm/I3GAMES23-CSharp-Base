namespace Exo11_PlusOuMoins02
{
    internal class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            const int MAX = 100;
            Console.Clear();
            Console.WriteLine("Bienvenue au jeu du Juste Prix!");
            //ushort juste_prix = (ushort)(RNG.Next(MAX-MIN+1)+MIN); //Formule de l'aléatoire si votre MIN est différent de 0 ou 1
            ushort juste_prix = (ushort)(RNG.Next(MAX) + 1);
            ushort proposition;
            string message = "Joueur! Quel est selon vous le Juste Prix?";
            int count = 0;
            do
            {
                do
                {
                    Console.WriteLine(message);
                    proposition = ushort.Parse(Console.ReadLine());
                    message = $"Veuillez une proposition entre 1 et {MAX} :";
                } while (proposition < 1 || proposition > MAX);
                if (proposition > juste_prix)
                {
                    message = "C'est moins! (nouvelle proposition)";
                }
                else if (proposition < juste_prix)
                {
                    message = "C'est plus! (nouvelle proposition)";
                }
                count++;
            } while (proposition != juste_prix);

            Console.WriteLine($"Bravo! Vous avez deviné le Juste Prix en {count} tentative{((count > 1)? "s" : "")}!");
        }
    }
}