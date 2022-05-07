using System;

namespace EvklidovAlgoritem
{
    public static class Program
    {
        public static int Main()
        {
            Console.WriteLine("Type the bigger number first(x)");
            Console.WriteLine("Type the smaller number second(y)");
            //Conversion iz string v int
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            //Kliče funkcijo iz EvklidovAlgoritem.cs
            int nsd = EuclidsAlgorithm.EvklidovAlgoritem.NSDRecursive(x,y);
            return nsd;

        }
    }
}
