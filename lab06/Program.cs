namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dolphin dolphin = new Dolphin("lopaka",0,true,false);
            dolphin.Eat();
            Console.WriteLine($"{dolphin.Name} Can't Swim "+ dolphin.Fly());

            Bird birds = new Bird("Falcon", 2, true, true, true);

        }
    }
}