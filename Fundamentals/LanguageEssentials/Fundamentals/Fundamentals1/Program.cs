using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255
            // for(int i = 1; i<=255; i++)
            // {
            // Console.WriteLine(i);
            // }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         Console.WriteLine($"Divisible by 3, {i}");
            //     }
            //     else if (i % 5 == 0)
            //     {
            //         Console.WriteLine($"Divisible by 5, {i}");
            //     }
            // }


            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            // string fizz = "Fizz";
            // string buzz = "Buzz";
            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 5 == 0 && i % 3 == 0)
            //     {
            //         Console.WriteLine($"{fizz} {buzz}");
            //     }
            //     else if (i % 3 == 0)
            //     {
            //         Console.WriteLine($"Mult of 3 {fizz}");
            //     }
            //     else if (i % 5 == 0)
            //     {
            //         Console.WriteLine($"Mult of 5 {buzz}");
            //     }
            // }
            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
            int i = 1;
            while (i < 101)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"Three {i}");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"fiveee {i}");
                }
            }
        }
    }
}
