using System.Text;

namespace ExoTab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INITIALISATION

            Console.OutputEncoding = Encoding.UTF8;
            const string PION = "😉";
            const string VIDE = "-";
            const int TAILLE = 10;
            //string[] table = { "😉","-", "-", "-", "-", "-", "-", "-", "-", "-" };
            string direction;

            string[] table = new string[TAILLE];
            table[0] = PION;
            for (int i = 1; i < table.Length; i++)
            {
                table[i] = VIDE;
            }
            //Jeu en boucle
            do
            {
                //Affichage table
                Console.Clear();
                foreach (string cell in table)
                {
                    Console.Write(cell);
                }
                Console.WriteLine();
                //Demander direction
                Console.WriteLine("Voulez-vous aller à (G)auche, à (D)roite ou (Q)uitter?");
                direction = Console.ReadLine().ToLower();

                //Récuperer Position
                int position = -1;

                for (int i = 0; i < table.Length && position == -1; i++)
                {
                    if (table[i] == PION)
                    {
                        position = i;
                    }
                }

                //Vérifier direction
                switch (direction)
                {
                    case "d":
                        if (table[TAILLE - 1] != PION)
                        {
                            table[position] = VIDE;
                            position++;
                            table[position] = PION;
                        }
                        break;
                    case "g":
                        if (table[0] != PION)
                        {
                            table[position] = VIDE;
                            position--;
                            table[position] = PION;
                        }
                        break;
                }
            } while (direction != "q");
        }
    }
}