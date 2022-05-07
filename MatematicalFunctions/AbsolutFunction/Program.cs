using Matematika;
namespace Main
{
    public static class Uporaba
{
    public static double Main()
    {
        Console.WriteLine("Napiši številko:");
        double s = Int64.Parse(Console.ReadLine());

        double absolut = Matematika.Funkcije.Abs(s);
        return absolut;
    }
}
}
