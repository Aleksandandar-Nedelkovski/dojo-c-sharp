using System;
using System.Collections.Generic;

namespace WizardNinja {
    class Human {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;

        public int Health {
            get { return health; }
            set { }
        }

        public Human (string name) {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human (string name, int str, int intel, int dex, int hp) {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        // Build Attack method
        public virtual int Attack (Human target) {
            if (target == this) {
                Console.WriteLine ("Oh nooo!");
            }
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public int Attack (Human target, int dmg) {
            target.health -= dmg;
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public int BeHealed (Human target, int amt) {
            target.health += amt;
            Console.WriteLine ($"{target.Name} was healed by {amt} points!");
            return target.health;
        }
    }
    class Ninja : Human {
        // Ninja should have a default dexterity of 175
        public Ninja (string name) : base (name) {
            Dexterity = 175;
        }
        // Provide an override Attack method to Ninja, which reduces the target by 5 * Dexerity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack (Human target) {
            int dmg = Dexterity * 5;
            Random rand = new Random ();
            int chance = rand.Next (0, 5);
            if (chance == 0) {
                dmg += 10;
            }
            base.Attack (target, dmg);
            return target.Health;
        }
        // Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
        public int Steal (Human target) {
            base.Attack (target, 5);
            health += 5;
            return target.Health;
        }
    }
    class Wizard : Human {
        // Wizard should have a default health of 50 and Intelligence of 25
        public Wizard (string name) : base (name) {
            health = 50;
            Intelligence = 25;
        }
        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damgage dealt
        public override int Attack (Human target) {
            int dmg = Intelligence * 5;
            base.Attack (target, dmg);
            health += dmg;
            Console.WriteLine ($"{this.Name} healed by {dmg} points");
            return target.Health;
        }
        // Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal (Human target) {
            int amt = Intelligence * 10;
            base.BeHealed (target, amt);
            return target.Health;
        }
        // public virtual int Heal (Human target, int amt) {
        //     health += amt;
        //     Console.WriteLine ($"{Name} was healed  {amt}");
        //     return target.Health;
        // }

    }

    class Samurai : Human {
        private int baseHealth = 200;
        // Samurai should have a default health of 200
        public Samurai (string name) : base (name) {
            health = baseHealth;
        }
        // Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.
        // Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
        public int Meditate () {
            health = baseHealth;
            return health;
        }
    }
    class Program {
        static void Main (string[] args) {
            Human alex = new Human ("Alex");
            Human jon = new Human ("Jon");
            Wizard merlin = new Wizard ("Merlin");
            Samurai jack = new Samurai ("Jack");
            Console.WriteLine (alex.Health);
            // Ninja bella = new Ninja ("Bella");
            // bella.Steal (alex);
            // Console.WriteLine ("Bella after the steal: " + bella.Health);
            // Console.WriteLine ($"Health: {merlin.Health}, Intelligence: {merlin.Intelligence}");
            // merlin.Attack (alex);
            // Console.WriteLine ("After the attack: " + alex.Health);
            // alex.Attack (jon);
            // merlin.Attack (alex);
            // alex.Attack (merlin);
            // alex.Attack (alex);
            merlin.Attack (jack);
            merlin.Attack (jack);
            merlin.Attack (jack);
            merlin.Attack (jack);
            merlin.Attack (jack);
            Console.WriteLine (jack.Health);
            jack.Meditate ();
            Console.WriteLine (jack.Health);
        }
    }
}