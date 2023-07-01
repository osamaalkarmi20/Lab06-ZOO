using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals.reptile

{//abstract class  also derived form Animals inherted 
    public class Reptile :Animals   {
        // override abstract propirties from Animals
        public override string Name { get; set; }
        public override string Speacies { get; set; }
        //  virtual propirties 
        public virtual bool Backbone { get; set; }
        public virtual bool Scales { get; set; }
        public Reptile(string name, string speacies ,bool backbone, bool scales) : base(name, speacies )
        {
            Backbone = backbone;
            Scales = scales;
        }
        // override abstract methods from Animals
        public override void Eat()
        {
            Console.WriteLine("The Reptile is eating");
        }

        public override void Sleep()
        {
            Console.WriteLine("The Reptile is sleeping");
        }

        //  virtual methods 




        public virtual void ColdBlood()
        {
            Console.WriteLine("Reptile are cold blood ");
        }
        public virtual void Lung()
        {
            Console.WriteLine("Reptile have lungs");
        }

    }
}
