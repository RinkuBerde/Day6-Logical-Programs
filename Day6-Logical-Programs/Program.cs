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
            Console.WriteLine("Press 5. to Stimulate Stop watch.");
            //user input
            int selection = Convert.ToInt32(Console.ReadLine());
            //validating input 
            while (selection < 1 || selection > 6)
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
            }
        }
    }
}