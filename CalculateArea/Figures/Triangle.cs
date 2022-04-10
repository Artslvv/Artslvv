using System;

namespace CalculateArea
{
    public class Triangle : IFigure
    {
        private double[] _sideTriangle = new double[3];

        public Triangle(double[] sideTriangle)
        {

            _sideTriangle = sideTriangle;
        }

        public double GetArea()
        {
            return Math.Sqrt(Math.PI 
                * (Math.PI - _sideTriangle[0]) 
                * (Math.PI - _sideTriangle[1]) 
                * (Math.PI - _sideTriangle[2]));
        }
        public bool СheckRightTriangle() 
        {
            Array.Sort(_sideTriangle);
            if(Math.Pow(_sideTriangle[2],2) == (Math.Pow(_sideTriangle[0],2) + Math.Pow(_sideTriangle[1],2)))
            {
                return true;
            }
            return false;
        }
    }
}
