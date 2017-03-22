using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace Ping
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.NetworkInformation.Ping P = new System.Net.NetworkInformation.Ping();
            Console.WriteLine("What to ping?");
            string reply = Console.ReadLine();

            P.PingCompleted += P_PingCompleted;
            P.SendAsync(reply,null);
            /*PingReply r = P.Send(reply);

            Console.WriteLine(r);


            */
            Console.Read();
            
        }

        private static void P_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            Console.WriteLine(e.Reply.RoundtripTime);
        }
    }
}
