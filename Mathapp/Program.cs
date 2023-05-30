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
            Console.WriteLine(GeometryClass.GTriangle(5,6));
            Console.WriteLine(GeometryClass.GPTriangle(5,5));
            Console.WriteLine(GeometryClass.GRectangle(10,8));
            Console.WriteLine(GeometryClass.GCircle(15,5));
            Console.WriteLine(GeometryClass.Gtrapezoid(8,5,6)); 





            Console.ReadKey();
        }
        
    }
}
