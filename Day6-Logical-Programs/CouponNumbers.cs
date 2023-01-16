using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programs
{
    internal class CouponNumbers
    {
        public void Coupon()
        {
            Console.Write("Enter the number of distinct coupons needed : ");
            int number = Convert.ToInt32(Console.ReadLine());
            //Declaring i as an index variable for coupons array
            int i = 0;
            //Declaring array for storing distinct coupon numbers
            int[] coupons = new int[number];
            Random r = new Random();

            //Declaring generated variable for counting total random numbers generated in this process
            int generated = 0;
            while (i < number)
            {
                //Generating a random number (excluding 0 because every element in array is initialized to 0)
                //If we generate 0, then loop will be infinite, because every element at index i will match with 0
                int randomNumber = r.Next(number + 1);
                generated++;
                //If generated random number present in coupon array then it will leave that number(i.e. not distinct)
                if (coupons.Contains(randomNumber))
                {
                    continue;
                }
                //Else the number generated is distinct so add that distinct random generated number to coupons array
                else
                {
                    //Placing the randomly generated number at index i in coupons array
                    coupons[i] = randomNumber;
                }
                i++;
            }
            //Printing each distinct coupon number from array named coupons
            foreach (int coupon in coupons)
            {
                Console.Write(coupon + " ");
            }
            //Printing total random numbers generated in this process
            Console.WriteLine("\nRandom numbers needed to genearate " + number + " number of coupons are : " + generated);
        }
    }
}

    
