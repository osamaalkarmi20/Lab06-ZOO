using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals.mammals
{
    public class Lion : Mammals
    {// concret class derived from Mammals
        // override for virtual properties from Mammals
        public override bool Fur { get; set; }
        public override bool BrestFeed { get; set; }
        public Lion(string name, string speacies, bool Fur, bool brestfeed) : base(name, speacies, Fur, brestfeed)
        {


        }


        // override for the virtual methods in Mammals
        public override void WarmBlood()
        {
            Console.WriteLine("lion is warm blooded");
        }
        public override void Birth()
        {
            Console.WriteLine("lion gives birth");
        }
    }
}
