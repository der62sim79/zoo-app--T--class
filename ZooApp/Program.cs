using System;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ape ape = new Ape("Affe", "Chitta");
            Tiger tiger = new Tiger("Tiger", "Two Pack");
            Cage<Ape> cageApe = new Cage<Ape>();
            cageApe.AddAnimal(ape);
            cageApe.RemoveAnimal(ape);
            Cage<Tiger> cageTiger = new Cage<Tiger>();
            cageTiger.AddAnimal(tiger);
            cageTiger.RemoveAnimal(tiger);



        }
    }
}
