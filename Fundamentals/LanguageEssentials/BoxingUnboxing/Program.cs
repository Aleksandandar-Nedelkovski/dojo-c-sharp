using System;
using System.Collections.Generic;

namespace BoxingUnboxing {
    class Program {
        static void Main (string[] args) {
            // Create an empty List of type object
            List<object> box = new List<object> ();

            // object num = 7;
            // object num2 = 28;
            // object num3 = -1;
            // object booolean = true;
            // object chair = "Chair";

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            // if (num is int && num2 is int && num3 is int) {
            //     Console.WriteLine ($"Integers {num} {num2} {num3}");
            //     // int sum;
            // }
            // if (booolean is bool) {
            //     Console.WriteLine ($"Boolean {booolean}");
            // }
            // if (chair is string) {
            //     Console.WriteLine ($"String {chair}");
            // }

            // Add the following values to the list: 7, 28, -1, true, "chair"
            box.Add (7);
            box.Add (28);
            box.Add (-1);
            box.Add (true);
            box.Add ("Chair");

            // Type Inference
            int sum = 0;
            foreach (var item in box) {
                Console.WriteLine ($"All items: {item}");
                if (item is int) {
                    Console.WriteLine ($" Integers: {item}");
                    sum += (int) (item);
                }
            }
            Console.WriteLine ($"Sum is: {sum}");

            // Add all values that are Int type together and output the sum

        }
    }
}