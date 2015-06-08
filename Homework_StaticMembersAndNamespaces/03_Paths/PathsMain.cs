using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _03_Paths
{
    public class PathsMain
    {
        static void Main(string[] args)
        {
            string path = "../Path3D.txt";
            List<string> pointsAsString = new List<string>();
            Storage.ExtractPointsFromFile(path, pointsAsString);

            Path3D pointsPath = new Path3D();
            Storage.LoadPointCoordinates(pointsPath, pointsAsString);
            Console.WriteLine(pointsPath);
        }
    }
}
