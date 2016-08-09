using System;
//using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, string birthdate) : base(firstName, lastName, birthdate)
        {
            Console.WriteLine("Creating Student");
            studensNumber++;
        }

        public void TakeTest(string testName)
        {
            this.testName = testName;
            Console.WriteLine("The student {0}, is tanking the {1} test", this.firstName, this.testName);
        }
        public string testName { get; set; }
        public static int studensNumber = 0;
        public Stack Grades = new Stack();                   //4 Create a Stack object inside the Student object
    }
}
