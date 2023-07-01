using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public abstract class  Birds : Vertebrates
    {
        public override string Name { get; set; }
        public override int HasLegs { get; set; }
        public override bool IsWarmBlooded { get; set; }
        public override bool LaysEggs { get; set; }
        public virtual bool Swings { get; set; }

        public Birds(string name, int leg, bool WarmBlood, bool Eggs ,bool swings) : base(name, leg,WarmBlood,Eggs) {

            Swings = swings;
        }


    }
}