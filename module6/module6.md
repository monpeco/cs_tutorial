#Inheritance
###Applying Inheritance
The C# programming language does not support multiple inheritance directly. 
To inherit from base class in C#, you append your derived class name with a colon and the name of the base class.  The following example demonstrates the Manager class inheriting the Employee base class from the previous topic's UML diagram.
```c#
class Manager : Employee
{
    private char payRateIndicator;
    private Employee[] emps;
}
```