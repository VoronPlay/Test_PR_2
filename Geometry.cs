using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTask
{
    public class Geometry
    {
        public static void Main()
        {

        }
        public int RectangleArea(int a, int b)
        {
            a = 3;
            b = 5;
            int expected = a * b;
            return expected;
        }

        public double RectangleArea2(double r, double h)
        {
            r = 2;
            h = 4;
            double V = (Math.PI * Math.Pow(r, 2)) * h;
            return V;
        }
    }
}
