using animals.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals.reptile
{
    public class Snake:Reptile,Interface1,Interface2
    {// concret class derived from Reptile
     // override for virtual properties from Reptile
        public override bool Backbone { get;set; }
        public override bool Scales { get; set; }
        public Snake(string name, string speacies, bool backbone, bool scales) : base(name, speacies, backbone, scales)
        {
            

        }


        // override virtual methods from Reptiles

        public override void ColdBlood()
        {
            Console.WriteLine("snake are cold blood ");
        }
        public override void Lung()
        {
            Console.WriteLine("snake have lungs");
        }
        public bool ableToSwim()
        {
            bool swim = false;
            return swim;
        }
        public bool meatEater()
        {
            bool meat = true;
            return meat;
        }
    }
}
