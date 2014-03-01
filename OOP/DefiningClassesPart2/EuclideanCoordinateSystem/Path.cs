using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanCoordinateSystem
{
    public class Path
    {
        private List<Point3D> points;

        public int Count
        {
            get { return this.points.Count; }
        }
        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        public Point3D GetPoint(int index)
        {
            if (index >= 0 && index < points.Count)
            {
                return points[index];
            }
            else throw new IndexOutOfRangeException("Invalid index!");
        }


        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int currentCoorinate = 0; currentCoorinate < points.Count; currentCoorinate++)
            {
                result.Append(points[currentCoorinate].ToString());
                
                if (currentCoorinate < points.Count - 1)
                {
                    result.Append(Environment.NewLine);
                }
            }


            return result.ToString();
        }


    }
}
