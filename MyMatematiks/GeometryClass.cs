using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatematiks
{
    public class GeometryClass
    {
        public static double GTriangle(double x, double y)
        {
            double S = (x * y) / 2;
            return S;
        }
        public static double GPTriangle(double x, double z)
        {
            double S = (x * z) / 2;
            return S;
        }
        public static double GRectangle(double a,double b)
        {
           double S = a * b;
            return S;
        }
        public static int GCircle(double a, double p)

        {
            p = 3.14;
            double S = (a * a) * p;
            return (int)S;
        }
        public static double Gtrapezoid(double a,double b,double h)
        {
            double S = ((a + b) / 2 * h);
            return  S;
        }
    }
}
