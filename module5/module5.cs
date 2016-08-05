using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    //Declaring Class Student
    public class Teacher
    {
        // constructor
        public Teacher(string firstName, string lastName, string birthdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            //Console.WriteLine("\nfirstName: {0},\nlastName: {1}, \nbirthdate: {2}", this.firstName, this.lastName, this.birthdate);
        }
        // Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthdate { get; set; }

    }

    //Declaring Class Student
    public class Student
    {
        // constructor
        public Student(string firstName, string lastName, string birthdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            studensNumber++;
            //Console.WriteLine("\nfirstName: {0},\nlastName: {1}, \nbirthdate: {2}", this.firstName, this.lastName, this.birthdate);

        }
        //static fields
        public static int studensNumber = 0;
        // fields
        private string _firstName;
        private string _lastName;
        private string _birthdate;

        // property with a private field
        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value != null)
                    _firstName = value;
            }
        }

        public string lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value != null)
                    _lastName = value;
            }
        }

        public string birthdate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                if (value != null)
                    _birthdate = value;
            }
        }

    }

    //Declaring Course Class
    public class Course
    {
        public Course(string name)
        {
            this.name = name;
        }

        public  Student this[int index]
        {
            get { return this.arrayStudent[index]; }
            set { this.arrayStudent[index] = value; }
        }
        public Teacher this[int index,int i]
        {
            get { return this.arrayTeacher[index]; }
            set { this.arrayTeacher[index] = value; }
        }
        Student[] arrayStudent = new Student[3];
        Teacher[] arrayTeacher = new Teacher[3];
        public string name { get; set; }
        public string duration { get; set; }
        public string teacher { get; set; }
        public Degree degree { get; set; }
        public UProgram uProgram { get; set; }
    }

    //Declaring Class Student
    public class Degree
    {
        // constructor
        public Degree(string name, string credits)
        {
            this.name = name;
            this.credits = credits;
            //Console.WriteLine("\name: {0},\ncredits: {1}", this.name, this.credits);
        }

        // Properties
        public string name { get; set; }
        public string credits { get; set; }
    }

    //Declaring Class Student
    public class UProgram
    {
        // constructor
        public UProgram(string name, string department, Degree degree)
        {
            this.name = name;
            this.department = department;
            this.degree = degree;
            //Console.WriteLine("\name: {0},\ndepartment: {1},\ndepartment: {2}", this.name, this.department, this.degree);

        }

        // Properties
        public string name { get; set; }
        public string department { get; set; }
        public Degree degree { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student joe = new Student("Joe", "Smith", "04/03/1950");
            Student bob = new Student("Bob", "Sanders", "01/08/1960");
            Student sam = new Student("Sam", "Peterson", "02/02/1970");

            Course cSharp = new Course("Programming with C#");
            cSharp[0] = joe;
            cSharp[1] = bob;
            cSharp[2] = sam;
            cSharp[0, 0] = new Teacher("Jim", "Street", "12/05/1950");
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
