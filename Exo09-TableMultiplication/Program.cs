namespace Exo09_TableMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int table = 1; table <= 9; table++)
            {
                Console.WriteLine($"Table de {table}");
                for(int multi = 1; multi <= 10; multi++)
                {
                    int calcul = table * multi;
                    Console.Write($"{table} x {multi} = {calcul} ; ");
                }
                Console.WriteLine();
            }
        }
    }
}