using Demo_Methodes.Structs;

namespace Demo_Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom room = new ClassRoom();
            room.name = "Unity23";

            room.AddStudent("Samuel", "Legrain", new DateTime(1987, 9, 27),sectionName:"WEB");
        }
    }
}