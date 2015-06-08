using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;

namespace _03_Paths
{
    public class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public Path3D()
        {
            
        }


        public List<Point3D> Path 
        {
            get { return this.path; }
            set
            {
                this.path = value;
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Point3D point in this.Path)
            {
                sb.AppendLine(point.ToString());
            }
            return sb.ToString();
        }
    }
}
