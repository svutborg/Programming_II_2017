using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace PrimeNumbers
{
    class Program
    {
        public delegate void PrimeNumberDelegate(object a);
        static int numberOfThreads = 1;
        static void Main(string[] args)
        {
            PrimeNumberDelegate PD = new PrimeNumberDelegate(FindPrimes);
            ParameterizedThreadStart TS = new ParameterizedThreadStart(PD);

            Random R = new Random();
            Stopwatch sw = new Stopwatch();
            List<Thread> threads = new List<Thread>();

            sw.Start();
            for (int i = 2; i < numberOfThreads+2; i++)
            {
                Thread T = new Thread(TS);
                T.Priority = (ThreadPriority)R.Next(0, 4);
                T.Start(i);
                threads.Add(T);
            }

            for (int i = 0; i < numberOfThreads; i++)
            {
                threads[i].Join();
            }
            sw.Stop();

            Console.WriteLine($"Time: {sw.Elapsed}");

            Console.Read();
        }

        static void FindPrimes(object startNum)
        {
            for (int num = (int)startNum; num < 100000; num += numberOfThreads)
            {
                bool isPrime = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
