using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1 = 0;
            int broj2 = 0;
            Console.WriteLine("Napisi broj: ");
            broj1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napisi jos jedan broj: ");
            broj2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Izaberi jednu od ovih opcija sa liste: ");
            Console.WriteLine("S");
            Console.WriteLine("O");
            Console.WriteLine("M");
            Console.WriteLine("D");
            switch (Console.ReadLine())
            {
                case "S":
                    Console.WriteLine($"Tvoj rezultat je: {broj1} + {broj2}=" + (broj1) + (broj2));
                    break;

                case "O":
                    Console.WriteLine($"Tvoj rezultat je: {broj1} - {broj2} = " + (broj1 - broj2));
                    break;

                case "M":
                    Console.WriteLine($"Tvoj rezultat je: {broj1} * {broj2}=" + (broj1) * (broj2));
                    break;

                case "D":
                    Console.WriteLine($"Tvoj rezultat je: {broj1} / {broj2}=" + (broj1) / (broj2));
                    break;
            }
            Console.WriteLine("Pritisni bilo koje dugme za zatvaranje aplikacije");
            Console.ReadKey();
        }
    }
}
