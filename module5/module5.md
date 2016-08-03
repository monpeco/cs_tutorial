#Introducing Object-Oriented Programming in C#
###Creating Classes and Members


```c#
//Declaring a Class
public class DrinksMachine
{
    // Methods, fields, properties, and events go here.
}
```

###Adding Members to a Class
Within your class, you can add methods, fields, properties, and events to define the behaviors and characteristics of your type, as shown in the following example:

```c#
// Defining Class Members
public class DrinksMachine
{
   // The following statements define a property with a private field.
   private string _location;
   public string Location
   {
      get
      {
         return _location;
      }
      set
      {
         if (value != null) 
            _location = value;
      }
   }
   // The following statements define properties.
   public string Make {get; set;}
   public string Model {get; set;}
   // The following statements define methods.
   public void MakeCappuccino()
   {
      // Method logic goes here.
   }
   public void MakeEspresso()
   {
      // Method logic goes here.
   }
   // The following statement defines an event. The delegate definition is not shown.
   public event OutOfBeansHandler OutOfBeans;
}
```

###Partial Classes
Partial classes are useful when:
* When working on large projects, spreading a class over separate files enables multiple programmers to work on the same class at the same time.
* When working with automatically generated source. Visual Studio uses this approach when your application uses Windows Forms, Web service wrapper code, etc. Microsoft recommends that you do not modify the auto-generated code for these components as it could be overwritten when the application is compiled or the project files changed.  Instead, you can create another portion of the class, as a partial class with the same name, and make your additions and edits there.


```c#
public partial class DrinksMachine
{

   public void MakeCappuccino()
   {
      // Method logic goes here.
   }
}

public partial class DrinksMachine
{

   public void MakeEspresso()
   {
      // Method logic goes here.
   }
}
```
###Instantiating Classes

```c#
// Instantiating a Class
DrinksMachine dm = new DrinksMachine();
```
When you instantiate a class in this way, you are actually doing two things:

* You are creating a new object in memory based on the DrinksMachine type.
* You are creating an object reference named dm that refers to the new DrinksMachine object.

###Type inference
When you create your object reference, instead of explicitly specifying the DrinksMachine type, you can allow the compiler to deduce the type of the object at compile time. This is known as type inference. To use type inference, you create your object reference by using the var keyword, as shown in the following example:
```c#
// Instantiating a Class by Using Type Inference
var dm = new DrinksMachine();
```
After you have instantiated your object, you can use any of the members—methods, fields, properties, and events—that you defined within the class, as shown in the following example:

```c#
// Using Object Members
var dm = new DrinksMachine();
dm.Make = "Fourth Coffee";
dm.Model = "Beancrusher 3000";
dm.Age = 2;
dm.MakeEspresso();
```

--

#Encapsulation in C#

###Private vs Public vs Protected vs Internal

* public:	The type is available to code running in any assembly that references the assembly in which the class is contained.
* internal:	The type is available to any code within the same assembly, but not available to code in another assembly.
* private:	The type is only available to code within the class that contains it. You can only use the private access modifier with nested classes. This is the default value if you do not specify an access modifier.
* protected:	The type is only accessible within its class and by derived class instances.

###Properties

The following code shows an example of properties being declared in the DrinksMachine class:

```c#
public class DrinksMachine
{
   // private member variables
   private int age;
   private string make;


   // public properties 
   public int Age 
   { 
      get
      {
         return age;
      }
      set
      { 
         age = value; 
      }
   }
   public string Make
   { 
      get
      {
         return make;
      }
      set
      { 
         make = value; 
      }
   }
   
   // auto-implemented property
   public string Model { get; set; }

      // Constructors
   public DrinksMachine(int age)
   {
      this.Age = age;
   }
   public DrinksMachine(string make, string model)
   {
      this.Make = make;
      this.Model = model;
   }
   public DrinksMachine(int age, string make, string model)
   {
      this.Age = age;
      this.Make = make;
      this.Model = model;
   }
}
```

The properties are Age, Make, and Model.   These properties would be backed by private member variables called age, make, and model.
Property Types

You can create two basic types of properties in a C# class.  Read only or read-write: (Technically you can also create a write-only property but that is not common.

* A get property accessor is used to return the property value

* A set accessor is used to assign a new value.  (Omitting this property makes it read only)

* A value keyword is used to define the "value" being assigned by the set accessor.

* Properties that do not implement a set accessor are read only.

* For simple properties that require no custom accessor code, consider the option of using auto-implemented properties.

Auto-implemented properties make property-declaration more concise when creating simple accessor methods (getter and setter). They also enable client code to create objects. When you declare a properties this way, the compiler will automatically create a private, anonymous field in the background that can only be accessed through the get and set accessors.
 
The following example demonstrates auto-implemented properties:

```c#
    // Auto-implemented properties 
    public double TotalPurchases { get; set; }
    public string Name { get; set; }
    public int CustomerID { get; set; }
```

###Using Constructors
If you take a look at the topic on Creating Classes, you'll notice that instantiate a class we used this line of code:

```c#
DrinksMachine dm = new DrinksMachine();
```
Constructors are often used to specify initial or default values for data members within the new object, as shown by the following example:


```c#
// Adding a Constructor
public class DrinksMachine
{
   public int Age { get; set; }
   public DrinksMachine()
   {
      Age = 0;
   }
}
```
The following example shows how to add multiple constructors to a class:


```c#
// Adding Multiple Constructors
public class DrinksMachine
{
   public int Age { get; set; }
   public string Make { get; set; }
   public string Model { get; set; }
   public DrinksMachine(int age)
   {
      this.Age = age;
   }
   public DrinksMachine(string make, string model)
   {
      this.Make = make;
      this.Model = model;
   }
   public DrinksMachine(int age, string make, string model)
   {
      this.Age = age;
      this.Make = make;
      this.Model = model;
   }
}
```
Consumers of your class can use any of the constructors to create instances of your class, depending on the information that is available to them at the time. For example:


```c#
// Calling Constructors
var dm1 = new DrinksMachine(2);
var dm2 = new DrinksMachine("Fourth Coffee", "BeanCrusher 3000");
var dm3 = new DrinksMachine(3, "Fourth Coffee", "BeanToaster Turbo");
```

#Creating Static Classes and Members
A static class is a class that cannot be instantiated. To create a static class, you use the static keyword. Any members within the class must also use the static keyword, as shown in the following example:

```c#
// Static Classes
public static class Conversions
{
   public static double PoundsToKilos(double pounds)
   {
      // Convert argument from pounds to kilograms
      double kilos = pounds * 0.4536;
      return kilos;
   }
   public static double KilosToPounds(double kilos)
   {
      // Convert argument from kilograms to pounds
      double pounds = kilos * 2.205;
      return pounds;
   }
}
```
To call a method on a static class, you call the method on the class name itself instead of on an instance name, as shown by the following example:


```c#
//Calling Methods on a Static Class
double weightInKilos = 80;
double weightInPounds = Conversions.KilosToPounds(weightInKilos);
```
###Static Members
Non-static classes can include static members. This is useful when some behaviors and characteristics relate to the instance (instance members), while some behaviors and characteristics relate to the type itself (static members).
To declare a static member you use the static keyword before the return type of the member, as shown by the following example:


```c#
// Static Members in Non-static Classes
public class DrinksMachine
{
   public int Age { get; set; }
   public string Make { get; set; }
   public string Model { get; set; }
   public static int CountDrinksMachines()
   {
      // Add method logic here.
   }
}
```
###Anonymous classes
To create an anonymous class. you simply use the new keyword followed by a pair of braces to define fields and values for the class.  The following is an example:

```c#
anAnonymousObject = new { Name = "Tom", Age = 65 };
```
Because our anonymous class doesn't have a name,  how can you create an object of that type and assign an instance of the class to it? In the preceding code example, what should the type of the object variable anAnonymousObject be?  As a result of the way anonymous classes work, you don’t know, which is precisely the point of anonymous classes.

This doesn't truly present a problem however, as long as you declare anAnonymousObject as an implicitly typed variable by using the var keyword as shown here:

```c#
var anAnonymousObject = new { Name = "Tom", Age = 65 };
```
Once instantiated, you can access the fields in the object by using dot notation, as shown in this example:

```c#
Console.WriteLine("Name: {0} Age: {1}", anAnonymousObject.Name, anAnonymousObject.Age};
```
Once created, you have the option to create other instances of the same anonymous class but with different values:

```c#
var secondAnonymousObject = new { Name = "Hal", Age = 46 };
```
The C# compiler will look at the names, types, number, and the order of the fields in the object in order to determine whether two instances of an anonymous class have the same type or not.  In our two examples, both objects contain the same number of fields, the same name and the same type, in the same order.  As a result, both variables are instances of the same anonymous class. This means that you can assign anAnonymousObject to the secondAnonymousObject or vice versa:


```c#
secondAnonymousObject = anAnonymousObject;
```
Note:  There are quite a few restrictions on the contents of an anonymous class:
* anonymous classes can contain only public fields
* the fields must all be initialized
* fields cannot be static
* you cannot define any methods for them

###Region
lets you specify a block of code that you can expand or collapse when using the outlining feature of the Visual Studio Code Editor.

```c#
      #region MyClass definition
public class MyClass 
{  
    static void Main() 
    {
    }
}
#endregion

```

