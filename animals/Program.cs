﻿using animals.mammals;
using animals.reptile;

namespace animals
{
    public class Program
    {
        static void Main()
        {//mammals
            Console.WriteLine("this are some facts of mammals:");
            Mammals m1 = new Lion("lion", "mammals", true, true);
            Mammals m2 = new Rabbit("rabbit", "mammals", true, true);
            Console.WriteLine($" {m2.Name}");
           m2.Sleep();
            m2.Birth();
            Console.WriteLine($" {m2.Name} do Brest feed :{m2.BrestFeed}");

            Console.WriteLine(" ");
            Console.WriteLine($" {m1.Name}");
            m1.Sleep();
            m1.Birth();
            Console.WriteLine($" {m1.Name} do Brest feed :{m1.BrestFeed}");

            //birds

            Console.WriteLine(" ");
            Console.WriteLine("this are some facts of birds:");

            Console.WriteLine(" ");
            Bird b1 = new Parrot("parrot", "birds", true, true);
            b1.Sleep();
            b1.Fly();
            Console.WriteLine($" {b1.Name} have feather:{b1.Feather}");

            //reptiles

            Console.WriteLine(" ");
            Console.WriteLine("this are some facts of reptiles:");
            Snake r1 = new Snake("snaks", "reptiles", true, true);
            Crocodile r2 = new Crocodile("Crocodile", "reptiles", true, true);

            Console.WriteLine(" ");
            Console.WriteLine($" {r1.Name}");
            r1.Sleep();
            r1.Lung();
            Console.WriteLine($" {r1.Name} have Back bone:{r1.Backbone}");
            Console.WriteLine($" {r1.Name} have can swim:{r1.ableToSwim()}");
            Console.WriteLine($" {r1.Name} have eats meat:{r1.meatEater()}");

            Console.WriteLine(" ");
            Console.WriteLine($" {r2.Name}");
            r2.Sleep();
            r2.Lung();
            Console.WriteLine($" {r2.Name} have Back bone:{r2.Backbone}");
            Console.WriteLine($" {r2.Name} have can swim:{r2.ableToSwim()}");
            Console.WriteLine($" {r2.Name} have eats meat:{r2.meatEater()}");



            Console.ReadLine();
        }
    }
}