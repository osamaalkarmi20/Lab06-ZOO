using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace animals
{
    public abstract class Animals
    {
       public  abstract string Name { get; set; }
        public abstract string Speacies { get; set; }
        public Animals(string name, string speacies)
        {
            Name = name ;
            Speacies = speacies ;
        }

         public abstract void Eat();

    public abstract void Sleep();
    }
}
