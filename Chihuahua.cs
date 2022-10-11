using System;
using System.Collections.Generic;
using System.Text;

namespace LabbArv
{
    public class Chihuahua : Dog
    {
        //Specific property for chihuahuas
        public string origin;

        //Constructor for new chihuahuas with in arguments
        public Chihuahua(string species, string colour, string sound, int weight, int age, string characteristic, string origin) : base(species, colour, sound, weight, age, characteristic)
        {
            this.origin = origin;
        }

        //Default chihuahua
        public Chihuahua()
        {
            this.species = "Chihuahua";
            this.colour = "Light brown";
            this.weight = 6;
            this.age = 5;
            this.characteristic = "yappy";
            this.origin = "Mexico";

        }

        //Overridden method that prints out costum sound instead of the one in "Dog"-class
        public override void MakeSound()
        {
            Console.WriteLine("Wiff-Wiff");
        }

        //Prints unique method
        public void ChihuahuaFact()
        {
            Console.WriteLine("Chihuahuas can have manes");
        }

    }
}
