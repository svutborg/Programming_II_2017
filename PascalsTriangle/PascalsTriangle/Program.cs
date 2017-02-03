using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] triangle;
            int numRows = 10;

            triangle = new int[numRows][];
            triangle[0] = new int[1];

            for (int i = 0; i < numRows; i++)
            {
                triangle[i + 1] = new int[i + 2];
                for(int j = 0; j < i; j++)
                {
                    triangle[i + 1][j] = triangle[i][j];
                    triangle[i + 1][j+1] = triangle[i][j];
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{triangle[i][j]} ");
                }
                Console.Write("\n");
            }

            Console.Read();
        }
    }
}
