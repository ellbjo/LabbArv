﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LabbArv
{
    public class Animals
    {
        //Decides default properties for animals
        public string species;
        public string colour;
        public string sound;
        public int weight;
        public int age;

        //Creates a constructor with in arguments
        public Animals(string species, string colour, string sound, int weight, int age)
        {
            this.species = species;
            this.colour = colour;
            this.sound = sound;
            this.weight = weight;
            this.age = age;
        }

        //Default constructor
        public Animals()
        {

        }

        //Creates three default methods that can be used later on, virtual since the method will be overridden in other classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Hello I am an animal");
        }

        public void GetWeight()
        {
            Console.WriteLine("This animal weighs " + weight + " kilos");
        }

        public void GetAge()
        {
            Console.WriteLine("This animal is " + age + " years old");
        }


    }
}
