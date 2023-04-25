namespace Demo_Operateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Opérateur déplacement de bits
            /* //854 est traité en binaire par le PC
             int i = 854; //    0    0     1   1   0  1  0  1 0 1 1 0
                          // 2048 1024   512 256 128 64 32 16 8 4 2 1
             Console.WriteLine(i);

             //Si on déplace de 2 sur la droite : on perd des informations (le 1 et 0 de la droite) 
             i = i >> 2; //    0    0     0   0   1  1  0  1 0 1 0 1
                         // 2048 1024   512 256 128 64 32 16 8 4 2 1

             Console.WriteLine(i);

             //Si on déplace de 2 sur la gauche : on ne récupère pas les informations perdue
             i = i << 2; //    0    0     1   1   0  1  0  1 0 1 0 0
                         // 2048 1024   512 256 128 64 32 16 8 4 2 1

             Console.WriteLine(i);*/
            #endregion

            #region Opérateur ternaire
            Console.WriteLine("Veuillez indiquer votre âge :");
            int age;
            bool is_convert = int.TryParse(Console.ReadLine(), out age);
            if(is_convert)
            {
                string status = (age < 18) ? "mineur" : "majeur";

                Console.WriteLine($"Vous êtes {status}.");
                Console.WriteLine($"Vous avez {age} an{((age > 1)? "s" : "")}.");
            }
            else
            {
                Console.WriteLine("Apprend à lire !?");
            }
            #endregion

        }
    }
}