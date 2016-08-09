using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
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
}
