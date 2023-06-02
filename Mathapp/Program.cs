using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMatematiks;

namespace Mathapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(GeometryClass.GTriangle(5,6));
            Console.WriteLine(GeometryClass.GPTriangle(5,5));
            Console.WriteLine(GeometryClass.GRectangle(10,8));
            Console.WriteLine(GeometryClass.GCircle(15,5));
            Console.WriteLine(GeometryClass.Gtrapezoid(8,5,6));


            Console.WriteLine(AlgebraClass.SecondAsign(3,4));
            Console.WriteLine(AlgebraClass.LinUr(5,6));
            Console.WriteLine(AlgebraClass.Sum());
            Console.WriteLine(AlgebraClass.ThirdAssign(arr));
            Console.WriteLine(AlgebraClass.FourthAssign(arr));
            Console.WriteLine(AlgebraClass.FifthAssign(arr));
            //Console.WriteLine(AlgebraClass.
            //Console.WriteLine(AlgebraClass.


            Console.WriteLine(TrigonometryClass.Sin(8,2));
            Console.WriteLine(TrigonometryClass.Cos(7,3));
            Console.WriteLine(TrigonometryClass.Tan(6,4));
            Console.WriteLine(TrigonometryClass.CTan(5,5));
            Console.WriteLine(TrigonometryClass.ArcSin(4,6));

            Console.ReadKey();
        }
        
    }
}
