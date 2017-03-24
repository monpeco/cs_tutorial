/*
 * Created by SharpDevelop.
 * User: Monpeco
 * Date: 23-03-2017
 * Time: 10:29 PM
 * 
 * 
 */
using System;
using System.Threading.Tasks;

namespace Module12Practice
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			TaskScheduler.UnobservedTaskException += (object sender, UnobservedTaskExceptionEventArgs e) =>
			{
			         foreach (Exception ex in ((AggregateException)e.Exception).InnerExceptions)
			         {
			            Console.WriteLine(String.Format("An exception occurred: {0}", ex.Message));
			         }
			         // Set the exception status to Observed.
			         e.SetObserved();
			};
			Task.Run(() =>
			      {
			         using(WebClient client = new WebClient())
			         {
			            client.DownloadStringTaskAsync("http://fourthcoffee/bogus");
			         }
			      });
			   // Give the task time to complete and then trigger garbage collection (for example purposes only).
						
						   
			Thread.Sleep(5000);
			GC.WaitForPendingFinalizers();
			GC.Collect();
			Console.WriteLine("Execution complete.");
			Console.ReadLine();			   
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
