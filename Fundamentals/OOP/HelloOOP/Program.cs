// Object Construction http://learn.codingdojo.com/m/25/5699/37841

// using System;

// namespace HelloOOP {
//     public class Vehicle {
//         public int NumPassengers;
//         public Vehicle (int val) {
//             NumPassengers = val;
//         }
//     }
//     class Program {
//         public static void Main (string[] args) {
//             // Notice the type for the new object reference
//             // is the same as the class name
//             Vehicle myVehicle = new Vehicle (99);
//             Console.WriteLine ($"My vehicle is holding {myVehicle.NumPassengers} people");
//         }
//     }
// }

// Class Members  http://learn.codingdojo.com/m/25/5699/39186

using System;

namespace HelloOOP {
    class Vehicle {
        public int MaxNumPassengers;
        public string Color;
        public double MaxSpeed;
        void MakeNoise (string noise) {
            Console.WriteLine (noise);
        }
        void MakeNoise () {
            Console.WriteLine ("BEEP!");
        }

        //someVehicle.ColorProp => Color
        //someVehicle.ColorProp => "Some Color"
        string ColorProp {
            get {
                if (Color == "Green")
                    return $"This sweet thing is {Color}";
                return $"This thing is {Color}";
            }
            set {
                if (value != "Green")
                    Color = value;
            }
        }
        string Name { get; set; }
    }
    class Program {
        public static void Main (string[] args) {
            Console.WriteLine ();
        }
    }

}