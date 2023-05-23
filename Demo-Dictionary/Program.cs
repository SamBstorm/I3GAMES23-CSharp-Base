namespace Demo_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<ConsoleKey, string> msg_per_key = new Dictionary<ConsoleKey, string>();

            msg_per_key.Add(ConsoleKey.G, "On va à gauche!");
            //msg_per_key.Add(ConsoleKey.G, "On va à gauche!");  //ATTENTION, le G a déjà été insérer : CRASH...
            msg_per_key.Add(ConsoleKey.D, "On va à droite!");
            msg_per_key.Add(ConsoleKey.Q, "Bye bye!");

            msg_per_key[ConsoleKey.Q] = "Au revoir!";

            ConsoleKey key;


            do
            {
                Console.Write("Veuillez utiliser");
                foreach (ConsoleKey key_dico in msg_per_key.Keys)
                {
                    Console.Write($" {key_dico},");
                }
                Console.WriteLine("\b :");
                key = Console.ReadKey(true).Key;
                if (msg_per_key.ContainsKey(key)) //ContainsKey(...) indique si la clé est présente, pour éviter de crasher
                {
                    Console.WriteLine(msg_per_key[key]);
                }
            } while (key != ConsoleKey.Q);

        }
    }
}