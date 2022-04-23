namespace Matematika
{
    /// <summary>Matematične funkcije</summary>
    public static class Funkcije
    {
        public static double Abs(double x)
            {
                if(x > 0)
            {
                return x;
            }
                else
            {
                return x*-1;
            }
        }
        public static int Power(this int osnova, int eksponent)
        {
            int Power = 1;
            while (eksponent > 0)
            {
                Power = Power * osnova;
                eksponent = eksponent - 1;
            }
            return Power;
        }
    }
}
