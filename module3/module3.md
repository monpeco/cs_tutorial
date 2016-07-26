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



