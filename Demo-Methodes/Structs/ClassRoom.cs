using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methodes.Structs
{
    public struct ClassRoom
    {
        public string name;
        public List<Student> students;

        public void AddStudent(string firstName, string lastName, DateTime birthDate, int yearResult = 0, string sectionName = "Non-inscrit")
        {
            students ??= new List<Student>();

            Student student;
            student.firstName = firstName;
            student.lastName = lastName;
            student.birthDate = birthDate;
            student.yearResult = yearResult;
            student.sectionName = sectionName;

            students.Add(student);
        }
    }
}
