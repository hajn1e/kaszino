using System.ComponentModel;
using System.Runtime.InteropServices;

namespace kaszino
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int penz = 1000;
			int vegosszeg = 0;
			bool fut = true;

			while (fut)
			{
				
                Console.WriteLine("1. Játék");
                Console.WriteLine("2. Kilépés");
                int opcio= Convert.ToInt32(Console.ReadLine());

				switch (opcio)
				{
					case 1:
						vegosszeg = blackJack(ref penz);
						break;
					case 2:
                        Console.WriteLine("Kilépés...");
                        fut = false;
						break;

				}
			}
		}
		
		static int blackJack(ref int penz)
		{
			Console.Clear();
			kasz
			bool jatek = true;
			Console.WriteLine("Add meg a tétedet: ");
			int tet = Convert.ToInt32(Console.ReadLine());
			int pontok = HuzLapot() + HuzLapot();
			Console.WriteLine(pontok);
			while (jatek)
			{
				
                Console.WriteLine("Szeretnél még húzni lapot? (hit/stand)");
				string valasz=Console.ReadLine();

				if (valasz == "hit")
				{
					pontok= pontok + HuzLapot();
                    Console.WriteLine(pontok);

					if (pontok > 21)
					{
                        Console.WriteLine("Vesztettél :(");
						jatek = false;
                    }
					

				}

				else if(valasz == "stand")
				{
					if (pontok<=21)
					{
						int nyeremeny=tet * 2;
                        Console.WriteLine($"Gratulálok! Nyertél {nyeremeny} pontot.");
						jatek= false;

                    }
					else
					{
						Console.WriteLine("Vesztettél :(");
						jatek=false;
					}

				}


            }
			
			return penz;
		}

		static int HuzLapot()
		{	

			Random rnd = new Random();
			int lap = rnd.Next(1, 14);
			if (lap > 10)
			{
				lap = 10;
			}
			
			return lap;

		}

	}
}
