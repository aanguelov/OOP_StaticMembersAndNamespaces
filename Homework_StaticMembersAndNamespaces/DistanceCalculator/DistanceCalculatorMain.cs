using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _02_DistanceCalculator
{
    public class DistanceCalculatorMain
    {
        public static void Main(string[] args)
        {
            Point3D firstPoint = new Point3D(2.4, 3.5, 4.6);
            Point3D secondPoint = new Point3D(9.8, 8.7, 6.5);
            double distance = DistanceCalculator.CalcDistanceBetween3DPoints(firstPoint, secondPoint);
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
            Console.WriteLine("Distance between them: {0}",distance);
        }
    }
}
