namespace Demo_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { 
                /*0*/   "Naël", 
                /*1*/   "Cécile",
                /*2*/   "Tonia",
                /*3*/   "Hafsa",
                /*4*/   "Carol",
                /*5*/   "Djihen",
                /*6*/   "Btisam",
                /*7*/   "Sonia",
                /*8*/   "Audrey",
                /*9*/   "Feryel",
                /*10*/  "Loriane",
                /*11*/  "Alexia"
            };

            Console.WriteLine($"Les Unity23 ont comme délégués : {students[3]} et {students[11]}.");

            Console.WriteLine($"La classe est constituée de : ");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"\t{students[i]}");
            //}

            foreach (string student_name in students)
            {
                Console.WriteLine(student_name);
            }
        }
    }
}