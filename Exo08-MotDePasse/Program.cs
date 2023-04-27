namespace Exo08_MotDePasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MDP = "Test1234=";
            string insert_password;
            ushort count = 0;
            string message = "Mot de passe :";
            do {
                Console.WriteLine(message);
                insert_password = Console.ReadLine();
                message = $"{insert_password} n'est pas le bon mot de passe.\nMot de passe :";
                count++;
            } while (insert_password != MDP && count < 3);
            if (MDP == insert_password)
            {
                Console.WriteLine("Bienvenue!");
            }
            else 
            {
                Console.WriteLine("Trop de tentatives ont échoué!");
            }
        }
    }
}