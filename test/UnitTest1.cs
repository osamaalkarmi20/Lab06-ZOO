using animals;
using animals.mammals;
using animals.reptile;

namespace test
{
    public class UnitTest1
    {//inhertance tests
        [Fact]
        public void lion()
        {
            Mammals m1 = new Lion("lion", "mammals", true, true);
            string result =m1.Name;
            Assert.Equal(result, "lion");
          
           
        }

        [Fact]
        public void rabbit()
        {
            Mammals m1 = new Rabbit("rabbit", "mammals", true, true);
            string result = m1.Name;
            Assert.Equal(result, "rabbit");


        }
        [Fact]
        public void bat()
        {
            Mammals m1 = new Bat("bat", "mammals", true, true);
            string result = m1.Name;
            Assert.Equal(result, "bat");


        }

        [Fact]
        public void parrot()
        {
            Reptile b1 = new Snake("snake", "birds", true, true);
            string result = b1.Speacies;
            Assert.Equal(result, "birds");


        }
        [Fact]
        public void snakes()
        {
            Reptile r1 = new Snake("snake", "reptiles", true, true);
            string result = r1.Speacies;
            Assert.Equal(result, "reptiles");


        }
        [Fact]
        public void crocodiles()
        {
            Reptile r1 = new Crocodile("Crocodile", "reptiles", true, true);
            string result = r1.Speacies;
            Assert.Equal(result, "reptiles");


        }
        // interfacing tests 

        [Fact]
        public void crocodilesInterface1()
        {
            Crocodile r1 = new Crocodile("Crocodile", "reptiles", true, true);
            bool result = r1.ableToSwim();
            Assert.Equal(result, true);


        }
        [Fact]
        public void snakesInterface1()
        {
            Snake r1 = new Snake("snake", "reptiles", true, true);
            bool result = r1.ableToSwim();
            Assert.Equal(result, false);


        }
        [Fact]
        public void crocodilesInterface2()
        {
            Crocodile r1 = new Crocodile("Crocodile", "reptiles", true, true);
            bool result = r1.meatEater();
            Assert.Equal(result, true);


        }
        [Fact]
        public void snakesInterface2()
        {
            Snake r1 = new Snake("snake", "reptiles", true, true);
            bool result = r1.meatEater();
            Assert.Equal(result, true);


        }
        //is an animal
        [Fact]
        public void snakesIsAnAnimal()
        {
            Animals r1 = new Snake("snake", "reptiles", true, true);
            string result = r1.Name;
            Assert.Equal(result, "snake");


        }
    }
}