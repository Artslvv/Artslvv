
namespace CalculateArea
{
    public class Figure: IFigure
    {
        private double[] _sideArray;

        public Figure(double[] sideArray)
        {

            _sideArray = sideArray;
        }
        public double GetArea()
            {
                if (_sideArray.Length == 1)
                {
                    var circle = new Circle(_sideArray);
                    return circle.GetArea();
                }
                if (_sideArray.Length == 3)
                {
                    var triangle = new Triangle(_sideArray);
                    return triangle.GetArea();
                }
                return 0;
        }
    }
}
