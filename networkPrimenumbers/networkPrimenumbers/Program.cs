using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace networkPrimenumbers
{
    class Program
    {
        static int numberOfThreads = 6;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            List<Thread> threads = new List<Thread>();
            sw.Start();
            for (int i = 0; i < numberOfThreads; i++)
            {
                Thread T = new Thread(FindPrimes);
                threads.Add(T);
                T.Start(i);
            }

            foreach(Thread T in threads)
            {
                T.Join();
            }
            sw.Stop();

            Console.WriteLine($"Time Elapsed: {sw.Elapsed}");
            Console.Read();
        }

        static void FindPrimes(object index)
        {

            for (int i = 2+(int)index; i < 100000; i = i+ numberOfThreads)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
