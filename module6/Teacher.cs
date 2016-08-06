using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
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
}
