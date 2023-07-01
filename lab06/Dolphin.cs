using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public class Dolphin:Mammals
    {
        public override string Name { get; set;}
        public override int HasLegs { get;set;} = 0;

        public Dolphin(string name, int leg, bool WarmBlood, bool Eggs) : base(name, leg, WarmBlood, Eggs) { }

      

        public override string Swim()
        {
            return "Some turtles can swimming";
        }
        public override bool Fly()
        {
            return false;
        }
        public override void Sound()
        {
            Console.WriteLine("Clicking and whistling sounds.");

        }
        public override void Eat()
        {
            Console.WriteLine("Squid and fish are its main food.\r\n");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} sleep");
        }
    }
}