using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public class Spider : Arthropods,Attack , Scales
    {

     
        public override int HasLegs { get; set; } = 6;
        public override bool Venomous { get; set; } = true;
        public override string Nostrils { get; set; }

      
        public Spider(string name, int leg, bool IsVenomous, string nostrils) : base(name, leg, IsVenomous, nostrils) { }

        public override void Eat()
        {
            Console.WriteLine($"{Name} eats Insects");
        }

        public string IAttack()
        {
            return $"{Name }: Depends on my type but I could kill you";
        }
        public override void Sound()
        {
            Console.WriteLine("Spiders choir");
        }
        public override void Sleep()
        {
            base.Sleep();
        }
     

        public bool IsThereScale()
        {
           return false;
        }
    }
}