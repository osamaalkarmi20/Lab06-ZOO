using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals
{
    public class Parrot : Bird
    { // concret class derived from   Birds
      // override for virtual properties from Birds
        public override bool Feather { get; set; }
        public override bool Peacks { get; set; }
        public Parrot(string name, string speacies, bool feather, bool peacks) : base(name, speacies, feather, peacks)
        {
            

        }


        // override for the virtual methods in Birds

        public override void Fly()
        {
            Console.WriteLine("Parrot can fly ");
        }
        public override void Lay()
        {
            Console.WriteLine("Parrot lay eggs");
        }
    }
}
