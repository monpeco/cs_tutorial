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
        Teacher(string firstName, string lastName, string birthdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
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
        }
        //static fields
        static int studensNumber = 0;
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
        public Course()
        {

        }
        Student[] arrayStudent = new Student[3];
        Teacher[] arrayTeacher = new Teacher[3];
        public string name { get; set; }
        public string lastName { get; set; }
        public string birthdate { get; set; }
    }

    //Declaring Class Student
    public class Degree
    {
        // constructor
        Degree(string name, string credits)
        {
            this.name = name;
            this.credits = credits;
        }

        // Properties
        public string name { get; set; }
        public string credits { get; set; }
        //public Course course {get; set;}
        //public Course course ;

    }

    //Declaring Class Student
    public class UProgram
    {
        // constructor
        UProgram(string name, string department, Degree degrees)
        {
            this.name = name;
            this.department = department;
            this.degrees = degrees;
        }

        // Properties
        public string name { get; set; }
        public string department { get; set; }
        //public string degrees { get; set; }
        public Degree degrees { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Student joe = new Student("Joe", "Smith", "04/03/1950");
            Student bob = new Student("Bob", "Sanders", "01/08/1960");
            Student sam = new Student("Sam", "Peterson", "02/02/1970");
            Console.WriteLine("\n\nEnd of the program");
            Console.ReadLine();
        }
    }
}
