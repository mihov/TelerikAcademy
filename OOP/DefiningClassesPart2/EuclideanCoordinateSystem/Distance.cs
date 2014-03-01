namespace EuclideanCoordinateSystem
{
    using System;

    public static class Distance
    {
        /// <summary>
        /// REturn distance between two points.
        /// </summary>
        /// <param name="pointA">Point A</param>
        /// <param name="pointB">Point B</param>
        /// <returns>Distance between Point A and Point B</returns>
        public static double Calc(Point3D pointA, Point3D pointB)
        {
            double distanceX = (pointA.X - pointB.X) * (pointA.X - pointB.X);
            double distanceY = (pointA.Y - pointB.Y) * (pointA.Y - pointB.Y);
            double distanceZ = (pointA.Z - pointB.Z) * (pointA.Z - pointB.Z);

            return Math.Sqrt(distanceX + distanceY + distanceZ);
        }

    }
}
