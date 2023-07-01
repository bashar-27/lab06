using lab06;

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

    }
}