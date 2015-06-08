using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _02_DistanceCalculator
{
    public static class DistanceCalculator 
    {
        public static double CalcDistanceBetween3DPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double diffX = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double diffY = Math.Pow((firstPoint.Y - secondPoint.Y), 2);
            double diffZ = Math.Pow((firstPoint.Z - secondPoint.Z), 2);

            return Math.Sqrt(diffX + diffY + diffZ);
        }
    }
}
