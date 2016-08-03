#Declaring Methods
###Declaring Methods
 * Access modifier - this is used to control the accessibility of the method (from where it can be called)
 * private - most restrictive and allows access to the method only from within the containing class or struct
 * public - least restrictive, allowing access from any code in the application
 * protected - allows for access from within the containing class or from within derived classes
 * internal - accessible from files within the same assembly
 * static - indicates the method is a static member of the class rather than a member of an instance of a specific object
 * Return type - used to indicate what type the method will return.  Use void if the method will not return a value or any supported data type
 * Method name - all methods need a name so you know what to call in code.  Identifier rules apply to methods names as well
 * Parameter list - a comma separated list of parameters to accept arguments passed into the method 

```c#
public Boolean StartService(string serviceName)
{
   // code to start the service
}
```

--

###Declaring Methods
```c#
var upTime = 2000;
var shutdownAutomatically = true;
StartService(upTime, shutdownAutomatically);  
      
// StartService method.
void StartService(int upTime, bool shutdownAutomatically)
{
   // Perform some processing here.
}
```

--

###Returning Data
```c#
string serviceName = GetServiceName();
string GetServiceName()
{
   return "FourthCoffee.SalesService";
}
```
The above example shows returning a single value from the method.   There may be times when you would prefer to return multiple values from a method.  There are three approaches that you can take to accomplish this:

* Return an array or collection

* Use the out keyword


```c#
ReturnMultiOut(out first, out sValue);
Console.WriteLine("{0}, {1}", first.ToString(), sValue);

static void ReturnMultiOut(out int i, out string s)
{
    i = 25;
    s = "using out";
}
```

* Use the ref keyword

```c#
// Using ref requires that the variables be initialized first
sValue = "";
ReturnMultiRef(ref first, ref sValue);
Console.WriteLine("{0}, {1}", first.ToString(), sValue);

 static void ReturnMultiRef(ref int i, ref string s)
 {
        i = 50;
        s = "using ref";
 }
```

--

###Overloading Methods
```c#
void StopService()
{
   // This method accepts no arguments
}
void StopService(string serviceName)
{
   // This method overload accepts a single string argument
}
void StopService(int serviceId)
{
   // This method overload accepts a single integer argument
}
```

--

###Optional Parameters
Note that the mechanism used to denote an optional parameter is the inclusion if a default value.


```c#
void StopService(bool forceStop, string serviceName = null, int serviceId =1)
{
   // code here that will stop the service
}
```

###Named Parameters
The following code example shows how to invoke the StopService method by using named arguments to pass the serviceID parameter.
```c#
StopService(true, serviceID: 1);
```
--
###Exceptions
The .NET Framework uses exceptions to help overcome these issues. An exception is an indication of an error or exceptional condition. A method can throw an exception when it detects that something unexpected has happened, for example, the application tries to open a file that does not exist.
--
###Propagation
When a method throws an exception, the calling code must be prepared to detect and handle this exception. If the calling code does not detect the exception, the code is aborted and the exception is automatically propagated to the code that invoked the calling code. This process continues until a section of code takes responsibility for handling the exception
--
###Handling Exceptions
The recommended strategy to follow with catch blocks is to catch more specific exceptions first, and more general exceptions last.
```c#
try
{
    // Try block.
}
catch (FileNotFoundException fnfEx)
{
    // Catch block 1.
}
catch (Exception e)
{
    // Catch block n.
}
```
--
###Using Finally
Some methods may contain critical code that must always be run, even if an unhandled exception occurs. For example, a method may need to ensure that it closes a file that it was writing to or releases some other resources before it terminates. A finally block enables you to handle this situation.

You specify a finally block after any catch handlers in a try/catch block. It specifies code that must be performed when the block finishes, irrespective of whether any exceptions, handled or unhandled, occur.

You can also add a finally block to code that has no catch blocks. In this case, all exceptions are unhandled, but the finally block will always run.
```c#
try
{
}
catch (NullReferenceException ex)
{
    // Catch all NullReferenceException exceptions.
}
catch (Exception ex)
{
    // Catch all other exceptions.
}
finally
{
   // Code that always runs to close files or release resources.
}
```
--
###Throwing Exceptions
The following code example shows how to create an instance of the NullReferenceException class and then throw the ex object.

```c#
var ex = new NullReferenceException("The 'Name' parameter is null.");
throw ex;
```
A common strategy is for a method or block of code to catch any exceptions and attempt to handle them. If the catch block for an exception cannot resolve the error, it can rethrow the exception to propagate it to the caller.

The following code example shows how to rethrow an exception that has been caught in a catch block.
```c#
try
{
}
catch (NullReferenceException ex)
{
    // Catch all NullReferenceException exceptions.
}
catch (Exception ex)
{
    // Attempt to handle the exception
    ...
    // If this catch handler cannot resolve the exception, 
    // throw it to the calling code
    throw;
}
```

###
```c#
```

