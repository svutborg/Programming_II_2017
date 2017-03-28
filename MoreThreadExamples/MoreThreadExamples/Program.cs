using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;

namespace MoreThreadExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort com = new SerialPort("COM5");
            string s = "ComPort opener thread";
            Thread T = new Thread(
                delegate () 
                {
                    ThreadMethod(s, com);
                }
            );
            T.Start();

            Console.Read();
        }

        static void ThreadMethod(string message, SerialPort port)
        {
            Console.WriteLine(message);
            port.Open();
            Console.WriteLine("Port now opened");
            while (true)
            {
                if(port.BytesToRead>0)
                    Console.WriteLine(port.ReadExisting());
            }
            
        }
    }
}
