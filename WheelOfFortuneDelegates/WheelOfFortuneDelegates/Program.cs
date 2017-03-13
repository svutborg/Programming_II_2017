using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortuneDelegates
{
    class Program
    {
        public delegate int CalculationDelegate(int x, int y);
        static List<CalculationDelegate> Methods;
        static void Main(string[] args)
        {
            Methods = new List<CalculationDelegate>();
            Methods.Add(new CalculationDelegate(Add));
            Methods.Add(new CalculationDelegate(Sub));
            Methods.Add(new CalculationDelegate(Mul));
            Methods.Add(new CalculationDelegate(Div));
            int num1, num2;
            Random R = new Random();
            while (true)
            {
                Console.WriteLine("Enter two integer numbers:");
                int.TryParse(Console.ReadLine(), out num1);
                int.TryParse(Console.ReadLine(), out num2);
                Console.WriteLine($"The result of performing a random calculation with numbers: {num1} and {num2}, is: {Methods[R.Next(0, 3)](num1, num2)}");
            }

        }

        static public int Add(int a, int b)
        {
            return a + b;
        }

        static public int Sub(int a, int b)
        {
            return a - b;
        }

        static public int Mul(int a, int b)
        {
            return a * b;
        }

        static public int Div(int a, int b)
        {
            return a / b;
        }

    }
}
