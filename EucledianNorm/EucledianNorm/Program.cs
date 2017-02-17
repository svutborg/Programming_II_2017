using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EucledianNorm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Norm(3, 4, 5, 8, 42, 1000));
            Console.Read();
        }

        static double Norm(params double[] elements)
        {
            double sum = 0;
            foreach(double el in elements)
            {
                sum += Math.Pow(el, 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
