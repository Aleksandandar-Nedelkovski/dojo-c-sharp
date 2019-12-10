using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            int[] numArray2 = { 1, 2, 3, 4, 6 };

            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };

            int[] arrayOfInts = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arrayOfInts[0]);
            Console.WriteLine(arrayOfInts[1]);
            Console.WriteLine(arrayOfInts[2]);
            Console.WriteLine(arrayOfInts[3]);
            Console.WriteLine(arrayOfInts[4]);

            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine($"The first number of the arr is {arr[0]}");
            arr[0] = 8;
            Console.WriteLine($"The first number of the arr is now {arr[0]}");

            // string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx" };
            // for (int idx = 0; idx < myCars.Length; idx++)
            // {
            //     Console.WriteLine($"I own a {myCars[idx]}");
            // }

            // or

            string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx" };
            foreach (string car in myCars)
            {
                // We no longer need the index, because variable 'car' already represents each indexed value
                Console.WriteLine($"I own a {car}");
            }

        }
    }
}