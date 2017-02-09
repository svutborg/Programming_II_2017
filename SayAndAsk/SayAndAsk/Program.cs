using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayAndAsk
{
    class Program
    {
        static void Main(string[] args)
        {
            Say("Hello");

            Ask("Did you like the weather today?");
            while (true)
            {
                Repeat();
            }
        }

        static void Say(string sentence)
        {
            Console.WriteLine(sentence);
        }

        static string Ask(string question)
        {
            Say(question);
            return Console.ReadLine();
        }

        static void Repeat()
        {
            string line = Console.ReadLine();
            Console.WriteLine(line);
        }
    }
}
