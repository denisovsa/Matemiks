using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatematiks
{
    public static class AlgebraClass
    {
        public static double SecondAsign(double a, double b)
        {
            return -a / b;
        }

        public static double LinUr(double a, double b)
        {
            Double x = -(b / a);
            return x;
        }
        public static int Sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = a;

            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                b += a;
            }
            return b;
        }
        public static double ThirdAssign(double[] arr)
        {
            return arr.Sum();
        }
        public static double FourthAssign(double[] arr)
        {
            return arr.Max();
        }
        public static double FifthAssign(double[] arr)
        {
            return arr.Average();
        }



    }
}
