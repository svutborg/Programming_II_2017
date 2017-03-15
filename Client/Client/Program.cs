using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    class Program
    {
        static Socket S;
        static void Main(string[] args)
        {
            S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip;
            string ans;
            do
            {
                Console.WriteLine("Enter a valid IP addres to connect to:");
                ans = Console.ReadLine();
            } while (!IPAddress.TryParse(ans, out ip));
            
            try
            {
                S.Connect(ip, 7913);

                while (true)
                {
                    Console.WriteLine("Type in a message for the host");
                    string message = Console.ReadLine();
                    if (message == "quit")
                        break;
                    S.Send(Encoding.UTF8.GetBytes(message));
                }
                
                S.Disconnect(false);

            }
            catch (SocketException se)
            {
                Console.WriteLine(se);
            }
            finally
            {
                if(S!= null)
                {
                    if (S.Connected)
                        S.Disconnect(false);
                    S.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
