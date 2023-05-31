using ExoMethode_Bonus_01.Structs;

namespace ExoMethode_Bonus_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chest c1 = new Chest();
            c1.type = "Or";
            c1.quantity = 5;

            Chest c2 = new Chest() { type = "Or", quantity = 4 };
            
            Chest c3 = new Chest() { type = "Potion", quantity = 2 };

            Player joueur = new Player();

            joueur.ShowInventory();

            if (joueur.Loot(ref c1)) Console.WriteLine("Yeah!");
            if (joueur.Loot(ref c2)) Console.WriteLine("Yeah!");
            if (joueur.Loot(ref c3)) Console.WriteLine("Yeah!");
            if (joueur.Loot(ref c1)) Console.WriteLine("Yeah!");

            joueur.ShowInventory();
        }
    }
}