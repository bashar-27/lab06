using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public abstract class Mammals : Vertebrates
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public override bool LaysEggs { get; set; }=false;
        protected Mammals(string name, int leg, bool WarmBlood, bool Eggs) : base(name, leg, WarmBlood, Eggs)
        {
        }


        public override string Swim()
        {
            return "Some mammals can swim";
        }
      

    }
}