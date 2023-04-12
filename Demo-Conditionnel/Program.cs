namespace Demo_Conditionnel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est votre age ?");
            string? age_str = Console.ReadLine();

            int age;
            bool age_isConvert = int.TryParse(age_str, out age);

            if(age_isConvert == true && age >= 18)
            {
                Console.WriteLine("Quel est votre nationalité ?");
                string? nationalite = Console.ReadLine();
                if(nationalite.ToUpper() == "Belge".ToUpper())
                {
                    Console.WriteLine("Bienvenu sur notre site concours!");
                }
                else
                {
                    Console.WriteLine($"Votre nationalité : '{nationalite}' n'est pas prise en charge...");
                }
            }
            else
            {
                Console.WriteLine("Reviens quand tu auras l'âge...");
            }
        }
    }
}