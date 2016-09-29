/*
 * Created by SharpDevelop.
 * User: Monpeco
 * Date: 28-09-2016
 * Time: 11:08 PM
 * 
 */
using System;
using System.Linq;

namespace module10_practice
{
	class Program
	{

		public static void Main(string[] args)
		{
			Console.WriteLine("Practing LINQ");
			
			int[] numbers = {5, 4, 0, 1, 7, 9, 8, 6, 3, 2};			

			var lowNums = from num in numbers 
							where num < 5
							select num;
			
			Console.WriteLine("Write num < 5");
			
			foreach(var x in lowNums){
				Console.WriteLine(x);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}