namespace Demo_Enum
{
    public enum LightSignalColor { rouge, vert, orange }

    public struct LightSignal
    {
        public LightSignalColor currentColor;

        public void ChangeColor()
        {
            switch (currentColor) { 
                case LightSignalColor.rouge:
                    currentColor = LightSignalColor.vert;
                    break;
                case LightSignalColor.orange:
                    currentColor = LightSignalColor.rouge;
                    break;
                case LightSignalColor.vert:
                    currentColor = LightSignalColor.orange;
                    break;
            }
        }

        public void ShowColor()
        {
            switch (currentColor) { 
                case LightSignalColor.rouge:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case LightSignalColor.orange:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case LightSignalColor.vert:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
            }
            Console.Clear();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LightSignal feuRouge = new LightSignal();

            Console.WriteLine("Veuillez choisir une couleur parmis les choix suivant :");
            foreach (string colorName in Enum.GetNames<LightSignalColor>())
            {
                Console.WriteLine(colorName);
            }
            string userColor = Console.ReadLine();

            feuRouge.currentColor = Enum.Parse<LightSignalColor>(userColor);

            for (int i = 0; i < 200; i++) {
                feuRouge.ShowColor();
                Thread.Sleep(5000);
                feuRouge.ChangeColor();
            }
        }
    }
}