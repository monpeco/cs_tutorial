using System;
//using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Person
    {
        public Person(string firstName, string lastName, string birthdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            //Console.WriteLine("\nfirstName: {0},\nlastName: {1}, \nbirthdate: {2}", this.firstName, this.lastName, this.birthdate);
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthdate { get; set; }
    }

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
        public Stack Grades = new Stack();
    }

    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string birthdate) : base(firstName, lastName, birthdate)
        {
            Console.WriteLine("profesor created!!");
        }

        public void GradeTest(string attitud)
        {
            this.attitud = attitud;
            Console.WriteLine("\nThe Teacher {0}, is grading the test whit a {1} attitud", this.firstName, this.attitud);
        }

        public string attitud { get; set; }

    }

    public class Degree
    {
        public Degree(string name, string credits)
        {
            this.name = name;
            this.credits = credits;
            //Console.WriteLine("\name: {0},\ncredits: {1}", this.name, this.credits);
        }
        public string name { get; set; }
        public string credits { get; set; }
    }

    public class UProgram
    {
        public UProgram(string name, string department, Degree degree)
        {
            this.name = name;
            this.department = department;
            this.degree = degree;
            //Console.WriteLine("\name: {0},\ndepartment: {1},\ndepartment: {2}", this.name, this.department, this.degree);
        }
        public string name { get; set; }
        public string department { get; set; }
        public Degree degree { get; set; }
    }

    public class Course
    {
        public Course(string name)
        {
            Console.WriteLine("Creating Course");
            this.name = name;
        }

        public void ListStudents()
        {
            Console.WriteLine("\nInside ListStudents:");

            foreach (Student student in students)
            {
                Console.WriteLine("\twith the student {0}\n", student.firstName);
            }
        }

        public ArrayList students = new ArrayList();
        Teacher[] arrayTeacher = new Teacher[3];
        public string name { get; set; }
        public string duration { get; set; }
        public string teacher { get; set; }
        public Degree degree { get; set; }
        public UProgram uProgram { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Course cSharp = new Course("Programming with C#");

            Student joe = new Student("Joe", "Smith", "04/03/1950");    //5 Create 3 student objects
            Student bob = new Student("Bob", "Sanders", "01/08/1960");
            Student sam = new Student("Sam", "Peterson", "02/02/1970");

        }
    }
}
