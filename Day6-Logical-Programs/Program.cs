namespace Day6_Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs!!!");
            Console.WriteLine("Press 1. for Fibonacci Series.");
            Console.WriteLine("Press 2. for Perfect number.");
            Console.WriteLine("Press 3. for Prime number.");
            Console.WriteLine("Press 4. for Reverse number.");
            Console.WriteLine("Press 5. for Coupon Numbers");
            Console.WriteLine("Press 6. to Stimulate Stop watch.");
            //user input
            int selection = Convert.ToInt32(Console.ReadLine());
            //validating input 
            while (selection < 1 || selection > 7)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Enter a proper selection");
                selection = Convert.ToInt32(Console.ReadLine());
            }
            //switch case
            switch (selection)
            {
                case 1:
                    //Fibonacci Series
                    FibonacciSeries.Fibonacci();                   
                    break;
                case 2:
                    //perfect number (6, 28, 496, 8128 )
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.CheckPerfectNumber(28);
                    break;
                case 3:
                    //prime number
                    PrimeNumber obj = new PrimeNumber();
                    obj.CheckPrime(2);
                    break;
                case 4:
                    //Reverse a number
                    ReverseNumber obj1 = new ReverseNumber();
                    obj1.Reverse(123);
                    break;
                case 5:
                    //Coupon Numbers
                    CouponNumbers couponNumbers = new CouponNumbers();
                    couponNumbers.Coupon();
                    break;
                case 6:
                    //
                    StopWatch watch = new StopWatch();
                    watch.StimulateStopWatch();
                    break;
            }
        }
    }
}