using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programs
{
    internal class ReverseNumber
    {
          public int Reverse(int number)
          {
            int reverse = 0, lastDigit;
            if (number <= 9)
            {
                Console.WriteLine($" {number} should be greater than 10. ");
                return 0;
            }
            while (number != 0)
            {
                lastDigit = number % 10;
                reverse = (reverse * 10) + lastDigit;
                number /= 10;
            }
            Console.WriteLine(reverse);
            return 0;
          }
    }
}

