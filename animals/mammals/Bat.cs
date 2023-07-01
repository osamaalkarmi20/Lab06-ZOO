using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals.mammals
{
    public class Bat : Mammals
    {// concret class derived from Mammals
        // override for virtual properties from Mammals
        public override bool Fur { get; set; }
        public override bool BrestFeed { get; set; }
        public Bat(string name, string speacies, bool Fur, bool brestfeed) : base(name, speacies, Fur, brestfeed)
        {


        }

        // override for the virtual methods in Mammals


        public override void WarmBlood()
        {
            Console.WriteLine("bats are warm blooded");
        }
        public override void Birth()
        {
            Console.WriteLine("bats give birth");
        }
    }
}
