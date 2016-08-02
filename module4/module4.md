#Introducing Arrays
###Declaring Methods
An array is a set of objects that are grouped together and managed as a unit. 
+ The rank of an array is the number of dimensions in the array.
+ Arrays of a particular type can only hold elements of that type. 
+ If you need to manipulate a set of unlike objects or value types, consider using one of the collection types that are defined in the System.Collections namespace.


###Creating and Using Single Dimension Arrays
When you declare an array, you specify the type of data that it contains and a name for the array. Declaring an array brings the array into scope, but does not actually allocate any memory for it. The CLR physically creates the array when you use the new keyword. At this point, you should specify the size of the array.
```c#
int[] arrayName = new int[10];

int[] arrayName = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
```

###Accessing Data in an Arrays
```c#
//Accessing Data by Index
int[] oldNumbers = { 1, 2, 3, 4, 5 };
//number will contain the value 3
int number = oldNumbers[2];
```
Note: Arrays are zero-indexed, so the first element in any dimension in an array is at index zero. The last element in a dimension is at index N-1, where N is the size of the dimension. If you attempt to access an element outside this range, the CLR throws an IndexOutOfRangeException exception. 

You can iterate through an array by using a for loop. You can use the Length property of the array to determine when to stop the loop.
```c#
//Iterating Over an Array
int[] oldNumbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < oldNumbers.Length; i++)
{
    int number = oldNumbers[i];
    ...
}
```
--
##Multidimensional arrays
You declare a multidimensional array variable just as you declare a single-dimensional array, but you separate the dimensions by using commas.
```c#
// Create an array that is 10 long(rows) by 10 wide(columns)
int[ , ] arrayName = new int[10,10];

//Access the element in the first row and second column
int value2 = arrayName[0, 1];
```
###Jagged arrays
A jagged array is simply an array of arrays, and the size of each array can vary. Jagged arrays are useful for modeling sparse data structures where you might not always want to allocate memory for every item if it is not going to be used. The following code example shows how to declare and initialize a jagged array. Note that you must specify the size of the first array, but you must not specify the size of the arrays that are contained within this array. You allocate memory to each array within a jagged array separately, by using the new keyword.
```c#
int[][] jaggedArray = new int[10][];
jaggedArray[0] = new Type[5]; // Can specify different sizes.
jaggedArray[1] = new Type[7];
...
jaggedArray[9] = new Type[21];
```
###Access multidimensional arrays
```c#
int[,] twoDArray = {{3,2},{1,2},{5,9}}
for (int i = 0, i < twoDArray.Getlength(0); i++{
    for (int j = 0, j < twoDArray.Getlength(0); j++{
        int value = twoDArray[0, 1];
        Console.WriteLine(value.ToString());
    }
}
```

--
#Introducing enums
An enumeration type, or enum, is a structure that enables you to create a variable with a fixed set of possible values.
A best practice would be to define your enum directly within a namespace so that all classes in that namespace will have access to it, if needed. You can also nest your enums within classes or structs.
By default enum values start at 0 and each successive member is increased by a value of 1.

###Creating and Using Enums
```c#
enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
```
By default enum values start at 0 and each successive member is increased by a value of 1.  As a result, the previous enum 'Day' would contain the values:

Sunday = 0
Monday = 1
Tuesday = 2
etc.

You can change the default by specifying a starting value for your enum as in the following example.
```c#
enum Day { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
```
In this example, Sunday is given the value 1 instead of the detaul 0.  Now Monday is 2, Tuesday is 3, etc.
In order to change the default data type of your enum, you precede the list with a data type from the list above, such as:
```c#
enum Day : short { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
```
It's important to note that you will be required to use an explicit cast if you want to convert from an enum type to an integral type. Consider this example where the statement assigns the enumerator Sun to an int type, with a cast, to convert from enum to int.
```c#
int x = (int)Day.Sun;
```
###Using an Enum
Declaration of a Enum must be outside of any method, for example in the class definition.
```c#
Day favoriteDay = Day.Friday;
```
###Using Enum Names and Values Interchangeably

```c#
// Set an enum variable by name.
Day favoriteDay = Day.Friday;
// Set an enum variable by value. 
Day favoriteDay = (Day)4;
```

#Introducing structs
###Creating a Struct

```c#
//Declaring a Struct 
public struct Coffee 
{ 
    public int Strength; 
    public string Bean; 
    public string CountryOfOrigin; 
    // Other methods, fields, properties, and events. 
}
```
* Access Modifier Details
public - The type is available to code running in any assembly.
internal - The type is available to any code within the same assembly, but not available to code in another assembly. This is the default value if you do not specify an access modifier.
private - The type is only available to code within the struct that contains it. You can only use the private access modifier with nested structs.

###Using a Struct
* Instantiating a Struct

```c#
Coffee coffee1 = new Coffee();
coffee1.Strength = 3;
coffee1.Bean = "Arabica";
coffee1.CountryOfOrigin = "Kenya";
```

###Adding a Constructor
```c#
public struct Coffee
{
   // This is the custom constructor.
   public Coffee(int strength, string bean, string countryOfOrigin)
   {
      this.Strength = strength;
      this.Bean = bean;
      this.CountryOfOrigin = countryOfOrigin;
   }
  // These statements declare the struct fields and set the default values.
   public int Strength;
   public string Bean;
   public string CountryOfOrigin; 
   // Other methods, fields, properties, and events.
}

```
###Calling a Constructor
```c#
// Call the custom constructor by providing arguments for the three required parameters.
Coffee coffee1 = new Coffee(4, "Arabica", "Colombia");
```
###Creating Properties
```c#
//Implementing a Property 
public struct Coffee 
{ 
    private int strength; 
    public int Strength 
    { 
        get { return strength; } 
        set { strength = value; } 
    } 
}
```
The following example shows how to use a property:
```c#
//Using a Property 
Coffee coffee1 = new Coffee(); 
// The following code invokes the set accessor. coffee1.Strength = 3; 
// The following code invokes the get accessor. int coffeeStrength = coffee1.Strength;
```

```c#
// This is a read-only property. 
public int Strength 
{ 
    get { return strength; } 
} 
// This is a write-only property. 
public string Bean 
{ 
    set { bean = value; } 
} 
```
You can change the implementation of properties without affecting client code. For example, you can add validation logic, or call a method instead of reading a field value.
```c#
public int Strength 
{ 
    get { return strength; } 
    set 
    { 
        if(value < 1) 
        { strength = 1; } 
        else if(value > 5) 
        { strength = 5; } 
        else { strength = value; } 
      } 
}
```
* Properties are required for data binding in WPF. For example, you can bind controls to property values, but you cannot bind controls to field values.

When you want to create a property that simply gets and sets the value of a private field without performing any additional logic, you can use an abbreviated syntax. 
```c#
public int Strength { get; set; }
public int Strength { get; } //To create a property that reads from a private field
public int Strength { set; } //To create a property that writes to a private field
```
In each case, the compiler will implicitly create a private field and map it to your property. These are known as auto-implemented properties. You can change the implementation of your property at any time.

###Creating Indexers
The following example shows a struct that includes an array:
```c#
//Creating a Struct that Includes an Array 
public struct Menu 
{ 
    public string[] beverages; 
    public Menu(string bev1, string bev2) 
    { 
        beverages = new string[] { "Americano", "Café au Lait", "Café Macchiato", "Cappuccino", "Espresso" }; 
    }
}
```
When you expose the array as a public field, you would use the following syntax to retrieve beverages from the list:
```c#
//Accessing Array Items Directly 
Menu myMenu = new Menu(); 
string firstDrink = myMenu.beverages[0];
```
A more intuitive approach would be if you could access the first item from the menu by using the syntax myMenu[0]. You can do this by creating an indexer. An indexer is similar to a property, in that it uses get and set accessors to control access to a field. More importantly, an indexer enables you to access collection members directly from the name of the containing struct or class by providing an integer index value. To declare an indexer, you use the this keyword, which indicates that the property will be accessed by using the name of the struct instance.

The following example shows how to define an indexer for a struct:

```c#
//Creating an Indexer 
public struct Menu 
{ 
    private string[] beverages; 
    // This is the indexer. 
    public string this[int index] 
    { 
        get { return this.beverages[index]; } 
        set { this.beverages[index] = value; } 
    } 
    // Enable client code to determine the size of the collection. 
    public int Length 
    { 
        get { return beverages.Length; } 
    } 
}
```
When you use an indexer to expose the array, you use the following syntax to retrieve the beverages from the list:
```c#
//Accessing Array Items by Using an Indexer 
Menu myMenu = new Menu(); 
string firstDrink = myMenu[0]; 
int numberOfChoices = myMenu.Length;
```
Just like a property, you can customize the get and set accessors in an indexer without affecting client code. You can create a read-only indexer by including only a get accessor, and you can create a write-only indexer by including only a set accessor.
