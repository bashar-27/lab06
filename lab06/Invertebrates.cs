using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public abstract class Invertebrates : Animal
    {
        public override string Name { get; set; }
        public virtual bool Venomous { get; set;}

        public Invertebrates(string name , int leg ,bool IsVenomous):base(name ,leg) {
            Venomous = IsVenomous;

        }  
    }
}