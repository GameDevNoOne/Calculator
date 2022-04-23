using Matematika;
namespace Main
{
    public static class Uporaba
{
    public static void Main()
    {
        Console.WriteLine("Napiši številko:");
        string? s = Console.ReadLine();

        if(s == null)
        {
            Console.WriteLine("Niste napisali številke");
            return;
        }

        bool result = double.TryParse(s, out double x);

        if(result)
        {
            Console.WriteLine("Absolutna vrednost je {0}", Funkcije.Abs(x));
            return;
        }
        Console.WriteLine("Ni uspelo prebrati številke");
    }
}
}
