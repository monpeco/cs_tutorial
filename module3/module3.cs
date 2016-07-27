using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void GetStudentInformation(out string first, out string last, out string birthday, out string addressLine1, out string city, out string state_Province)
        {
            Console.WriteLine("Enter the student's first name: ");
            first = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            last = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date: ");
            birthday = Console.ReadLine();
            Console.WriteLine("Enter the student's address");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the student's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the student's state_Province");
            state_Province = Console.ReadLine();
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday, string addressLine1 = "not provided", string city = "not provided", string state_Province = "not provided")
        {
            Console.WriteLine("\n\tPrint Student Details:");
            Console.WriteLine("\t{0} {1} was born on: {2}", first, last, birthday);
            Console.WriteLine("\tAnd lives in {0}, {1}, {2}", addressLine1, city, state_Province);
        }

        static void GetTeacherInformation(out string first, out string last, out string birthday, out string addressLine1, out string city, out string state_Province)
        {
            //throw new NotImplementedException("Missing GetTeacherInformation Implementation");
            Console.WriteLine("\nEnter Teacher's first name: ");
            first = Console.ReadLine();
            Console.WriteLine("Enter Teacher's last name");
            last = Console.ReadLine();
            Console.WriteLine("Enter Teacher's birth date: ");
            birthday = Console.ReadLine();
            //Console.WriteLine("Enter Teacher's address");
            //addressLine1 = Console.ReadLine();
            //Console.WriteLine("Enter Teacher's city: ");
            //city = Console.ReadLine();
            //Console.WriteLine("Enter Teacher's state_Province");
            //state_Province = Console.ReadLine();
            addressLine1 = "";
            city = "";
            state_Province = "";
        }

        static void PrintTeacherDetails(string first, string last, string birthday, string addressLine1 = "not provided", string city = "not provided", string state_Province = "not provided")
        {
            //throw new NotImplementedException("Missing PrintTeacherDetails Implementation");

            Console.WriteLine("\n\tPrint Teacher Details:");
            Console.WriteLine("\tThe teacher {0} {1} was born on: {2}", first, last, birthday);
            Console.WriteLine("\tAnd lives in {0}, {1}, {2}", addressLine1, city, state_Province);
        }


        static void GetCourseInformation(out string name, out int credits, out string duration, out string teacher)
        {
            //throw new NotImplementedException("Missing GetCourseInformation Implementation");

            Console.WriteLine("\nEnter Course's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Course's credits (Numeric value only)");
            try
            {
                credits = Convert.ToInt32(Console.ReadLine());
            }catch (FormatException forExp)
            {
                Console.WriteLine("invalid numeric value");
                credits = 0;
            }

            Console.WriteLine("Enter Course's duration: ");
            duration = Console.ReadLine();
            Console.WriteLine("Enter Course's teacher");
            teacher = Console.ReadLine();
        }

        static void PrintCourseDetails(string name, int credits, string duration, string teacher)
        {
            //throw new NotImplementedException("Missing PrintCourseDetails Implementation");

            Console.WriteLine("\n\tPrint Course Details:");
            Console.WriteLine("\tThe Course {0} (credits: {1}) has a duration of: {2}", name, credits, duration);
            Console.WriteLine("\tAnd it is teach by {0}", teacher);
        }

        static void GetUProgramInformation(out string name, out string department, out string degrees)
        {
            //throw new NotImplementedException("Missing GetUProgramInformation Implementation");

            Console.WriteLine("\nEnter UProgram's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter UProgram's Department Head");
            department = Console.ReadLine();
            Console.WriteLine("Enter UProgram's Degrees: ");
            degrees = Console.ReadLine();
        }

        static void PrintUProgramDetails(string name, string department, string degrees)
        {
            //throw new NotImplementedException("Missing PrintUProgramDetails Implementation");

            Console.WriteLine("\n\tPrint UProgram Details:");
            Console.WriteLine("\tThe UProgram {0} is from: {1}", name, department);
            Console.WriteLine("\tAnd has a Degree in {0}", degrees);
        }

        static void GetDegreeInformation(out string name, out int credits)
        {
            //throw new NotImplementedException("Missing GetDegreeInformation Implementation");

            Console.WriteLine("\nEnter Degree's name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Degree's credits required (Numeric value only):");
            try
            {
                credits = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException forExp)
            {
                Console.WriteLine("invalid numeric value");
                credits = 0;
            }

        }

        static void PrintDegreeDetails(string name, int credits)
        {
            //throw new NotImplementedException("Missing PrintDegreeDetails Implementation");

            Console.WriteLine("\n\tPrint Degree Details:");
            Console.WriteLine("\tThe Degree {0} requires: {1} credits", name, credits);
        }

        static DateTime validateBirthday(string birthdate)
        {
            //throw new NotImplementedException("Missing validateBirthday Implementation");
            CultureInfo provider = CultureInfo.InvariantCulture;
            String format = "d";
            DateTime result = DateTime.ParseExact(birthdate, format, provider);
            return result;
        }

        static void Main(string[] args)
        {

            string firstName = "";
            string lastName = "";
            string birthdate = "";
            DateTime dateOfBirth = new DateTime();
            string addressLine1 = "";
            string city = "";
            string state_Province = "";

            string name = "";
            int    credits = 0;
            string duration = "";
            string teacher = "";

            string department = "";
            string degrees = "";

            try
            {
                GetStudentInformation(out firstName, out lastName, out birthdate, out addressLine1, out city, out state_Province);

                //birthdate validation
                try
                {
                    dateOfBirth = validateBirthday(birthdate);
                }
                catch (FormatException forExp)
                {
                    Console.WriteLine("{0} is not in the correct format.", birthdate);
                    dateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                }

                PrintStudentDetails(firstName, lastName, dateOfBirth, addressLine1, city, state_Province);



                GetTeacherInformation(out firstName, out lastName, out birthdate, out addressLine1, out city, out state_Province);
                PrintTeacherDetails(firstName, lastName, birthdate);

                GetCourseInformation(out name, out credits, out duration, out teacher);
                PrintCourseDetails(name, credits, duration, teacher);

                GetUProgramInformation(out name, out department, out degrees);
                PrintUProgramDetails(name, department, degrees);

                GetDegreeInformation(out name, out credits);
                PrintDegreeDetails(name, credits);



            }catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }

            Console.WriteLine("\n\nEnd of the program");
            Console.ReadLine();
        }
    }




}
