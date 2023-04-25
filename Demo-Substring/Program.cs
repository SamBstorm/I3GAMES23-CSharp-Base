namespace Demo_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello, World!";

            //"H e l l o , _ W o r l d "
            // 0 1 2 3 4 5 6 7 8 9 1011

            Console.WriteLine(message);
            Console.WriteLine(message.Substring(0,5));
            Console.WriteLine(message.Substring(7,5));
        }
    }
}