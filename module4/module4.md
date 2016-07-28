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