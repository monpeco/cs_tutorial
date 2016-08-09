using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
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
}
