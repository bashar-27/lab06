using System.Xml.Linq;

namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Dolphin----------");
            Dolphin dolphin = new Dolphin("lopaka",0,true,false);
            dolphin.Eat();
            Console.WriteLine($"{dolphin.Name} Can't fly but can swim"+ dolphin.Fly());
            Console.WriteLine("\n");
           


            Console.WriteLine("----------Birds----------");
            Bird birds = new Bird("Falcon", 2, true, true, true);
            birds.Eat();
            birds.Sleep();
            birds.Fly();
            Console.WriteLine("Number Of Legs:"+birds.HasLegs);
            Console.WriteLine("\n");


            Console.WriteLine("----------Spiders----------");
            Spider spider = new Spider("Black Widow",8,true,"");
            Console.WriteLine(spider.MightAttack());
            spider.Eat();
            Console.WriteLine("Number Of Legs:" + spider.HasLegs);
            Console.WriteLine("\n");


            Console.WriteLine("----------Butterfly----------");
            Butterfly butter = new Butterfly("Monarch", 6, false," ");
            butter.LiveInHome();
            butter.Eat();
            Console.WriteLine("Number Of Legs:" + butter.HasLegs);
            Console.WriteLine("\n");


            Console.WriteLine("----------Turtles----------");
            Turtles turtles = new Turtles("Mbappy", 4, true, true);
            turtles.Sound();
            turtles.Swim();
            turtles.Eat();
            Console.WriteLine("Number Of Legs:" + turtles.HasLegs);

            //Console.WriteLine("this are some facts of mammals:");
            //Mammals m1 = new Lion("lion", "mammals", true, true);
            //Mammals m2 = new Rabbit("rabbit", "mammals", true, true);

            //m1.Sleep();
            //m1.Birth();
            //Console.WriteLine($" {m2.Name} do Brest feed :{m2.BrestFeed}");

            //Console.WriteLine(" ");
            //Console.WriteLine("this are some facts of birds:");
            //Bird b1 = new Parrot("parrot", "birds", true, true);


            //b1.Sleep();
            //b1.Fly();
            //Console.WriteLine($" {b1.Name} have feather:{b1.Feather}");
            //Console.WriteLine(" ");
            //Console.WriteLine("this are some facts of reptiles:");
            //Reptile r1 = new Snake("snaks", "reptiles", true, true);
            //Reptile r2 = new Crocodile("Crocodile", "reptiles", true, true);

            //r1.Sleep();
            //r1.Lung();
            //Console.WriteLine($" {r2.Name} have Back bone:{r2.Backbone}");

        }
    }
}