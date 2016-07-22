using System.IO;
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Student info program");
        
        string firstName;
        string lastName;
        string birthdate;
        string addressLine1;
        string addressLine2;
        string city;
        string state_Province;
        string zip_Postal;
        string country;
        
        firstName = "Joe";
        lastName = "Smith";
        birthdate = "03/03/1997";
        addressLine1 = "9757 Bank Lane";
        addressLine2 = "Unit D";
        city = "Anderson";
        state_Province = "SC";
        zip_Postal = "29621";
        country = "US";
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("debug information:");
        Console.WriteLine("---------------------------------------");

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(birthdate);
        Console.WriteLine(addressLine1);
        Console.WriteLine(addressLine2);
        Console.WriteLine(city);
        Console.WriteLine(state_Province);
        Console.WriteLine(zip_Postal);
        Console.WriteLine(country);
        
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Progarm information:");
        Console.WriteLine("---------------------------------------");

        Console.WriteLine("Info about: {0}, {1}", lastName, firstName);
        Console.WriteLine("Birthdate: {0}", birthdate);
        Console.WriteLine("Address: {0} {1}, {2} {3} {4}", addressLine1, addressLine2, city, state_Province, zip_Postal);
        
        Console.ReadKey();
    }
}
