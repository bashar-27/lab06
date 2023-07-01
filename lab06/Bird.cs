using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public class Bird : Birds
    {
        public Bird(string name, int leg, bool WarmBlood, bool Eggs, bool swings) : base(name, leg, WarmBlood, Eggs, swings)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} eats Rabbits and fish");
        }

        public override bool Fly()
        {
            return true;
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} Can sleep");
        }

        public override void Sound()
        {
            
        }
    }
}