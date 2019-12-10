using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] Arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // foreach (int num in Arr)
            // {
            //     Console.WriteLine(num);
            // }
            // Console.WriteLine("=================================");

            // string[] ArrStr = { "Tim", "Martin", "Nikki", "Sara" };
            // foreach (string str in ArrStr)
            // {
            //     Console.WriteLine(str);
            // }
            // Console.WriteLine("=================================");

            // // Boolean[] values = new Boolean[] { true, false,true, false,true, false,true, false,true, false,}; Daemon
            // bool[] trueFalse = { true, false, true, false, true, false, true, false, true, false };
            // foreach (bool y in trueFalse)
            // {
            //     Console.WriteLine(y);
            // }



            // ===== List of Flavors =====
            // Create a list of ice cream flavors that holds at least 5 different flavors(feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Banana");
            flavors.Add("Oreo");
            Console.WriteLine($"The length is {flavors.Count}.");
            Console.WriteLine("=======================================");
            Console.WriteLine($"Third flavor: {flavors[2]}");
            flavors.Remove("Strawberry");
            Console.WriteLine($"Third flavor: {flavors[2]}");
            Console.WriteLine("=======================================");
            Console.WriteLine($"The length now is: {flavors.Count}.");

            Console.WriteLine("========= User Info Dictionary =========");

            // ===== User Info Dictionary =====
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> name = new Dictionary<string, string>();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            name.Add("N", "null");
            name.Add("L", "null");
            name.Add("M ", "null");
            name.Add("K", "null");
            foreach (var entry in name)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            name.Remove("N");
            name.Remove("L");
            name.Remove("K");
            name.Remove("M");
            // For each name key, select a random flavor from the flavor list above and store it as the value
            name.Add("Nick", flavors[2]);
            name.Add("Larry", flavors[0]);
            name.Add("Marina", flavors[3]);
            name.Add("Kirill", flavors[1]);
            Console.WriteLine("=======================================");
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in name)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
