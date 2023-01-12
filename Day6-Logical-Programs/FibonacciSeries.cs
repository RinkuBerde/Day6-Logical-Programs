using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programs
{
    internal class FibonacciSeries
    {
        public static void Fibonacci()
        {
            //variables
            int fibonacci, previous_number = 0, current_number = previous_number + 1;
           
            //display initial numbers 1 and 2.
            Console.Write("Fibonacci Series :" + previous_number + " " + current_number);
            for (int i= 1; i <= 6; i++)
            {
                fibonacci = previous_number + current_number;
                previous_number = current_number;
                current_number = fibonacci;
                Console.Write(" " + fibonacci);
            }
     
        }
    }
}

