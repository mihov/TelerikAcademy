namespace EuclideanCoordinateSystem
{
using System;

    class MainProgram
    {
        static void Main()
        {
            // Test for task 1.
            var point1 = new Point3D(1,2,3);
            Console.WriteLine("Point A {0}.", point1.ToString());

            // Test for task 2
            Console.WriteLine("Point B {0}.", Point3D.StartPoint);

            // Test for task 3
            Console.WriteLine("Distance between point A {0} and point B {1} is {2:F2}km.", 
                point1, Point3D.StartPoint, Distance.Calc(point1, Point3D.StartPoint));

            // Test for task 4

            Path path = new Path();

            path.AddPoint(new Point3D(1, 1, 1));
            path.AddPoint(new Point3D(2, 2, 2)); 
            path.AddPoint(new Point3D(3, 3, 3));

            Console.WriteLine("\nPath is:");
            Console.WriteLine(path.ToString());

            string fileName = @"..\..\path.txt";
            string outputFileName = @"..\..\out_path.txt";

            var pathFromFile = new Path();
            pathFromFile = PathStorage.Load(fileName);

            Console.WriteLine("\nPath loaded from file is:");
            Console.WriteLine(pathFromFile.ToString());

            // Append path to pathFromFile 
            for (int currPoint = 0; currPoint < path.Count; currPoint++)
            {
                pathFromFile.AddPoint(path.GetPoint(currPoint));
            }

            PathStorage.Save(pathFromFile, outputFileName);

            var finalPath = new Path();
            finalPath = PathStorage.Load(outputFileName);
            Console.WriteLine("\nPath loaded from saved file is:");
            Console.WriteLine(finalPath.ToString());



        }
    }
}
