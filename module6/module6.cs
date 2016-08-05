    //Declaring Class Student
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
        // Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthdate { get; set; }

    }
    
    public class Student
    {
        TakeTest(string testName){
            testName = testName;
            Console.WriteLine("\nThe student {0}, is tanking the {1}", this.firstName, this.lastName, this.birthdate);
        }
        public string testName { get; set; }
    }
    
    public class Teacher
    {
        GradeTest(string testName)
    }    