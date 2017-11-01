using System;

namespace Lib1
{
    public class HRectangular
    {
        private double side1;
        private double side2;

        public HRectangular(double v1, double v2)
        {
            this.side1 = v1;
            this.side2 = v2;
        }

        public double computeArea()
        {
            return side1 * side2;
        }
    }
}