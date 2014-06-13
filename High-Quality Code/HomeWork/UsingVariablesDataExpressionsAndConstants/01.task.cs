using System;

/// <summary>
/// /
/// </summary>
class Task01
{
    /// <summary>
    /// /////
    /// </summary>
    /// <param name="figure"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static Size GetRotatedSize(Size figure, double angle)
    {
        double absCos = Math.Abs(Math.Cos(angle));
        double absSin = Math.Abs(Math.Sin(angle));

        double cosWidth = absCos * figure.Width;
        double sinHeight = absSin * figure.Height;
        double newWidth = cosWidth + sinHeight;

        double sinWidth = absSin * figure.Width;
        double cosHeight = absCos * figure.Height;
        double newHeight = sinWidth + cosHeight;

        return new Size(newWidth, newHeight);
    }    
    
    /// <summary>
    /// ///////
    /// </summary>
    public class Size
    {
        /// <summary>
        /// /
        /// </summary>
        private double width;
        
        /// <summary>
        /// //////
        /// </summary>
        private double height;

        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        
        /// <summary>
        /// /
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }
        }
        
        /// <summary>
        /// ///////
        /// </summary>
        public double Height
        {
            get
            {
                return this.width;
            }
        }
    }
}