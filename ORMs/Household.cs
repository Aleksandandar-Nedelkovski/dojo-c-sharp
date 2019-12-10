// We want to design a class hierarchy to represent a household. To start we are limited to dogs, humans, and cats.
// They all make a sound. A human can adopt a dog or a cat. Dogs and cats know who their pet siblings are.
// Dogs can chase cats.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NicksHardestTest.Models {
    public class HouseHold {
        [key]
        public int HouseHoldId;
        public List<Human> Humans { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }
        public string Sound;
    }

    public class Human {
        [key]
        public int HumanId;
        public Cat AdoptCat { get; set; }
        public Dog AdoptDog { get; set; }
    }
    public class Cat {
        [key]
        public int CatId;
        public Dog SiblingDog { get; set; }
    }
    public class Dog {
        [key]
        public int DogId;
        public Cat SiblingCat { get; set; }
    }
}