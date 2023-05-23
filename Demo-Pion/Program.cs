using System.Text;

namespace Demo_Pion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation
            Console.OutputEncoding = Encoding.UTF8;
            const string PION = "😉";
            const string VIDE = "-";
            const int TAILLE = 10;

            bool[] grid = new bool[TAILLE];

            int position = 0;
            grid[position] = true;

            ConsoleKey direction;

            //Jeu déplacement
            do
            {
                //Affichage
                Console.Clear();
                foreach (bool cell in grid)
                {
                    Console.Write((cell) ? PION : VIDE);
                }
                Console.WriteLine();
                //Demander direction
                Console.WriteLine("Voulez-vous aller à (G)auche, à (D)roite ou (Q)uitter?");
                direction = Console.ReadKey(true).Key;

                //Gestion direction
                switch (direction)
                {
                    case ConsoleKey.D:
                        if (!grid[grid.Length - 1])
                        {
                            grid[position++] = false;
                            grid[position] = true;
                        }
                        break;
                    case ConsoleKey.G:
                        if (!grid[0])
                        {
                            grid[position--] = false;
                            grid[position] = true;
                        }
                        break;
                }

                /*
                if (direction == "d" && !grid[grid.Length - 1])
                {
                    grid[position++] = false;
                    grid[position] = true;
                }
                else if (direction == "g" && !grid[0])
                {
                    grid[position--] = false;
                    grid[position] = true;
                }*/

            } while (direction != ConsoleKey.Q);

            #region SANS tableau!
            /*//Initialisation
            Console.OutputEncoding = Encoding.UTF8;
            const string PION = "😉";
            const string VIDE = "-";
            const int TAILLE = 10;

            int position = 0;

            string direction;

            //Jeu déplacement
            do
            {
                //Affichage
                Console.Clear();
                for (int i = 0; i < TAILLE; i++)
                {
                    Console.Write((i == position) ? PION : VIDE);
                }
                Console.WriteLine();
                //Demander direction
                Console.WriteLine("Voulez-vous aller à (G)auche, à (D)roite ou (Q)uitter?");
                direction = Console.ReadLine().ToLower();

                //Gestion direction
                switch (direction)
                {
                    case "d":
                        if (position != TAILLE - 1)
                        {
                            position++;
                        }
                        break;
                    case "g":
                        if (position != 0)
                        {
                            position--;
                        }
                        break;
                }

            } while (direction != "q");*/
            #endregion
        }
    }
}