using System;
using Shapes.Abstraction;
using Shapes.Interface;
using Shapes.Model;

namespace Shapes.Figures
{
    public class Circle : Validation, IShapeArea
    {
        private readonly CircleParams _circle;

        public double GetArea()
        {
            return Math.PI * Math.Pow(_circle.Radius, 2);
        }

        public Circle(CircleParams circle)
        {
            _circle = circle ?? new CircleParams();
        }

        public override bool IsNegativeNumber()
        {
            return _circle.Radius < 0;
        }
    }
}
