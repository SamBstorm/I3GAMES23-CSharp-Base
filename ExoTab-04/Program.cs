namespace ExoTab_04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Création du tableau
            string[] students = { "Alexia", "Loriane", "Naël", "Sonia", "Tonia", "Audrey", "Cécile", "Carol", "Hafsa", "Feryel" };

            //inversion du tableau
            for (int i = 0; i < students.Length/2; i++)
            {
                string temp = students[i];
                students[i] = students[students.Length - 1 - i];
                students[students.Length - 1 - i] = temp;
            }

            //affichage du tableau
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

}