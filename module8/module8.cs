using System;
using System.Collections;
using System.Collections.Generic;
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
        public Stack<int> Grades = new Stack<int>();  //3) Create a Stack<T> object, inside the Student object, called Grades, to store test scores.
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

        //8Create a method inside the Course object called ListStudents() that contains the foreach loop.
        public void ListStudents()
        {
            Console.WriteLine("\nInside ListStudents:");

            //7) Using a foreach loop, iterate over the Students in the List<T> and output their first and last names to the console window. 
            //(For this exercise, casting is no longer required.  Also, place each student name on its own line)
            foreach (Student student in studentsList)
            {
                Console.WriteLine("\nStudent's First Name: {0} \n\tLast Name: {1}", student.firstName, student.lastName);
            }
        }

        //6) Add the three Student objects to the List<T> inside the Course object.
        public void AddStudent(Student s)
        {
            studentsList.Add(s);
            Console.WriteLine("{0} added to the List", s.firstName);

        }
        public List<Student> studentsList = new List<Student>();       //1) Create a List<T>, to replace the ArrayList and to hold students
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

            //4) Create 3 student objects.
            Student joe = new Student("Joe", "Smith", "04/03/1950");
            Student bob = new Student("Bob", "Sanders", "01/08/1960");
            Student sam = new Student("Sam", "Peterson", "02/02/1970");

            //6) Add the three Student objects to the List<T> inside the Course object.
            cSharp.AddStudent(joe);
            cSharp.AddStudent(bob);
            cSharp.AddStudent(sam);

            //5) Add 5 grades to the the Stack<T> in the each Student object. 
            //(this does not have to be inside the constructor because you may not have grades for a student when you create a new student.)
            foreach (Student student in cSharp.studentsList)
            {
                Random rnd = new Random();
                Console.WriteLine("\nThe grades for {0} are:", student.firstName);
                for (int i=0; i<5; i++)
                {                
                    int grade = rnd.Next(1, 10);
                    student.Grades.Push(grade);
                    Console.WriteLine("{0}", grade);
                }
            }

            //9) Call the ListStudents() method from Main().
            cSharp.ListStudents();

            Console.WriteLine("\n\nEnd of the program");
            Console.ReadLine();
        }
    }
}
