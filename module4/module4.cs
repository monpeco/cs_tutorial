    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

class Program
    {
        //Declaring Struct Student
        public struct Student
        {
            // constructor
            Student(string firstName, string lastName, string birthdate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthdate = birthdate;
            }
            // fields
            public string firstName;
            public string lastName;
            public string birthdate;
        }



        //Declaring Struct Teacher
        public struct Teacher
        {
            // constructor
            Teacher(string firstName, string lastName, string birthdate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthdate = birthdate;
            }
            // fields
            public string firstName;
            public string lastName;
            public string birthdate;
        }


        //Declaring Struct Program
        public struct UProgram
        {
            // constructor
            UProgram(string name, string department, string degrees)
            {
                this.name = name;
                this.department = department;
                this.degrees = degrees;
            }
            // fields
            string name;
            string department;
            string degrees;
        }


        //Declaring Struct Course
        public struct Course
        {
            // constructor
            Course(string name, int credits, string duration, string teacher)
            {
                this.name = name;
                this.credits = credits;
                this.duration = duration;
                this.teacher = teacher;
            }
            // fields
            string name;
            int credits;
            string duration;
            string teacher;
        }


        static void getStudentData(out Student student)
        {
            Console.WriteLine("\nEnter Student's first name: ");
            student.firstName = Console.ReadLine();
            Console.WriteLine("\nEnter Student's last name: ");
            student.lastName = Console.ReadLine();
            Console.WriteLine("\nEnter Student's birth date: ");
            student.birthdate = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Do not create properties at this time.
            //Create an array to hold 5 student structs.
            Student[] arrayStudent = new Student[5];

            arrayStudent[0].firstName = "Mike";
            arrayStudent[0].lastName = "Sanders";
            arrayStudent[0].birthdate = "05/04/1955";

            Console.WriteLine("\nStudent Struct");
            Console.WriteLine("\nfirstName: {0},\nlastName: {1}, \nbirthdate: {2}", arrayStudent[0].firstName, arrayStudent[0].lastName, arrayStudent[0].birthdate);

            //Challenge 
            for (int index=0; index < arrayStudent.Length; index++)
            {
                Console.WriteLine("\nStudent {0}", index+1);
                getStudentData(out arrayStudent[index]);
            }

            Console.WriteLine("\nAll Student's info");
            foreach (Student student in arrayStudent)
            {
                Console.WriteLine("\nStudent's first name: {0}", student.firstName);
                Console.WriteLine("\nStudent's last name: {0}", student.lastName);
                Console.WriteLine("\nStudent's birth date: {0}\n", student.birthdate);

            }
            Console.WriteLine("\n\nEnd of the program");
            Console.ReadLine();
        }
    }
}