using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EuclideanCoordinateSystem
{
    public class PathStorage
    {
        private const string START = "[START]";
        private const string END = "[END]";
        private const char SEPARATOR = ':';

        /// <summary>
        /// Load path flom file
        /// </summary>
        /// <param name="fileName">Path file name</param>
        /// <returns>Path of points</returns>
        public static Path Load(string fileName)
        {
            Path resultPath = new Path();

            StreamReader fileStream = new StreamReader(fileName);

            using (fileStream)
            {
                string currentLine = fileStream.ReadLine();

                if (currentLine == START)
                {
                    string[] pointArray = new string[3];

                    while ((currentLine = fileStream.ReadLine()) != null)
                    {
                        if (currentLine == END)
                        {
                            break;
                        }

                        pointArray = currentLine.Split(new char[] { SEPARATOR, ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        resultPath.AddPoint(
                            new Point3D(
                                double.Parse(pointArray[0]),
                                double.Parse(pointArray[1]),
                                double.Parse(pointArray[2])));
                    }
                }
            }

            return resultPath;
        }

        
        /// <summary>
        /// Save path of points to file
        /// </summary>
        /// <param name="pathOfPoints">Path of points</param>
        /// <param name="fileName">File name</param>
        public static void Save(Path pathOfPoints, string fileName)
        {
            StreamWriter fileStream = new StreamWriter(fileName);
            using (fileStream)
            {
                fileStream.WriteLine(START);
                fileStream.WriteLine(pathOfPoints.ToString());
                fileStream.WriteLine(END);
            }
        }
    }
}
