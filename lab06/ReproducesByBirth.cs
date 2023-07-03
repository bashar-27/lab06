using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public abstract class Vertebrates:Animal
    {

        public virtual bool IsWarmBlooded { get; set; }
        public virtual bool LaysEggs { get; set;} 
        public Vertebrates(string name ,int leg ,bool WarmBlood, bool Eggs): base(name , leg)
        {
            IsWarmBlooded = WarmBlood;
            LaysEggs = Eggs;
           
        }

        public abstract bool Fly();

        public virtual string Swim()
        {
            return "Can Swims";
        }
    }
}