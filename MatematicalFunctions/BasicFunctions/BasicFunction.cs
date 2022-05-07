using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicalFunctions.BasicFunctions
{
    class BasicFunction
    {
        public static double Plus(double prvo, double drugo)
        {
            double sestevek = prvo + drugo;

            return sestevek;
        }

        public static double Minus(double prvo, double drugo)
        {
            double razlika = prvo - drugo;

            return razlika;
        }

        public static double Krat(double prvo, double drugo)
        {
            double zmnozek = prvo * drugo;

            return zmnozek;
        }

        public static double Division(double prvo, double drugo)
        {
            if (drugo <= 0)
            {
                Console.WriteLine("Delitelj je 0, Error 1");
            }

            double kolicnik = prvo / drugo;
            
            return kolicnik;
        }
    }
}
