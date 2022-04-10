using System;

namespace CalculateArea
{
    public class Triangle : IFigure
    {
        private double _firstSideTriangle;
        private double _secondSideTriangle;
        private double _thirdSideTriangle;

        public Triangle(double firstSideTriangle, double secondSideTriangle, double thirdSideTriangle)
        {
            _firstSideTriangle = firstSideTriangle;
            _secondSideTriangle = secondSideTriangle;
            _thirdSideTriangle = thirdSideTriangle;

        }

        public double GetArea()
        {
            return Math.Sqrt(Math.PI 
                * (Math.PI - _firstSideTriangle) 
                * (Math.PI - _secondSideTriangle) 
                * (Math.PI - _thirdSideTriangle));
        }
    }
}
