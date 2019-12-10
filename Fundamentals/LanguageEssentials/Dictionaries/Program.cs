using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("Name", "Alex");
            profile.Add("Language", "C#");
            profile.Add("Location", "North Macedonia");
            // Console.WriteLine("Instructor Profile");
            // Console.WriteLine("Name - " + profile["Name"]);
            // Console.WriteLine("From - " + profile["Location"]);
            // Console.WriteLine("Favourite Language - " + profile["Language"]);

            // or

            foreach (KeyValuePair<string, string> entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            Console.WriteLine("=======================================");
            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
