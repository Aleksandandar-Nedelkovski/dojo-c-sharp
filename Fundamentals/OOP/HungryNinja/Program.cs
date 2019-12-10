using System;
using System.Collections.Generic;

namespace HungryNinja {
    public class Food {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food (string val, int val2, bool val3, bool val4) {
            Name = val;
            Calories = val2;
            IsSpicy = val3;
            IsSweet = val4;
        }
    }
    public class Buffet {
        public List<Food> Menu;
        //add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually

        public Buffet () {
            Menu = new List<Food> () {
                new Food ("Pizza", 1400, false, false),
                new Food ("Hamburger", 1000, false, false),
                new Food ("Salad", 100, false, false),
                new Food ("Gyro", 800, false, false),
                new Food ("Sandwich", 1100, false, false),
                new Food ("Crepes", 600, false, false),
                new Food ("Polish Sausage", 500, false, false),
            };
        }
        // build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
        Random rand = new Random ();
        public Food Serve () {
            return Menu[rand.Next (Menu.Count)];
        }
    }
    public class Ninja {
        private int calorieIntake;
        public int CalorieAmount {
            get {
                return calorieIntake;
            }
        }
        public List<Food> FoodHistory;
        // add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
        public Ninja () {
            calorieIntake = 0;
            FoodHistory = new List<Food> () { };
        }
        // add a public "getter" property called "IsFull"
        // Add a constructor, IsFull property, and an Eat method to the Ninja class
        public bool IsFull {
            get {
                bool full = false;
                if (calorieIntake > 1200) {
                    full = true;
                }
                return full;
            }
        }
        // build out the Eat method
        public void Eat (Food item) {
            calorieIntake += item.Calories;
            FoodHistory.Add (item);
            Console.WriteLine ($"Food name: {item.Name}, Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
        }
    }

    class Program {
        static void Main (string[] args) {
            // In your Program's Main method, instantiate a Buffet and Ninja object, and have the Ninja eat until they are full!
            Buffet ninjaBuffet = new Buffet ();
            Ninja alex = new Ninja ();
            while (alex.IsFull == false) {
                alex.Eat (ninjaBuffet.Serve ());
            }
            Console.WriteLine ($"Warning: calorie intake is {alex.CalorieAmount}. Ninja is full.");
        }
    }
}