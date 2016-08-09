using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Person
    {
        // constructor
        public Person(string firstName, string lastName, string birthdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            Console.WriteLine("\nfirstName: {0},\nlastName: {1}, \nbirthdate: {2}", this.firstName, this.lastName, this.birthdate);
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthdate { get; set; }
    }
}
