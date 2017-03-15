using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace NetworkRacingThreads
{
    class Program
    {
        //delegate void ThreadStartDelegate();
        static void Main(string[] args)
        {
            /*ThreadStart TS = new ThreadStart(new ThreadStartDelegate(ThreadMethod));
            Thread T = new Thread(TS);*/
            Random R = new Random();
            for (int i = 0; i < 10; i++)
            {
                Thread T = new Thread(ThreadMethod);
                T.Name = $"Thread{i}";
                T.Priority = (ThreadPriority)R.Next(0, 4);
                T.Start();
            }
            

            Console.Read();
        }

        static void ThreadMethod()
        {
            Stopwatch sw = new Stopwatch();
            int counter = 0;
            Console.WriteLine($"{Thread.CurrentThread.Name} started!");
            sw.Start();
            while(counter >= 0)
            {
                counter++;
            }
            sw.Stop();
            Console.WriteLine($"{Thread.CurrentThread.Name} with priority {Thread.CurrentThread.Priority} finished in {sw.Elapsed}");
        }
    }
}
