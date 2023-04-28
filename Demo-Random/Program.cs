namespace Demo_Random
{
    internal class Program
    {
        static Random RNG = new Random();   //ATTENTION!!! La déclaration de RNG se fait dan la class, pas dans le Main()
                                            //ATTENTION!!! La variable doit être static
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int nb1 = RNG.Next();      //Entre 0 et le MAX d'un int32 (2.147.483.647)
                int nb2 = RNG.Next(11);    //Entre 0 et la valeur indiquée non-inclus (de 0 à 10) 
                int nb3 = RNG.Next(5,11);  //Entre la première et la seconde valeur non-inclus (de 5 à 10)
                Console.WriteLine(nb1);
            }
        }
    }
}