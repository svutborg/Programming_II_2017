using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5, new Point());
            Console.WriteLine(Circle.Counter);
            Circle C2 = new Circle(8, new Point( 8, 5));
            Console.WriteLine(Circle.Counter);

            Console.Read();
        }
    }
}
