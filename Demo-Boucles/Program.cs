using System.Text;

namespace Demo_Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Démo While : Simple boucle
            //Console.OutputEncoding = Encoding.UTF8; // Pour changer l'encodage de la Console (Permet les Smiley!)
            ////1. Initialisation de la variable : Elle doit avoir une valeur de départ avant la boucle!
            //int x = 0;

            ////2. Condition sur la variable : Selon la condition, on entre dans la boucle ou on passe à la suite
            //while (x < 10)
            //{
            //    Console.WriteLine($"x vaut : {x}");
            //    //3. Modification de la variable dans la boucle : Si la valeur ne change pas, on reste bloqué à jamais dans la boucle
            //    x++;                                    // x = x + 1
            //}

            //Console.WriteLine($"Au final x vaudra : {x} 😉👍"); 
            #endregion

            #region Démo While : boucle blocante
            //Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10):");
            //string nb1_str = Console.ReadLine();
            //short nb1;
            //bool is_convert = short.TryParse(nb1_str, out nb1);
            //while (!is_convert)
            //{
            //    Console.WriteLine($"{nb1_str} n'est pas un nombre.");
            //    Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10):");
            //    nb1_str = Console.ReadLine();
            //    is_convert = short.TryParse(nb1_str, out nb1);
            //}
            //while (nb1 < 1 || nb1 > 10)
            //{
            //    Console.WriteLine("Ce n'est pas un nombre entre 1 et 10...😔");
            //    nb1_str = Console.ReadLine();
            //    is_convert = short.TryParse(nb1_str, out nb1);
            //    while (!is_convert)
            //    {
            //        Console.WriteLine($"{nb1_str} n'est pas un nombre.");
            //        Console.WriteLine("Veuillez introduire un nombre (entre 1 et 10):");
            //        nb1_str = Console.ReadLine();
            //        is_convert = short.TryParse(nb1_str, out nb1);
            //    }
            //}
            //Console.WriteLine("C'est bien un nombre entre 1 et 10!");
            #endregion

            #region Démo Do...While : Blocante

            //string nb1_str;
            //short nb1;
            //bool is_convert;
            //string message = "Veuillez introduire un nombre (entre 1 et 10):";
            //do {
            //    Console.WriteLine(message);
            //    nb1_str = Console.ReadLine();
            //    message = $"{nb1_str} n'est pas un nombre.\nVeuillez introduire un nombre (entre 1 et 10):";
            //    is_convert = short.TryParse(nb1_str, out nb1);
            //}
            //while (!is_convert) ;

            #endregion

            #region Démo For(...;...;...) : Simple boucle

            //const string MDP = "Test1234=";
            //Console.WriteLine("Mot de passe :");
            //string insert_password = Console.ReadLine();
            //for (int i = 1; i < 3 && insert_password != MDP; i++)
            //{
            //    Console.WriteLine($"{insert_password} n'est pas le bon mot de passe...\nMot de passe :"); 
            //    insert_password = Console.ReadLine();
            //}
            //if( insert_password == MDP ) {
            //    Console.WriteLine("Bienvenue!");
            //}
            //else { Console.WriteLine("Trop de tentatives ont échoué..."); }

            #endregion

            #region Démo Valeur Approximative (double et float)

            //Attention, cela va donner de mauvaises valeurs
            for (double i = 0.0; i <= 20.0; i+= 0.1)
            {
                Console.WriteLine(i);
            }

            //Une des solutions pour contourner...
            for (int i = 0; i <= 200; i++)
            {
                Console.WriteLine(i / 10D);
            }

            #endregion
        }
    }
}