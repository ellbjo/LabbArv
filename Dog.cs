using System;
using System.Collections.Generic;
using System.Text;

namespace LabbArv
{
    public class Dog : Mammal
    {

        //Unique property for the "Dog" class and the classes that inherites from it
        public string characteristic;

        //Constructor with in arguments
        public Dog(string species, string colour, string sound, int weight, int age, string characteristic) : base(species, colour, sound, weight, age)
        {
            this.characteristic = characteristic;
        }

        //Default dog
        public Dog()
        {
            this.species = "Dog";
            this.colour = "Brown";
            this.sound = "Woff-woff";
            this.weight = 25;
            this.age = 5;
            this.characteristic = "friendly";
        }

        //Unique method, also acceccible for classes inheriting from the "Dog" class
        public virtual void WaggingTail()
        {
            Console.WriteLine("The dog is wagging its tail");
        }


    }
}
