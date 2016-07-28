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



```c#

```