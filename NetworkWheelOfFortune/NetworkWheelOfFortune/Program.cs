using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkWheelOfFortune
{
    class Program
    {
        public delegate int CalculationDelegate(int a, int b);
        static void Main(string[] args)
        {
            List<CalculationDelegate> methods = new List<CalculationDelegate>();
            methods.Add(Add);
            methods.Add(Sub);
            methods.Add(Mul);
            methods.Add(Div);
            methods.Add(YouLoose);
            Random R = new Random();

            while (true)
            {
                Console.WriteLine("Enter two integer numbers");
                int.TryParse(Console.ReadLine(), out int num1);
                int.TryParse(Console.ReadLine(), out int num2);

                Console.WriteLine($"The result of doing a random calculation with the numbers {num1} and {num2} is: {methods[R.Next(0, methods.Count-1)](num1, num2)}");
            }

        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Sub(int x, int y)
        {
            return x - y;
        }
        private static int Mul(int x, int y)
        {
            return x * y;
        }
        private static int Div(int x, int y)
        {
            return x / y;
        }
        private static int YouLoose(int dummy1, int dummy2)
        {
            return 0;
        }
    }
}
