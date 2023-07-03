using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace lab06
{
    public class Turtles : Reptiles, Scales , Attack
    {
        public override string Name { get; set; }
        public override int HasLegs { get; set; } = 4;

        public Turtles(string name, int leg, bool WarmBlood, bool Eggs) :base(name, leg, WarmBlood, Eggs) { }

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
          Console.WriteLine($"{Name} Sound: Most turtles are silent, but there are giant turtles that growl, roar and growl.");

        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} Vegetables, fruits, cockroaches, and worms\r\n");
        }
        public override void Sleep()
        {
           Console.WriteLine($"{Name} sleep");
        }
        public bool IsThereScale()
        {
            return true;
        }
        public string IAttack()
        {
            return "Turtles are non-attacker";
        }

    }
}