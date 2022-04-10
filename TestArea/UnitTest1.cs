using System;
using Xunit;
using CalculateArea;

namespace TestArea
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircleReturnArea()
        {
            var circle1 = new Circle(new double[] {10});
            var result = circle1.GetArea();
            double expected = Math.PI * Math.Pow(10, 2);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestTriandleReturnArea()
        {
            var triangle1 = new Triangle(new double[] { 10, 6, 3 });
            var result = triangle1.GetArea();
            double expected = Math.Sqrt(Math.PI
                * (Math.PI - 10)
                * (Math.PI - 6)
                * (Math.PI - 3));
            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestCheckRightTriangle()
        {
            var triangle2 = new Triangle(new double[] { 4, 5, 3 });
            bool result = triangle2.ÑheckRightTriangle();
            Assert.True(result);
        }
        [Fact]
        public void TestFigureReturnArea()
        {
            var figure1 = new Figure(new double[] { 10, 6, 3 });
            var result = figure1.GetArea();
            double expected = Math.Sqrt(Math.PI
                * (Math.PI - 10)
                * (Math.PI - 6)
                * (Math.PI - 3));
            Assert.Equal(expected, result);
        }
    }
}
