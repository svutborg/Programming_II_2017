using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStruct
{
    struct Time
    {
        byte hours;
        byte minutes;
        byte seconds;

        public Time(byte hours, byte minutes, byte seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Time(byte hours, byte minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            seconds = 0;
        }

        public override string ToString()
        {
            return $"{hours.ToString().PadLeft(2, '0')}:" +
                $"{minutes.ToString().PadLeft(2, '0')}:" +
                $"{seconds.ToString().PadLeft(2,'0')}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time T = new Time(10, 27);
            
            Console.WriteLine($"{T.ToString()}");
            //Console.WriteLine("{0} {1} {2}", T.hours, T.minutes, T.seconds);

            Console.Read();
        }
    }
}
