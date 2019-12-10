using System;

namespace Human {
    public class Human {
        public string Name;

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        // Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
        public Human (string val) {
            Name = val;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health {
            get { return health; }
        }

        // Add a constructor to assign custom values to all fields
        // Let 's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human (string val, int val2, int val3, int val4, int val5) {
            Name = val;
            Strength = val2;
            Intelligence = val3;
            Dexterity = val4;
            health = val5;
        }

        // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter.The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker).This method should return the remaining health of the target object.
        public int Attack (Human target) {
            return target.health -= (5 * this.Strength);
            Console.WriteLine (target.health);
        }
        class Program {

            public static void Main (string[] args) {
                Human steve = new Human ("Steve");
                Human alex = new Human ("Alex", 5, 8, 20, 200);
                Human josh = new Human ("Josh", 4, 8, 20, 200);
                alex.Attack (josh);
                Console.WriteLine ($"Name: {steve.Name}, Strength: {steve.Strength}, Intelligence: {steve.Intelligence}, Dexterity: {steve.Dexterity}, Health: {steve.health}");
                Console.WriteLine ($"Name: {alex.Name}, Strength: {alex.Strength}, Intelligence: {alex.Intelligence}, Dexterity: {alex.Dexterity}, Health: {alex.health}");
                Console.WriteLine ($"Name: {josh.Name}, Strength: {josh.Strength}, Intelligence: {josh.Intelligence}, Dexterity: {josh.Dexterity}, Health: {josh.health}");
            }
        }
    }
}