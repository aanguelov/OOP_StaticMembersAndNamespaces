using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    public class Point3DMain
    {
        public static void Main(string[] args)
        {
            Point3D point = new Point3D(2.4, 3.5, 1.3);
            Console.WriteLine(point);
            Point3D pointZero = Point3D.StartingPoint;
            Console.WriteLine(pointZero);
            
        }
    }
}
