namespace ExoBonus01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercice Conditionnel (BONUS)

             * Créez une application permettant de savoir si une année est Bissextile ou pas.
             * Une année est dites bissextile lorsqu'elle est divisible par 4 mais pas par 100.
             * Une année peut être bissextile si celle-ci est divisible par 400.

             * Bissextile : 2024, 2000								Non-bissextile : 1987, 1900
             */

            Console.WriteLine("Veuillez indiquer une année :");
            string? annee_str = Console.ReadLine();

            int annee;
            bool annee_isConvert = int.TryParse(annee_str, out annee);
            if (annee_isConvert)
            {
                if ((annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0)
                {
                    Console.WriteLine($"L'année {annee} est une année bissextile.");
                }
                else
                {
                    Console.WriteLine($"L'année {annee} n'est pas une année bissextile.");
                }
            }
            else
            {
                Console.WriteLine($"{annee_str} n'est pas une année valide...");
            }
        }
    }
}