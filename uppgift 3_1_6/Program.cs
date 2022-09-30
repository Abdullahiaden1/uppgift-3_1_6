using System;
namespace Uppgift_3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Låten du vill spela upp måste vara mellan två minuter och 45 sekunder och maximalt fyra minuter och 20 sekunder");
            int tid = int.Parse(Console.ReadLine());
            if (tid >= 2.45 && tid <= 4.20)
            {
                Console.WriteLine("Din låt skickas nu till p3 Radio");
            }
            else
            {
                Console.WriteLine("Din låt uppphör inte kraven för att spelas upp");
            }
        }
    }
}

