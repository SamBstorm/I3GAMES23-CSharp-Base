using System.Text;

namespace Exo07___BoucleA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encodage en UTF8 non obligatoire, seulement pour smileys 🔺
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Veuillez indiquer un nombre :");
            string nbr_str = Console.ReadLine();
            int limit = int.Parse(nbr_str);
            int i = 0;
            string letter = "🔺";
            while (i < limit)
            {
                Console.WriteLine(letter);
                letter += "🔺";   //letter = letter + "A";
                i++;
            }
        }
    }
}