#Inheritance
###Applying Inheritance
The C# programming language does not support multiple inheritance directly. 
To inherit from base class in C#, you append your derived class name with a colon and the name of the base class.
```c#
class Manager : Employee
{
    private char payRateIndicator;
    private Employee[] emps;
}
```

###Abstract Classes
 Abstract classes cannot be instantiated, which means we would not be able to create a new Employee object in code with this statement:
```c#
Employee newEmployee = new Employee();
```
When you create an abstract class you may partially implement some of the behavior in the class, or not implement the behavior at all.  An abstract class requires the subclass to implement some, or all, of the functionality.  If we extend our previous example of the Employee and Manager classes, using abstract classes, we can demonstrate this concept better.  Note that the employee class now includes some methods to implement behaviors.
```c#
abstract class Employee
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        .....

        public virtual void Login()
        {
        }

        public virtual void LogOff()
        {
        }

        public abstract void EatLunch();

    }
```    
Notice that we have now prepended the keyword abstract to our class: abstract class Employee.  Doing so converts our class to an abstract class and sets up some requirements.  Once you create an abstract class, you decide which methods "must" be implemented in the sub classes and which methods "can" be implemented, or overridden, in the sub class.  There is a clear difference.

Any method you declare in the abstract class that will contain some implementation in the abstract class, but can be overridden in the sub class, you decorate with the virtual keyword.  Note in the previous code sample, Login() and LogOff() are both decorated with the virtual keyword.   This means that you can write implementation code in the abstract class and sub classes are free to override the implementation , or accept the implementation that is inherited.

The EatLunch() method is decorated with the abstract keyword, like the class.  There are specific constraints around an abstract method:

* An abstract method cannot exist in non-abstract class
* An abstract method is not permitted to have any implementation, including curly braces
* An abstract method signature must end in a semi-colon
* An abstract method MUST be implemented in any sub class.  Failure to do so will generate a compiler warning in C#.    

###Sealed Classes
What happens if you decide that you don't want your class to be inherited?  How do you prevent that from happening?  Quite simply, you can create a sealed class.  You can use the sealed keyword on your class restrict the inheritance feature of object oriented programming. If a class is derived from a sealed class then the compiler throws an error. 

Although we didn't cover this in the topic on structs, it is important to note that while structs are like classes in some aspects, structs are sealed. Therefore you cannot derive a class from a struct. 

#Introducing Interfaces
An interface is a little bit like a class without an implementation. It specifies a set of characteristics and behaviors by defining signatures for methods, properties, events, and indexers, without specifying how any of these members are implemented. When a class implements an interface, the class provides an implementation for each member of the interface. By implementing the interface, the class is thereby guaranteeing that it will provide the functionality specified by the interface.

Note the important distinction when using an Interface.  A class "implements" and interface as opposed to "inheriting" a base class.

###Creating Interfaces

###Introducing Garbage Collection
The garbage collector is a separate process that runs in its own thread whenever a managed code application is running. The garbage collection process provides the following benefits:

* Enables you to develop your application without having to worry about freeing memory.
* Allocates objects on the managed heap efficiently.
* Reclaims objects that are no longer being used, clears their memory, and keeps the memory available for future allocations. Managed objects automatically get clean content to start with, so their constructors do not have to initialize every data field.
* Provides memory safety by making sure that an object cannot use the content of another object.

###Managed heap
When a .NET application is executed, the garbage collector is initialized by the CLR.  The GC allocates a segment of memory that it will use to store and manage the objects for each .NET application that is running. This memory area is referred to as the managed heap, which differs from a native heap used in the context of the operating system.

To reserve memory, the garbage collector calls the Win32 VirtualAlloc function, and reserves one segment of memory at a time for managed applications. The garbage collector also reserves segments as needed, and releases segments back to the operating system (after clearing them of any objects) by calling the Win32 VirtualFree function.

Note: The size of segments allocated by the garbage collector is implementation-specific and is subject to change at any time, including in periodic updates. When writing your app, you should never make assumptions about, or depend on a particular segment size that will be used by the GC.

Garbage collection occurs when one of the following conditions is true:

* The system is running low on physical memory.
* The memory that is used by currently allocated objects surpasses an acceptable threshold. This threshold will be continuously adjusted as the process is running.
* The GC.Collect method is called. While you can call this method yourself, typically you do not have to call this method, because the garbage collector runs continuously. Even if you do call this method, there is no guarantee that it will run precisely when you call it.

###Implementing the Dispose Pattern

The dispose pattern is a design pattern that frees resources that an object has used. The .NET Framework provides the IDisposable interface in the System namespace to enable you to implement the dispose pattern in your applications.

The IDisposable interface defines a single parameterless method named Dispose. You should use the Dispose method to release all of the unmanaged resources that your object consumed. If the object is part of an inheritance hierarchy, the Dispose method can also release resources that the base types consumed by calling the Dispose method on the parent type.

Invoking the Dispose method does not destroy an object. The object remains in memory until the final reference to the object is removed and the GC reclaims any remaining resources.

Implementing the IDisposable Interface

To implement the IDisposable interface in your application, perform the following steps:

* Ensure that the System namespace is in scope by adding the following using statement to the top of the code file.

```c#
using System;
```
* Implement the IDisposable interface in your class definition.

```c#
...
public class ManagedWord : IDisposable
{
   public void Dispose()
   {
      throw new NotImplementedException();
   }
}
```
* Add a private field to the class, which you can use to track the disposal status of the object, and check whether the Dispose method has already been invoked and the resources released. 

```c#
public class ManagedWord : IDisposable
{
   bool _isDisposed;
   ...
}
```
* Add code to any public methods in your class to check whether the object has already been disposed of. If the object has been disposed of, you should throw an ObjectDisposedException.

```c#
public void OpenWordDocument(string filePath)
{
   if (this._isDisposed)
      throw new ObjectDisposedException("ManagedWord");
       ...
}
```
* Add an overloaded implementation of the Dispose method that accepts a Boolean parameter. The overloaded Dispose method should dispose of both managed and unmanaged resources if it was called directly, in which case you pass a Boolean parameter with the value true. If you pass a Boolean parameter with the value of false, the Dispose method should only attempt to release unmanaged resources. You may want to do this if the object has already been disposed of or is about to be disposed of by the GC. 

```c#
public class ManagedWord : IDisposable
{
   ...
    protected virtual void Dispose(bool isDisposing)
    {
        if (this._isDisposed)
            return;
        if (isDisposing)
        {
           // Release only managed resources.
           ...
        }
        // Always release unmanaged resources.
        ...
        // Indicate that the object has been disposed.
        this._isDisposed = true;
    }
}
```
* Add code to the parameterless Dispose method to invoke the overloaded Dispose method and then call the GC.SuppressFinalize method. The GC.SuppressFinalize method instructs the GC that the resources that the object referenced have already been released and the GC does not need to waste time running the finalization code.

```c#
public void Dispose()
{
   Dispose(true);
   GC.SuppressFinalize(this);
}
```
After you have implemented the IDisposable interface in your class definitions, you can then invoke the Dispose method on your object to release any resources that the object has consumed. You can invoke the Dispose method from a destructor that is defined in the class.

###Implementing a Destructor

You can add a destructor to a class to perform any additional application-specific cleanup that is necessary when your class is garbage collected. To define a destructor, you add a tilde (~) followed by the name of the class. You then enclose the destructor logic in braces.
The following code example shows the syntax for adding a destructor.
```c#
// Defining a Destructor
class ManagedWord
{
    ...
    // Destructor
    ~ManagedWord
    {
        // Destructor logic.
    }
}
```
When you declare a destructor, the compiler automatically converts it to an override of the Finalize method of the object class. However, you cannot explicitly override the Finalize method; you must declare a destructor and let the compiler perform the conversion.
```c#
// Calling the Dispose Method from a Destructor
class ManagedWord
{
    ...
    // Destructor
    ~ManagedWord
    {
        Dispose(false);
    }
}
```
