using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp
{
    class Ape
    {
        public string Animal { get; set; }
        public string Name { get; set; }

       public Ape (string animal, string name)
        {
            Animal = animal;
            Name = name;
        }
    }
}
