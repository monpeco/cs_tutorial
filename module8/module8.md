#Generics
Generics enable you to create and use strongly typed collections that are type safe, do not require you to cast items, and do not require you to box and unbox value types.
###Creating and Using Generic Classes
Generic classes work by including a type parameter, T, in the class or interface declaration. You do not need to specify the type of T until you instantiate the class. To create a generic class, you need to:

* Add the type parameter T in angle brackets after the class name.
* Use the type parameter T in place of type names in your class members.

The following example shows how to create a generic class:
```c#
// Creating a Generic Class
public class CustomList<T>
{
   public T this[int index] { get; set; }
   public void Add(T item)
   {
      // Method logic goes here.
   }
   public void Remove(T item)
   {
      // Method logic goes here.
   } 
}
```

When you create an instance of your generic class, you specify the type you want to supply as a type parameter. For example, if you want to use your custom list to store objects of type Coffee, you would supply Coffee as the type parameter.

The following example shows how to instantiate a generic class:
```c#
//Instantiating a Generic Class
CustomList<Coffee> clc = new CustomList<Coffee>;
Coffee coffee1 = new Coffee();
Coffee coffee2 = new Coffee();
clc.Add(coffee1);
clc.Add(coffee2);
Coffee firstCoffee = clc[0];
```

###Advantages of Generics
The use of generic classes, particularly for collections, offers three main advantages over non-generic approaches: type safety, no casting, and no boxing and unboxing.

###Type Safety
Consider an example where you use an ArrayList to store a collection of Coffee objects. You can add objects of any type to an ArrayList. Suppose a developer adds an object of type Tea to the collection. The code will build without complaint. However, a runtime exception will occur if the Sort method is called, because the collection is unable to compare objects of different types.

The following example shows the type safety limitations of the ArrayList approach:
```c#
// Type Safety Limitations for Non-Generic Collections
var coffee1 = new Coffee();
var coffee2 = new Coffee();
var tea1 = new Tea();
var arrayList1 = new ArrayList();
arrayList1.Add(coffee1);
arrayList1.Add(coffee2);
arrayList1.Add(tea1);
// The Sort method throws a runtime exception because the collection is not homogenous.
arrayList1.Sort();
// The cast throws a runtime exception because you cannot cast a Tea instance to a Coffee instance.
Coffee coffee3 = (Coffee)arrayList1[2];
```

The following example shows an alternative to the ArrayList approach using the generic List<T> class:
```c#
// Type Safety in Generic Collections
var coffee1 = new Coffee();
var coffee2 = new Coffee();
var tea1 = new Tea();
var genericList1 = new List<Coffee>();
genericList1.Add(coffee1);
genericList1.Add(coffee2);
// This line causes a build error, as the argument is not of type Coffee.
genericList1.Add(tea1);
// The Sort method will work because the collection is guaranteed to be homogenous.
genericList1.Sort();
// The indexer returns objects of type Coffee, so there is no need to cast the return value.
Coffee coffee3 = genericList[1];
```
###No Casting
Casting is a computationally expensive process. When you add items to an ArrayList, your items are implicitly cast to the System.Object type. When you retrieve items from an ArrayList, you must explicitly cast them back to their original type. Using generics to add and retrieve items without casting improves the performance of your application.

###No Boxing and Unboxing

If you want to store value types in an ArrayList, the items must be boxed when they are added to the collection and unboxed when they are retrieved. Boxing and unboxing incurs a large computational cost and can significantly slow your applications, especially when you iterate over large collections. By contrast, you can add value types to generic lists without boxing and unboxing the value.
The following example shows the difference between generic and non-generic collections with regard to boxing and unboxing:

// Boxing and Unboxing: Generic vs. Non-Generic Collections
int number1 = 1;
var arrayList1 = new ArrayList();
// This statement boxes the Int32 value as a System.Object.
arrayList1.Add(number1);
// This statement unboxes the Int32 value.
int number2 = (int)arrayList1[0];
var genericList1 = new List<Int32>();
//This statement adds an Int32 value without boxing.
genericList1.Add(number1);
//This statement retrieves the Int32 value without unboxing.
int number3 = genericList1[0];


###Constraining Generics
In some cases, you may need to restrict the types that developers can supply as arguments when they instantiate your generic class. The nature of these constraints will depend on the logic you implement in your generic class. 

The following example shows how to constrain a type parameter to classes that implement a particular interface:
```c#
// Constraining Type Parameters by Interface
public class CustomList<T> where T : IBeverage
{
}
```

| Constraint | Description |
| --- | --- |
| where T : <name of interface>  | The type argument must be, or implement, the specified interface.  |
|  where T : <name of base class> | The type argument must be, or derive from, the specified class  |
|  where T : U |  The type argument must be, or derive from, the supplied type argument U |
|  where T : new()	 | The type argument must have a public default constructor  |
| where T : struct  | The type argument must be a value type  |
| where T : class  | The type argument must be a reference type  |

	
	
	
	

	
	


