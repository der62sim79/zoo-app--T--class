using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp
{
    class Cage<T>
    {
        List<T> cageList = new List<T>();


        public void AddAnimal(T animal)
        {
            cageList.Add(animal);
            Console.WriteLine("ist im Käfig");
        }

        public void RemoveAnimal(T anmimal)
        {
            cageList.Remove(anmimal);
            Console.WriteLine("Das Tier muss raus käfig wird umgebaut für ein anderes Tier");
        }
    }
}
