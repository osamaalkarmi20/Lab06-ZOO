using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{//abstract class  also derived form Animals inherted 
    public abstract class Bird : Animals   {
        // override abstract propirties from Animals
        public override string Name { get; set; }
        public override string Speacies { get; set; }
        //  virtual propirties 
        public virtual bool Feather { get; set; }
        public virtual bool Peacks { get; set; }
        
        public Bird(string name, string speacies ,bool feather, bool peacks) : base(name, speacies )
        {
            Feather = feather;
            Peacks = peacks;
        }
        // override abstract methods from Animals
        public override void Eat()
        {
            Console.WriteLine("The bird is eating");
        }

        public override void Sleep()
        {
            Console.WriteLine("The bird is sleeping");
        }


        //  virtual methods 

        public virtual void Fly()
        {
            Console.WriteLine("birds can fly ");
        }
        public virtual void Lay()
        {
            Console.WriteLine("birds lay eggs");
        }

    }
}
