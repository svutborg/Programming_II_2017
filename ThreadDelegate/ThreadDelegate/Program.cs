using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread T = new Thread(delegate() { ThreadMethod("Some message", 50000); });
            T.Start();

            Console.Read();

        }

        static int ThreadMethod(string mes, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + ": " + mes);
            }
            return 42;
        }
    }
}
