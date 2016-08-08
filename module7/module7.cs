using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{

    public class Student : Person
    {
        public Student(string firstName, string lastName, string birthdate) : base(firstName, lastName, birthdate)
        {
            studensNumber++;

        }

        public void TakeTest(string testName)
        {
            this.testName = testName;
            Console.WriteLine("\nThe student {0}, is tanking the {1} test", this.firstName, this.testName);
        }
        public string testName { get; set; }
        public static int studensNumber = 0;
        //public Stack Grades = new Stack();                            //4 Create a Stack object inside the Student object
        public Stack<int> Grades = new Stack<int>();                    //4 Create a Stack object inside the Student object
    }
    
    
    

    //Declaring Course Class
    public class Course
    {
        public Course(string name)
        {
            this.name = name;
        }
        
        //9 Create a method inside the Course object called ListStudents()
        public ListStudents(){
            foreach(Student student in students) {
        	    Console.WriteLine("\nInside ListStudents with the student {0}", student.firstName);
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



    class Program
    {
        static void Main(string[] args)
        {
            Course cSharp = new Course("Programming with C#");
            
            Student joe = new Student("Joe", "Smith", "04/03/1950");    //5 Create 3 student objects
            Student bob = new Student("Bob", "Sanders", "01/08/1960");
            Student sam = new Student("Sam", "Peterson", "02/02/1970");

            //Coffee firstCoffee = (Coffee)beverages[0];
            for (int i=0, i<5; i++)                             //6 Add 5 grades to the the Stack in the each Student object
                joe.Grades.Push(i);
            for (int i=6, i<11; i++)
                bob.Grades.Push(i);}
            for (int i=0, i<12; i+=2)
                sam.Grades.Push(i);                
            
            //3 Add a Student to the Course object, you will add it to the ArrayList and not an array
            //7 Add the three Student objects to the Students ArrayList inside the Course object
            cSharp.students.add(joe); 
            cSharp.students.add(bob); 
            cSharp.students.add(sam);
            
            //8 iterate over the Students in the ArrayList and output their first and last names
        	foreach (Student student in cSharp.students)
        	{
        	    Console.WriteLine("\nfirstName: {0},\nlastName: {1}", student.firstName, student.lastName);
        	}


            //10 Call the ListStudents() method from Main()
            ListStudents();
            
            //TODO
            cSharp.degree = new Degree("Bachelor", "58");
            cSharp.uProgram = new UProgram("Information Technology", "CS", cSharp.degree);



            Console.WriteLine("\nInformation required for the Assignment");
            Console.WriteLine("The {0} Program contains the {1} degree", cSharp.uProgram.name, cSharp.degree.name);
            Console.WriteLine("The {0} degree contains the course {1}", cSharp.degree.name, cSharp.name);
            Console.WriteLine("The {0} course contains {1} students", cSharp.name, Student.studensNumber);


            Console.WriteLine("\n\nEnd of the program");
            Console.ReadLine();
        }
    }
}
