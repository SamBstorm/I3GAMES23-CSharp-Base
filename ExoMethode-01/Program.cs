using ExoMethode_01.Structs;

namespace ExoMethode_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius current_celsius = new Celsius() { temperature = 20 };

            Fahrenheit current_fahrenheit = current_celsius.Convert();

            Console.WriteLine($"{current_celsius.temperature}°C correspond à {current_fahrenheit.temperature}°F");

            Fahrenheit tomorrow_fahrenheit = new Fahrenheit() { temperature = 81 };

            Celsius tomorrow_celsius = tomorrow_fahrenheit.Convert();

            Console.WriteLine($"Demain : {tomorrow_celsius.temperature}°C correspond à {tomorrow_fahrenheit.temperature}°F");
        }
    }
}