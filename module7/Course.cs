using System;
//using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Course
    {
        public Course(string name)
        {
            Console.WriteLine("Creating Course");
            this.name = name;
        }

        //9 Create a method inside the Course object called ListStudents()
        public void ListStudents()
        {
            Console.WriteLine("\nInside ListStudents:");

            foreach (Student student in students)
            {
                Console.WriteLine("\twith the student {0}\n", student.firstName);
            }
        }

        public ArrayList students = new ArrayList();               //2 Create an ArrayList to replace the array and to hold students
        Teacher[] arrayTeacher = new Teacher[3];
        public string name { get; set; }
        public string duration { get; set; }
        public string teacher { get; set; }
        public Degree degree { get; set; }
        public UProgram uProgram { get; set; }
    }
}
