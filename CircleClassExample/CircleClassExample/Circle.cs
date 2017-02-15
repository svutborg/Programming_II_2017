using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleClassExample
{
    struct Point
    {
        double x;
        double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Circle
    {
        double r = 1;
        Point c;
        double circ;
        double area;

        public static int Counter { get; private set; }
        
        public Circle()
        {
            c = new Point(0,0);
            CalcArea();
            CalcCirc();
            Counter++;
        }
        public Circle(double r, Point c)
        {
            this.r = r;
            this.c = c;
            CalcArea();
            CalcCirc();
            Counter++;
        }

        void CalcArea()
        {
            area = Math.PI * r * r;
        }

        void CalcCirc()
        {
            circ = Math.PI * 2 * r;
        }
    }
}
