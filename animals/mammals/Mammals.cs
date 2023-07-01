using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals.mammals
{//abstract class  also derived form Animals inherted 
    public class Mammals : Animals
    { // override abstract propirties from Animals
        public override string Name { get; set; }
        public override string Speacies { get; set; }
        //  virtual propirties 
        public virtual bool Fur { get; set; }
        public virtual bool BrestFeed { get; set; }
        public Mammals(string name, string speacies, bool fur, bool brestfeed) : base(name, speacies)
        {
            Fur = fur;
            BrestFeed = brestfeed;
        }
        // override abstract methods from Animals
        public override void Eat()
        {
            Console.WriteLine("The mammal is eating");
        }

        public override void Sleep()
        {
            Console.WriteLine("The mammals is sleeping");
        }


        //  virtual methods 



        public virtual void WarmBlood()
        {
            Console.WriteLine("mammals are warm blooded");
        }
        public virtual void Birth()
        {
            Console.WriteLine("mammals give birth");
        }

    }
}
