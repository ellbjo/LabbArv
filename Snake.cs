using System;
using System.Collections.Generic;
using System.Text;

namespace LabbArv
{
    public class Snake : Reptile
    {
        //Implements the property solely for snakes
        public string speed;

        //Creates a snake constructor with in arguments
        public Snake(string species, string colour, string sound, int weight, int age, string speed) : base(species, colour, sound, weight, age)
        {
            this.speed = speed;
        }

        //Constructs the default snake
        public Snake()
        {
            this.species = "Snake";
            this.colour = "Black";
            this.sound = "Hissss";
            this.weight = 3;
            this.age = 5;
            this.speed = "Fast";
        }

        //Unique methods for snakes and classes inheriting from the "Snake" class
        public void Move()
        {
            Console.WriteLine("Slithers away");
        }


        //Overridden method that prints out costum sound
        public override void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }
}
