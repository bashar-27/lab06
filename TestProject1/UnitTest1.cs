using lab06;
using System.Xml.Linq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void butterfly()
        {
            Butterfly butter = new Butterfly("Monarch", 6, false, " ");
            string res = butter.Name;
            Assert.Equal(res, "Monarch");
        }

        [Fact]
        public void dolphin()
        {
            Dolphin dolphin = new Dolphin("lopaka", 0, true, false);
            string res = dolphin.Name;
            Assert.Equal(res, "lopaka");
        }

        [Fact]
        public void spider()
        {
            Spider spider = new Spider("Black Widow", 8, true, "");
            string res = spider.Name;
            Assert.Equal(res, "Black Widow");
        }

        [Fact]
        public void birds()
        {
            Bird birds = new Bird("Eagle", 2, true, true, true);
            string res = birds.Name;
            Assert.Equal(res, "Eagle");
        }

        [Fact]
        public void tur()
        {
            Turtles turtles = new Turtles("Mbappy", 4, true, true);

            string res = turtles.Name;
            Assert.Equal(res, "Mbappy");
        }
        [Fact]
        public void TurtlesAttck()
        {
            Turtles turtles = new Turtles("Mbappy", 4, true, true);

            string res = turtles.IAttack();
            Assert.Equal(res, "Turtles are non-attacker");
        }
        [Fact]
        public void TurtlesScalble()
        {
            Turtles turtles = new Turtles("Mbappy", 4, true, true);

            bool res = turtles.IsThereScale();
            Assert.NotEqual(res, false);
        }

        [Fact]
        public void birdsEdible()
        {
            Bird birds = new Bird("Eagle", 2, true, true, true);
            string res = birds.IsEdible();
            Assert.NotEqual(res, "Most of the birds are not edible");
        }
        [Fact]
        public void spiderAttack()
        {
            Spider spider = new Spider("Black Widow", 8, true, "");
            string res = spider.IAttack();
            Assert.Equal(res, $"{spider.Name}: Depends on my type but I could kill you");
        }
        [Fact]
        public void spiderScales()
        {
            Spider spider = new Spider("Black Widow", 8, true, "");
            bool res = spider.IsThereScale();
            Assert.NotEqual(res, true);
        }
        [Fact]
        public void dolphinEdible()
        {
            Dolphin dolphin = new Dolphin("lopaka", 0, true, false);
            string res = dolphin.IsEdible();
            Assert.Equal(res, "There are many of mammals for good, edible but dolphins are not among them");
        }
        [Fact]
        public void butterflyöAttack()
        {
            Butterfly butter = new Butterfly("Monarch", 6, false, " ");
            string res = butter.IAttack();
            Assert.NotEqual(res, "Butterflies can attack, they are cute creatures ");
        }


    }
}