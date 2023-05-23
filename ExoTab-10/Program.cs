namespace ExoTab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nb_croissants = new List<int>() { 1 , 3 ,  5 , 5 , 6 };

            foreach (int number in nb_croissants)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("Quelle valeur ajouter ?");
            int nb_ajout = int.Parse(Console.ReadLine());

            /*if(nb_ajout >= nb_croissants[nb_croissants.Count - 1])
            {
                nb_croissants.Add(nb_ajout);
            }
            else
            {
                nb_croissants.Add(nb_croissants[nb_croissants.Count - 1]);
                for (int i = nb_croissants.Count - 3; i >= 0; i--) //Initialisation par la fin Attention : count - 1 est la copie du nombre déjà analysé (ligne 18), count - 2 est le nombre déjà analysé (ligne 12), donc count - 3 est le prochain nombre à vérifier
                {
                    if(nb_croissants[i] > nb_ajout)
                    {
                        nb_croissants[i + 1] = nb_croissants[i];
                        if(i == 0)
                        {
                            nb_croissants[0] = nb_ajout;
                        }
                    }
                    else
                    {
                        nb_croissants[i + 1] = nb_ajout;
                        i = 0;
                    }
                }
            }*/

            int position = 0;
            bool found = false;

            for (int i = 0; i < nb_croissants.Count && !found; i++) { 
                if(nb_ajout <= nb_croissants[i])
                {
                    position = i;
                    found = true;
                }
            }
            if (found)
            {
                nb_croissants.Insert(position, nb_ajout);
            }
            else
            {
                nb_croissants.Add(nb_ajout);
            }

            foreach (int number in nb_croissants)
            {
                Console.Write($"{number} ");
            }

        }
    }
}