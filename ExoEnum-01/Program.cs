using ExoEnum_01.Enums;
using ExoEnum_01.Structs;

namespace ExoEnum_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte[] deck = new Carte[52];
            int i = 0;
            foreach (string couleur in Enum.GetNames<Couleurs>())
            {
                foreach (string valeur in Enum.GetNames<Valeurs>())
                {
                    deck[i].valeur = Enum.Parse<Valeurs>(valeur);
                    deck[i].couleur = Enum.Parse<Couleurs>(couleur);
                    i++;
                }
            }

            foreach (Carte carte in deck)
            {
                Console.WriteLine($"La carte du {carte.valeur} de {carte.couleur}");
            }
        }
    }
}