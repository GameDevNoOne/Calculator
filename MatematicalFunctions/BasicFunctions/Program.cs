using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicalFunctions.BasicFunctions
{
    public static class Program
    {
        public static double Plus()
        {
            Console.WriteLine("Napiši prvo število");
            double prvo = float.Parse(Console.ReadLine());
            // Določi drugo število
            Console.WriteLine("Napiši drugo število");
            double drugo = float.Parse(Console.ReadLine());

            double sestevek = BasicFunction.Plus(prvo, drugo);
            return sestevek;
        }

        public static double Minus() 
        {
            Console.WriteLine("Napiši prvo število");
            double prvo = float.Parse(Console.ReadLine());

            Console.WriteLine("Napiši drugo število");
            double drugo = float.Parse(Console.ReadLine());

            double razlika = BasicFunction.Minus(prvo, drugo);
            return razlika;
        }

        public static double Krat()
        {
            Console.WriteLine("Napiši prvo število");
            double prvo = float.Parse(Console.ReadLine());

            Console.WriteLine("Napiši drugo število");
            double drugo = float.Parse(Console.ReadLine());

            double zmnozek = BasicFunction.Krat(prvo, drugo);
            return zmnozek;
        }

        public static double Deljenje()
        {
            Console.WriteLine("Napiši prvo število");
            double prvo = float.Parse(Console.ReadLine());

            Console.WriteLine("Napiši drugo število");
            double drugo = float.Parse(Console.ReadLine());

            double kolicnik = BasicFunction.Division(prvo, drugo);
            return kolicnik;
        }
    }
}
