#Declaring Methods
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
var upTime = 2000;
var shutdownAutomatically = true;
StartService(upTime, shutdownAutomatically);  
      
// StartService method.
void StartService(int upTime, bool shutdownAutomatically)
{
   // Perform some processing here.
}
--
string serviceName = GetServiceName();
string GetServiceName()
{
   return "FourthCoffee.SalesService";
}

// Using out on the parameters
ReturnMultiOut(out first, out sValue);
Console.WriteLine("{0}, {1}", first.ToString(), sValue);

static void ReturnMultiOut(out int i, out string s)
{
    i = 25;
    s = "using out";
}

// Using ref requires that the variables be initialized first
sValue = "";
ReturnMultiRef(ref first, ref sValue);
Console.WriteLine("{0}, {1}", first.ToString(), sValue);

 static void ReturnMultiRef(ref int i, ref string s)
 {
        i = 50;
        s = "using ref";
 }