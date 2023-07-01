using animals.mammals;
using animals.reptile;

namespace animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this are some facts of mammals:");
            Mammals m1 = new Lion("lion", "mammals", true, true);
            Mammals m2 = new Rabbit("rabbit", "mammals", true, true);

            m1.Sleep();
            m1.Birth();
            Console.WriteLine($" {m2.Name} do Brest feed :{m2.BrestFeed}");

            Console.WriteLine(" ");
            Console.WriteLine("this are some facts of birds:");
            Bird b1 = new Parrot("parrot", "birds", true, true);
          

            b1.Sleep();
            b1.Fly();
            Console.WriteLine($" {b1.Name} have feather:{b1.Feather}");
            Console.WriteLine(" ");
            Console.WriteLine("this are some facts of reptiles:");
            Reptile r1 = new Snake("snaks", "reptiles", true, true);
            Reptile r2 = new Crocodile("Crocodile", "reptiles", true, true);

            r1.Sleep();
            r1.Lung();
            Console.WriteLine($" {r2.Name} have Back bone:{r2.Backbone}");

            Console.ReadLine();
        }
    }
}