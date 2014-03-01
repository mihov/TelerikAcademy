
namespace EuclideanCoordinateSystem
{
    using System;
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D startPoint = new Point3D(0,0,0);

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D StartPoint
        {
            get { return startPoint; }
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}", this.x,this.y,this.z);
        }

    }
}
