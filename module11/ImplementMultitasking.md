#MultiTasking

A typical graphical application consists of blocks of code that run when an event occurs; these events fire in response to actions such as the user clicking a button, moving the mouse, or opening a window. By default, this code runs by using the UI thread. However, you should avoid executing long-running operations on this thread because they can cause the UI to become unresponsive. Also, running all of your code on a single thread does not make good use of available processing power in the computer; most modern machines contain multiple processor cores, and running all operations on a single thread will only use a single processor core.

The Microsoft® .NET Framework now includes the Task Parallel Library. This is a set of classes that makes it easy to distribute your code execution across multiple threads. You can run these threads on different processor cores and take advantage of the parallelism that this model provides. You can assign long-running tasks to a separate thread, leaving the UI thread free to respond to user actions.

Prior to Windows Store applications, .NET developers made use of the System.Threading namespace and Thread class to execute multiple threads within an application.  The Thread class is not available in Windows Store apps so you make use of the Task class instead.  Creating a task in a Windows Store application will result in a thread being created for that task.

When you use tasks rather than threads, the CLR can optimize the number of threads required for concurrent tasks and this helps your applications scale better than dealing with threads directly.

For more information , you can see: 
Microsoft .NET Framework 4.5: https://aka.ms/edx-dev204x-net01

#Creating Tasks

###Creating Tasks

The Task class lies at the heart of the _Task Parallel Library_ in the .NET Framework. As the name 
suggests, you use the Task class to represent a task, or in other words, a unit of work. The Task 
class enables you to perform multiple tasks concurrently, each on a different thread. Behind the 
scenes, the Task Parallel Library manages the thread pool and assigns tasks to threads. You can 
implement sophisticated multitasking functionality by using the Task Parallel Library to chain 
tasks, pause tasks, wait for tasks to complete before continuing, and perform many other operations.


You create a new Task object by using the Task class. A Task object runs a block of code, and you 
specify this code as a parameter to the constructor. *You can provide this code in a method and 
create an Action delegate that wraps this method*.

Note: A delegate provides a mechanism for referencing a block of code or a method. The Action class 
is a type in the .NET Framework Class Library that enables you to convert a method into a delegate. 
The method cannot return a value, but it can take parameters. The .NET Framework Class Library also 
provides the Func class, which enables you to define a delegate that can return a result.

The following code example shows how to create a task by using an Action delegate:

```c#
// Creating a Task by Using an Action Delegate
Task task1 = new Task(new Action(GetTheTime));
private static void GetTheTime()
{
   Console.WriteLine("The time now is {0}", DateTime.Now);
}
```

Using an Action delegate requires that you have defined a method that contains the code that 
you want to run in a task. However, if the sole purpose of this method is to provide the logic 
for a task and it is not reused anywhere else, you can find yourself creating (and having to 
remember the names of) a substantial number of methods. This makes maintenance more difficult. 
A more common approach is to use *an anonymous method*. An anonymous method is a method without 
a name, and you provide the code for an anonymous method inline, at the point you need to use it. 
You can use the delegate keyword to convert an anonymous method into a delegate.

The following code example shows how to create a task by using an anonymous delegate.

```c#
// Creating a Task by Using an Anonymous Delegate
Task task2 = new Task( delegate { Console.WriteLine("The time now is {0}", DateTime.Now); });
```

###Using Lambda Expressions to Create Tasks

A *lambda expression* is a shorthand syntax that provides a simple and concise way to define 
anonymous delegates. When you create a Task instance, you can use a lambda expression to define 
the delegate that you want to associate with your task.

If you want your delegate to invoke a named method or a single line of code, you use can use 
a lambda expression. A lambda expression provides a shorthand notation for defining a delegate 
that can take parameters and return a result. It has the following form:

```c#
(input parameters) => expression
```

In this case: 

* The lambda operator, =>, is read as “goes to.”
* The left side of the lambda operator includes any variables that you want to pass to the expression. If you do not require any inputs—for example, if you are invoking a method that takes no parameters—you include empty parentheses () on the left side of the lambda operator.

The right side of the lambda operator includes the expression you want to evaluate. This could be 
a comparison of the input parameters—for example, the expression `(x, y) => x == y` will 
return true if x is equal to y; otherwise, it will return false. Alternatively, you can call a 
method on the right side of the lambda operator.

The following code example shows how to use lambda expressions to represent a delegate that 
invokes a named method.

```c#
// Using a Lambda Expression to Invoke a Named Method
Task task1 = new Task ( () => MyMethod() );
// This is equivalent to: Task task1 = new Task( delegate(MyMethod) );
```

A lambda expression can be a simple expression or function call, as the previous example shows, 
or it can reference a more substantial block of code. To do this, specify the code in curly 
braces (like the body of a method) on the right side of the lambda operator:

```c#
(input parameters) => { Visual C# statements; }
```

The following code example shows how to use lambda expressions to represent a delegate 
that invokes an anonymous method.

```c#
// Using a Lambda Expression to Invoke an Anonymous Method
Task task2 = new Task( () => { Console.WriteLine("Test") } );
// This is equivalent to: Task task2 = new Task( delegate { Console.WriteLine("Test") } );
```

As your delegates become more complex, lambda expressions offer a far more concise and 
easily understood way to express anonymous delegates and anonymous methods. As such, lambda 
expressions are the recommended approach when you work with tasks.

#Controlling Task Execution

###Controlling Task Execution

The Task Parallel Library offers several different approaches that you can use to start tasks. 
There are also various different ways in which you can pause the execution of your code until 
one or more tasks have completed.

###Starting Tasks

When your code starts a task, the Task Parallel Library assigns a thread to your task and 
starts running that task. The task runs on a separate thread, so your code does not need to 
wait for the task to complete. Instead, the task and the code that invoked the task continue 
to run in parallel.

If you want to queue the task immediately, you use the Start method.

```c#
// Using the Task.Start Method to Queue a Task
var task1 = new Task( () => Console.WriteLine("Task 1 has completed.") );
task1.Start();
```

Alternatively, you can use the static TaskFactory class to create and queue a task with a 
single line of code. The TaskFactory class is exposed through the static Factory property
of the Task class.

```c#
// Using the TaskFactory.StartNew Method to Queue a Task
var task3 = Task.Factory.StartNew( () => Console.WriteLine("Task 3 has completed.") );
```

The Task.Factory.StartNew method is highly configurable and accepts a wide range of parameters. If you simply want to queue some code with the default scheduling options, you can use the static Task.Run method as a shortcut for the Task.Factory.StartNew method.

```c#
// Using the Task.Run Method to Queue a Task
var task4 = Task.Run( () => Console.WriteLine("Task 4 has completed. ") );
```

###Waiting for Tasks

In some cases, you may need to pause the execution of your code until a particular task has completed. Typically you do this if your code depends on the result from one or more tasks, or if you need to handle exceptions that a task may throw. The Task class offers various mechanisms to do this:

* If you want to wait for a single task to finish executing, use the Task.Wait method.
* If you want to wait for multiple tasks to finish executing, use the static Task.WaitAll method.
* If you want to wait for any one of a collection of tasks to finish executing, use the static Task.WaitAny method.

The following code example shows how to wait for a single task to complete.

```c#
// Waiting for a Single Task to Complete
var task1 = Task.Run( () => LongRunningMethod() );
// Do some other work.
// Wait for task 1 to complete.
task1.Wait();
// Continue with execution.
```

If you want to wait for multiple tasks to finish executing, or for one of a collection of tasks to finish executing, you must add your tasks to an array. You can then pass the array of tasks to the static Task.WaitAll or Task.WaitAny methods.

The following code example shows how to wait for multiple tasks to complete.

```c#
// Waiting for Multiple Tasks to Complete
Task[] tasks = new Task[3]
{
   Task.Run( () => LongRunningMethodA()),
   Task.Run( () => LongRunningMethodB()),
   Task.Run( () => LongRunningMethodC())
};
// Wait for any of the tasks to complete.
Task.WaitAny(tasks);
// Alternatively, wait for all of the tasks to complete.
Task.WaitAll(tasks);
// Continue with execution.
```

