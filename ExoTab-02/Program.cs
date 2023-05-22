namespace ExoTab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 10;
            int[] tab = new int[TAILLE];
            //      [2,4,8,0,0,0,0,0,0,0]
            //index :0 1 2 3 4 5 6 7 8 9 

            tab[0] = 2;
            for (int i = 1;i < TAILLE; i++)
            {
                tab[i] = tab[i - 1] * 2;
            }

            foreach(int chiffre in tab)
            {
                Console.WriteLine(chiffre);
            }
            #region Comment fonctionne le foreach
            /*
            for (int i = 0; i < tab.Length; i++)
            {
                int chiffre = tab[i];
                Console.WriteLine(chiffre);
            }
            */
            #endregion
        }
    }
}