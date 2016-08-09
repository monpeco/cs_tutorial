using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class StudentComparer : IComparer<Student>
    {
        // return -1 if x is the smallest, 1 if y is the smallest, 0 if they're equal
        public int Compare(Student x, Student y)
        {
            return String.Compare(x.firstName.ToString(), y.firstName.ToString());
        }
    }

    class Program
    {



        static void Main(string[] args)
        {
            Course cSharp = new Course("Programming with C#");

            Student joe = new Student("Joe", "Smith", "04/03/1950");    //5 Create 3 student objects
            Student bob = new Student("Bob", "Sanders", "01/08/1960");
            Student sam = new Student("Sam", "Peterson", "02/02/1970");

            for (int i = 0; i < 5; i++) {     //6 Add 5 grades to the the Stack in the each Student object
                joe.Grades.Push(i);
            }
            for (int i = 6; i < 11; i++) {
                bob.Grades.Push(i);
            }
            for (int i = 0; i < 10; i += 2) {
                sam.Grades.Push(i);
            } 
            
            //3 Add a Student to the Course object, you will add it to the ArrayList and not an array
            //7 Add the three Student objects to the Students ArrayList inside the Course object
            cSharp.students.Add(joe);
            cSharp.students.Add(bob);
            cSharp.students.Add(sam);

            //8 iterate over the Students in the ArrayList and output their first and last names
            Console.WriteLine("\nforeach for all 3 students:");
            foreach (Student student in cSharp.students) {
                Console.WriteLine("\tfirstName: {0}\n\tlastName: {1}\n", student.firstName, student.lastName);
            }

            //10 Call the ListStudents() method from Main()
            cSharp.ListStudents();


            //see if the sort performed what you expect
            foreach (Student student in cSharp.students)
                Console.WriteLine("\tfirstName: {0}\n\tlastName: {1}\n", student.firstName, student.lastName);
            

            for (int i = 0; i < 5; i++)
                Console.WriteLine("joe: {0}", joe.Grades.Pop());

            for (int i = 6; i < 11; i++)
                Console.WriteLine("bob: {0}", bob.Grades.Pop());

            for (int k = 0; k < 10; k += 2)
                Console.WriteLine("sam: {0}", sam.Grades.Pop());
                

            Console.WriteLine("\n\nEnd of the program");
            Console.ReadLine();
        }
    }
}
