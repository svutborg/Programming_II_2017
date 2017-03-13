using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RacingThreads
{
    class Program
    {
        public delegate void ProcessDelegate();
        static bool ready = false;
        static void Main(string[] args)
        {
            ProcessDelegate PD = new ProcessDelegate(ThreadProcess);
            ThreadStart TS = new ThreadStart(PD);

            Random R = new Random();

            for (int i = 0; i < 10; i++)
            {
                Thread T = new Thread(TS);
                T.Name = $"Thread{i}";
                T.Priority = (ThreadPriority)R.Next(0, 4);
                T.Start();
            }
            ready = true;


            Console.Read();
        }

        static void ThreadProcess()
        {
            int i = 0;
            Stopwatch sw = new Stopwatch();
            Console.WriteLine($"{Thread.CurrentThread.Name} with priority {Thread.CurrentThread.Priority} started");
            while (ready == false)
            {
                Thread.Yield();
            }

        
            sw.Start();
            while(i >= 0)
            {
                i++;
            }
            sw.Stop();

            Console.WriteLine($"{Thread.CurrentThread.Name} with priority {Thread.CurrentThread.Priority} started executed in {sw.Elapsed}");
        }
    }
}
