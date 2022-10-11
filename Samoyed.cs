using System;
using System.Collections.Generic;
using System.Text;

namespace LabbArv
{
    public class Samoyed : Dog
    {
        //Property specific for samoyeds

        public string use;
        public Samoyed()
        {
            this.use = "sledding";
            this.characteristic = "loyal";
        }

        //Creates a constructor with in arguments
        public Samoyed(string species, string colour, string sound, int weight, int age, string characteristic, string use) : base(species, colour, sound, weight, age, characteristic)
        {
            this.use = use;
        }

        //Overridden required method
        public override void MakeSound()
        {
            Console.WriteLine("RUFF-RUFF");
        }

        //Unique method
        public void SamoyedFact()
        {
            Console.WriteLine("Samoyed likes to dig");
        }
    }
}
