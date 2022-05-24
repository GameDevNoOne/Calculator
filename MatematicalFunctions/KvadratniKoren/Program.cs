using System;

namespace KvadratniKorenjenec
{
	public static class Program
	{
		public static long Main()
		{
			Console.WriteLine("Type the square root you are trying to get");
			long korenjenec = Int64.Parse(Console.ReadLine());
			long? korenjenoStevilo = SquareRoot.KvadratniKoren.Koren(korenjenec);
			if (korenjenoStevilo == null)
			{
				Console.WriteLine("Korenjenec {0} nima celega korena", korenjenec);
			}
			return korenjenoStevilo.Value;
			
			
		}
	}
}

