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

