namespace Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Triangle
    {
        private const string InvalidSideMSG = "Side can not be <= 0.";
        private const string InvalidTriangleMSG = "Those are not sides of a triangle.";

        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            CheckTriangleIsValid(sideA, sideB, sideC);

            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double SideA
        {
            get
            {
                return this.sideA;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidSideMSG);
                }

                this.sideA = value;
            }
        }

        public double SideB
        {
            get
            {
                return this.sideB;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidSideMSG);
                }

                this.sideB = value;
            }
        }

        public double SideC
        {
            get
            {
                return this.sideC;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidSideMSG);
                }

                this.sideC = value;
            }
        }

        public double Area
        {
            get
            {
                double halfPerimeter = (this.SideA + this.SideB + this.SideC) / 2;
                double area = Math.Sqrt(halfPerimeter * (halfPerimeter - this.SideA) * (halfPerimeter - this.SideB) * (halfPerimeter - this.SideC));

                return area;
            }
        }

        private static void CheckTriangleIsValid(double sideA, double sideB, double sideC)
        {
            bool isValid = sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA;

            if (!isValid)
            {
                throw new ArgumentException(InvalidTriangleMSG);
            }
        }
    }
}
