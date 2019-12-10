// using System;
// using System.Collections.Generic;

// namespace Lists
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<string> bikes = new List<string>();
//             bikes.Add("Kawasaki");
//             bikes.Add("Triumph");
//             bikes.Add("BMW");
//             bikes.Insert(2, "Yamaha");
//             bikes.Remove("Yamaha");
//             bikes.Add("Moto Guzzi");
//             bikes.Add("Harley Davidson");
//             bikes.Add("Suzuki");
//             bikes.Remove("Suzuki");
//             Console.WriteLine(bikes[2]);
//             Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

//             for (var idx = 0; idx < bikes.Count; idx++)
//             {
//                 Console.WriteLine("-" + bikes[idx]);
//             }
//             Console.WriteLine("=========================================");
//             Console.WriteLine("The current manufacturers we have seen are:");
//             foreach (string manu in bikes)
//             {
//                 Console.WriteLine("-" + manu);
//             }
//             Console.WriteLine("dsdfsd");
            
//         }
//     }
// }
