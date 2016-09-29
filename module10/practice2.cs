/*
 * Created by SharpDevelop.
 * User: Monpeco
 * Date: 28-09-2016
 * Time: 11:08 PM
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace module10_practice
{
	public class Person
    {
        // constructor
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
	    
	class Program
	{

		public static void Main(string[] args)
		{
			Console.WriteLine("Practing LINQ\n");
			
			List<Person> persons = new List<Person>();
			persons.Add(new Person("Jo","Land","01/05/78"));
			persons.Add(new Person("Sue","Dent","01/08/89"));
			persons.Add(new Person("Samuel","Dent","01/08/89"));			
			persons.Add(new Person("Ra","Koy","31/05/90"));
			
			var familyDent = from p in persons
								where p.lastName == "Dent"
								select p;
			
			Console.WriteLine("The family Dent is: ");
			
			foreach(var x in familyDent){
				Console.WriteLine(x.firstName);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
