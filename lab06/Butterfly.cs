using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public class Butterfly : Arthropods,Attack
    {
        public override string Name { get; set; }
        public override int HasLegs { get; set; }
        public override bool Venomous { get; set; }
        public override string Nostrils { get; set; }

        public Butterfly(string name, int leg, bool IsVenomous, string nostrils) : base(name, leg, IsVenomous, nostrils) { }

        public override void Eat()
        {
            Console.WriteLine($"{Name} eates Floral flowers, or the liquids of rotting fruits");
        }

       
        public override void Sound()
        {
            Console.WriteLine("Spiders choir");
        }
        public override void Sleep()
        {
            base.Sleep();
        }
        public void LiveInHome()
        {
            Console.WriteLine($"{Name} can stay in home its a lucky insect");
        }
        public string IAttack()
        {
            return "Butterflies can't attack, they are cute creatures ";
        }

    }
}