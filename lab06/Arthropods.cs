using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public abstract class Arthropods : Invertebrates
    {
      
        public virtual string Nostrils { get; set; }
        public Arthropods(string name, int leg, bool IsVenomous, string nostrils) : base(name, leg, IsVenomous)
        {
            Nostrils = nostrils;
        }
        public override void Sleep()
        {
            Console.WriteLine("Arthropods Can Sleep");
        }

    }
}