namespace Exo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercice 01 :
             * 
             * Créez une application console qui récupère :
             *  - votre nom
             *  - votre prénom
             *  - votre âge
             * 
             * Entre chaque récupération de valeur nettoyez la Console.
             * 
             * A la fin, la Console écrit :
             * 
             * "Bonjour à vous, [Nom] [Prénom]!"
             * "Vous ne faites pas vos [age] ans!"
             */

            Console.WriteLine("Veuillez introduire votre nom :");
            string? name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("et votre prénom :");
            string? first_name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Et quel votre age :");
            string? years_old = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Bonjour à vous, {name} {first_name}!");
            Console.WriteLine($"Vous ne faites pas vos {years_old} ans!");

            //OU 

            Console.WriteLine("Bonjour à vous, " + name + " " + first_name + "!");
            Console.WriteLine("Vous ne faites pas vos " + years_old + " ans!");

            //OU

            Console.WriteLine("Bonjour à vous, {0} {1}!", name, first_name);
            Console.WriteLine("Vous ne faites pas vos {0} ans!", years_old);
        }
    }
}