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
            Console.WriteLine("Is dolphin edible? : "+dolphin.IsEdible());
            Console.WriteLine("\n");
           


            Console.WriteLine("----------Birds----------");
            Bird birds = new Bird("Falcon", 2, true, true, true);
            birds.Eat();
            birds.Sleep();
            birds.Fly();
            Console.WriteLine("Is birds edible? : " + birds.IsEdible());
            Console.WriteLine("Number Of Legs:"+birds.HasLegs);
            Console.WriteLine("\n");


            Console.WriteLine("----------Spiders----------");
            Spider spider = new Spider("Black Widow",8,true,"");
            Console.WriteLine(spider.IAttack());
            spider.Eat();
            Console.WriteLine("Number Of Legs:" + spider.HasLegs);
            Console.WriteLine("\n");


            Console.WriteLine("----------Butterfly----------");
            Butterfly butter = new Butterfly("Monarch", 6, false," ");
            Console.WriteLine(butter.IAttack());
            butter.LiveInHome();
            butter.Eat();
            Console.WriteLine("Number Of Legs:" + butter.HasLegs);
            Console.WriteLine("\n");


            Console.WriteLine("----------Turtles----------");
            Turtles turtles = new Turtles("Mbappy", 4, true, true);
            turtles.Sound();
            turtles.Eat();
            Console.WriteLine(turtles.Swim());
            Console.WriteLine("Do scales cover the body of the turtle? : "+turtles.IsThereScale());
            Console.WriteLine("Number Of Legs:" + turtles.HasLegs);
            


        }
    }
}