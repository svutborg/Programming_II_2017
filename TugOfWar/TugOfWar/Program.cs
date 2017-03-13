using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TugOfWar
{
    class Program
    {
        static bool victory = false;
        static Int64 rope = 0;
        static Int64 scale = 5000;
        static string Victor;
        static void Main(string[] args)
        {
            Thread T1 = new Thread(Tug1);
            Thread T2 = new Thread(Tug2);
            T1.Name = "Thread 1";
            T2.Name = "Thread 2";
            T1.Priority = ThreadPriority.AboveNormal;
            T2.Priority = ThreadPriority.AboveNormal;
            T1.Start();
            T2.Start();

            while (!victory)
            {
               
                string[] menu = 
                    {
                        "Thread 1:                                                                                   Thread 2:",
                        "+---------------------------------------------------------------------------------------------------+",
                        "|                                                                                                   |",
                        "+---------------------------------------------------------------------------------------------------+"
                    };
                if(rope <= -scale)
                {
                    victory = true;
                    Victor = T1.Name;
                    rope = -scale;
                }
                if(rope >= scale)
                {
                    victory = true;
                    Victor = T2.Name;
                    rope = scale;
                }
                char[] progress = menu[2].ToCharArray();
                progress[50+rope*50/scale] = 'x';

                menu[2] = new string(progress);

                Console.Clear();
                foreach(string s in menu)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine(rope);
                Thread.Sleep(100);
            }
            Console.WriteLine("Victory goes to " + Victor);
            Console.Read();
        }

        static void Tug1()
        {
            while(!victory)
            {
                for (int i = 0; i < 10000; i++)
                {

                }
                rope++;
            }
        }

        static void Tug2()
        {
            while (!victory)
            {
                for (int i = 0; i < 10000; i++)
                {

                }
                rope--;
            }
        }
    }
}
