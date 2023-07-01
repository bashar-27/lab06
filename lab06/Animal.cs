using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab06
{
    public abstract class Animal
    {

        public abstract string Name { get; set; }
        public abstract int HasLegs { get; set; }
        public Animal(string name , int leg)
        {
            Name = name;
            HasLegs = leg ;
           
        }

        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Sound();
             
      
       
    }
}