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
