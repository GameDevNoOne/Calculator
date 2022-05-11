using DecimalConverter;
using System;

namespace Main
{
    public static class ConsoleCalc
    {
        public static void Main()
        {
            //Začetni zapis za zaagon in uporabo
            Console.WriteLine("Napiši funkcijo");
            Console.WriteLine("Poleg osnovnih funkcij kot so plus, minus, krat in množenje so tudi:");
            Console.WriteLine("Absolutna funkcija = 5");
            Console.WriteLine("Evklidov Algoritem = 6");
            Console.WriteLine("Koren naravnega števila = 7");

            //Input uporabnik in preverjanje
            string x = Console.ReadLine();

            if (x == "+")
            {
                double sestevek = MatematicalFunctions.BasicFunctions.Program.Plus();
                Console.WriteLine("Sestevek je {0}", sestevek);
            }

            if (x == "-")
            {
                double razlika = MatematicalFunctions.BasicFunctions.Program.Minus();
                Console.WriteLine("Razlika je {0}", razlika);
            }

            if (x == "*")
            {
                double zmnozek = MatematicalFunctions.BasicFunctions.Program.Krat();
                Console.WriteLine("Zmnozek je {0}", zmnozek);
            }

            if (x == "/")
            {
                double kolicnik = MatematicalFunctions.BasicFunctions.Program.Deljenje();
                Console.WriteLine("Kolicnik je {0}", kolicnik);
            }

            if (x == "5")
            {
                double Absolut = MatematicalFunctions.BasicFunctions.Program.AbsolutnaFunkcija();
                Console.WriteLine("Absolutna vrednost te številke je {0}", Absolut);
            }

            if (x == "6")
            {
                int nsd = EvklidovAlgoritem.Program.Main();
                Console.WriteLine("Največji skupni delitelj je {0}", nsd);
            }

            if (x == "7")
            {
                long korenjenoStevilo = KvadratniKorenjenec.Program.Main();
                Console.WriteLine("Korenjenec števila je {0}", korenjenoStevilo);
            }
        }
    }
}
