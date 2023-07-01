using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public abstract class Reptiles : Vertebrates
    {

      public Reptiles(string name, int leg, bool WarmBlood, bool Eggs):base(name ,leg, WarmBlood, Eggs)
        { 
        }

    }
}