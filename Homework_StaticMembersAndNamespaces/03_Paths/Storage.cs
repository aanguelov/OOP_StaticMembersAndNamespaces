using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _01_Point3D;

namespace _03_Paths
{
    public static class Storage
    {
        public static void ExtractPointsFromFile(string fileLocation, List<string> pointsList)
        {
            var allLines = File.ReadAllLines(fileLocation);
            foreach (var line in allLines)
            {
                pointsList.Add(line.ToString());
            }
        }

        public static void LoadPointCoordinates(Path3D path, List<string> lines)
        {
            foreach (string item in lines)
            {        
                int[] array = item.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray();
                Point3D current = new Point3D(array[0], array[1], array[2]);
                path.Path.Add(current);
            }
        }
    }
}
