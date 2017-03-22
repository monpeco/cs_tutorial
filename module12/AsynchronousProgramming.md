#What is Asynchronous Programming?

###Asynchronous Programming

An asynchronous operation is an operation that runs on a separate thread; the thread that initiates an asynchronous operation does not need to wait for that operation to complete before it can continue.

Asynchronous operations are closely related to tasks. The .NET Framework 4.5 includes some new features that make it easier to perform asynchronous operations. These operations transparently create new tasks and coordinate their actions, enabling you to concentrate on the business logic of your application. In particular, the async and await keywords enable you to invoke an asynchronous operation and wait for the result within a single method, without blocking the thread.

In this module, you will learn various techniques for invoking and managing asynchronous operations.

For more information , you can see: 
Microsoft .NET Framework 4.5: https://aka.ms/edx-dev204x-net01


#Using the Dispatcher

###Using the Dispatcher

In the .NET Framework, each thread is associated with a *Dispatcher object*. The dispatcher is responsible for maintaining a queue of work items for the thread. When you work across multiple threads, for example, by running asynchronous tasks, you can use the Dispatcher object to invoke logic on a specific thread. You typically need to do this when you use asynchronous operations in graphical applications. For example, if a user clicks a button in a Windows® Presentation Foundation (WPF) application, the click event handler runs on the UI thread. If the event handler starts an asynchronous task, that task runs on the background thread. As a result, the task logic no longer has access to controls on the UI, because these are all owned by the UI thread. To update the UI, the task logic must use the Dispatcher.BeginInvoke method to queue the update logic on the UI thread.

Consider a simple WPF application that consists of a button named btnGetTime and a label named lblTime. When the user clicks the button, you use a task to get the current time. In this example, the task simply queries the DateTime.Now property, but in many scenarios, your applications might retrieve data from web services or databases in response to activity on the UI.

The following code example shows how you might attempt to update the UI from your task logic.

```c#
// The Wrong Way to Update a UI Object
public void btnGetTime_Click(object sender, RoutedEventArgs e)
{
   Task.Run(() => 
      {
         string currentTime = DateTime.Now.ToLongTimeString();
         SetTime(currentTime);
      }
}
private void SetTime(string time)
{
   lblTime.Content = time;
}
```

If you were to run the preceding code, you would get an InvalidOperationException exception with the message ”The calling thread cannot access this object because a different thread owns it.” This is because the SetTime method is running on a background thread, but the lblTime label was created by the UI thread. To update the contents of the lblTime label, you must run the SetTime method on the UI thread.

To do this, you can retrieve the Dispatcher object that is associated with the lblTime object and then call the Dispatcher.BeginInvoke method to invoke the SetTime method on the UI thread.

The following code example shows how to use the Dispatcher.BeginInvoke method to update a control on the UI thread.

```c#
// The Correct Way to Update a UI Object
public void buttonGetTime_Click(object sender, RoutedEventArgs e)
{
   Task.Run(() => 
      {
         string currentTime = DateTime.Now.ToLongTimeString();
         lblTime.Dispatcher.BeginInvoke(new Action(() => SetTime(currentTime)));
      }
}
private void SetTime(string time)
{
   lblTime.Content = time;
}
```

Note that the BeginInvoke method will not accept an anonymous delegate. The previous example uses the Action delegate to invoke the SetTime method. However, you can use any delegate that matches the signature of the method you want to call.


#Using async and await

###Using async and await

The async and await keywords were introduced in the .NET Framework 4.5 to make it easier to perform asynchronous operations. You use the async modifier to indicate that a method is asynchronous. Within the async method, you use the await operator to indicate points at which the execution of the method can be suspended while you wait for a long-running operation to return. While the method is suspended at an await point, the thread that invoked the method can do other work.

Unlike other asynchronous programming techniques, the async and await keywords enable you to run logic asynchronously on a single thread. This is particularly useful when you want to run logic on the UI thread, because it enables you to run logic asynchronously on the same thread without blocking the UI.

Consider a simple WPF application that consists of a button named btnLongOperation and a label named lblResult. When the user clicks the button, the event handler invokes a long-running operation. In this example, it simply sleeps for 10 seconds and then returns the result “Operation complete.” In practice, however, you might make a call to a web service or retrieve information from a database. When the task is complete, the event handler updates the lblResult label with the result of the operation.

The following code example shows an application that performs a synchronous long-running operation on the UI thread.

```c#
// Running a Synchronous Operation on the UI Thread
private void btnLongOperation_Click(object sender, RoutedEventArgs e)
{
   lblResult.Content = "Commencing long-running operation…";
   Task<string> task1 = Task.Run<string>(() =>
      {
         // This represents a long-running operation.
         Thread.Sleep(10000);
         return "Operation Complete";
      }
   // This statement blocks the UI thread until the task result is available.
   lblResult.Content = task1.Result;
}
```

In this example, the final statement in the event handler blocks the UI thread until the result of the task is available. This means that the UI will effectively freeze, and the user will be unable to resize the window, minimize the window, and so on. To enable the UI to remain responsive, you can convert the event handler into an asynchronous method.

The following code example shows an application that performs an asynchronous long-running operation on the UI thread.

```c#
// Running an Asynchronous Operation on the UI Thread
private async void btnLongOperation_Click(object sender, RoutedEventArgs e)
{
   lblResult.Content = "Commencing long-running operation…";
   Task<string> task1 = Task.Run<string>(() =>
      {
         // This represents a long-running operation.
         Thread.Sleep(10000);
         return "Operation Complete";
      }
   // This statement is invoked when the result of task1 is available.
   // In the meantime, the method completes and the thread is free to do other work.
   lblResult.Content = await task1;
}
```

This example includes two key changes from the previous example:

The method declaration now includes the async keyword.
The blocking statement has been replaced by an await operator.
Notice that when you use the await operator, you do not await the result of the task—you await the task itself. When the .NET runtime executes an async method, it effectively bypasses the await statement until the result of the task is available. The method returns and the thread is free to do other work. When the result of the task becomes available, the runtime returns to the method and executes the await statement.

For more information , you can see: 
Microsoft .NET Framework 4.5: https://aka.ms/edx-dev204x-net01


