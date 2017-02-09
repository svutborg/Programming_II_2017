using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        enum Seasons { Spring = 1, Summer, Autumn, Winter };
        static void Main(string[] args)
        {
            Console.WriteLine("What season is it?");
            foreach (Seasons s in Enum.GetValues(typeof(Seasons)))
            {
                Console.Write($"{(int)s}: ");
                Console.WriteLine($"{s}");
            }
            int ans;
            Int32.TryParse(Console.ReadLine(), out ans);
            if (ans == (int)Seasons.Winter)
            {
                Console.WriteLine("This the season to be jolly!");
            }
            else
            {
                Console.WriteLine($"You selected: {(Seasons)ans}");
            }
            Console.Read();
        }
    }
}
