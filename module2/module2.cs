/*
string response;
switch (response)
{
   case "connection_failed":
      // Block of code executes if the value of response is "connection_failed".
      break;
   case "connection_success":
      // Block of code executes if the value of response is "connection_success".
      break;
   case "connection_error":
      // Block of code executes if the value of response is "connection_error".
      break;
   default:
      // Block executes if none of the above conditions are met.
      break;
}

string response;
switch (response)
{
   case "connection_success":
      // Block of code executes if the value of response is "connection_success".
      break;
   case "connection_failed":
   case "connection_error":
      // Block of code executes if the value of response is "connection_failed"
      // or "connection_error;
      break;
   default:
      // Block executes if none of the above conditions are met.
      break;
}

C# switch statements support the following data types as expressions:

sbyte
byte
short
ushort
int
uint
long
ulong
char
string
enumerations

for ([initializers]; [condition]; [iterator]) 
{
   // code to repeat goes here
}

string[] names = new string[10];
// Process each name in the array.
foreach (string name in names) 
{
    // Code to execute.
}


string response = PromptUser();
while (response != "Quit") 
{
    // Process the data.
    response = PromptUser();
}

do 
{
    // Process the data.
    response = PromptUser();
} while (response != "Quit");

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int row_size = 8;
            int col_size = 8;
            bool is_row_even = true;

            for (int row_index = 0; row_index < row_size; row_index++)
            {
                for (int col_index = 0; col_index < col_size; col_index++)
                {
                    if (((col_index % 2 == 0) && (is_row_even)) || ((col_index % 2 != 0) && (!is_row_even)))
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }

                is_row_even = !is_row_even;
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
