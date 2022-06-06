using System;


namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet1 = new RoseBouquet();
            bouquet1 = new RibbonBouquet(bouquet1); 
            Console.WriteLine("Name: {0}", bouquet1.Name);
            Console.WriteLine("Cost: {0}", bouquet1.GetCost());
 
            Bouquet bouquet2 = new TulipBouquet();
            bouquet2 = new PackageBouquet(bouquet2);
            Console.WriteLine("Name: {0}", bouquet2.Name);
            Console.WriteLine("Cost: {0}", bouquet2.GetCost());
 
            Bouquet bouquet3 = new LilyBouquet();
            bouquet3 = new RibbonBouquet(bouquet3);
            bouquet3 = new PackageBouquet(bouquet3);
            Console.WriteLine("Name: {0}", bouquet3.Name);
            Console.WriteLine("Cost: {0}", bouquet3.GetCost());
        }
    }
}