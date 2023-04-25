namespace Exo04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Version int.Parse()
            //Console.WriteLine("Entrer un nombre entier :");
            //int nbr_entier_1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entrer un second nombre entier :");
            //int nbr_entier_2 = int.Parse(Console.ReadLine());

            //int result_div_ent = nbr_entier_1 / nbr_entier_2;
            //int result_modulo = nbr_entier_1 % nbr_entier_2;
            //float div_float = nbr_entier_1 / (float)nbr_entier_2;

            //Console.WriteLine("Résultat de la division entière : ");
            //Console.WriteLine(result_div_ent);
            //Console.WriteLine("Résultat du modulo : ");
            //Console.WriteLine(result_modulo);
            //Console.WriteLine("Résultat de la division : ");
            //Console.WriteLine(div_float);
            #endregion

            #region Version int.TryParse(...)
            Console.WriteLine("Entrer un nombre entier :");
            int nbr_entier_1;
            bool is_convert = int.TryParse(Console.ReadLine(), out nbr_entier_1);
            if(is_convert == true)
            {
                Console.WriteLine("Entrer un second nombre entier :");
                int nbr_entier_2;
                is_convert = int.TryParse(Console.ReadLine(), out nbr_entier_2);
                if (is_convert == true)
                {
                    int result_div_ent = nbr_entier_1 / nbr_entier_2;
                    int result_modulo = nbr_entier_1 % nbr_entier_2;
                    float div_float = nbr_entier_1 / (float)nbr_entier_2;

                    Console.WriteLine("Résultat de la division entière : ");
                    Console.WriteLine(result_div_ent);
                    Console.WriteLine("Résultat du modulo : ");
                    Console.WriteLine(result_modulo);
                    Console.WriteLine("Résultat de la division : ");
                    Console.WriteLine(div_float);
                }
            }
            if (is_convert == false) //if (!is_convert)
            {
                Console.WriteLine("Vous deviez entrer un nombre...");
            }
            #endregion
        }
    }
}