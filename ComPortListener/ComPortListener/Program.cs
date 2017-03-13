using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ComPortListener
{
    class Program
    {
        static SerialPort sp = new SerialPort();

        static void Main(string[] args)
        {
            Console.WriteLine("Select one of the following ports:");
            foreach(string s in SerialPort.GetPortNames())
            {
                Console.WriteLine(s);
            }
            sp.PortName = Console.ReadLine();
            sp.Open();
            sp.ReadExisting();
            sp.DataReceived += Sp_DataReceived;



            Console.Read();
        }

        private static void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Console.Write(sp.ReadExisting());
        }
    }
}
