using System;
using Shapes.Abstraction;
using Shapes.Interface;
using Shapes.Model;

namespace Shapes.Figures
{
    public class Triangle: Validation, IShapeArea
    {
        private readonly TriangleParams _triangle;

        public Triangle(TriangleParams triangle)
        {
            _triangle = triangle;
        }

        public double GetArea()
        {
            var p = (_triangle.SideA + _triangle.SideB + _triangle.SideC) / 2;
            return Math.Sqrt(p * (p - _triangle.SideA) * (p - _triangle.SideB) * (p - _triangle.SideC));
        }

        public bool IsRectangularTriangle()
        {
            var a = Math.Sqrt(_triangle.SideB * _triangle.SideB + _triangle.SideC * _triangle.SideC);
            var b = Math.Sqrt(_triangle.SideA * _triangle.SideA + _triangle.SideC * _triangle.SideC);
            var c = Math.Sqrt(_triangle.SideB * _triangle.SideB + _triangle.SideA * _triangle.SideA);

            return _triangle.SideA == a || _triangle.SideB == b || _triangle.SideC == c;
        }

        public bool IsTriangleExist()
        {
            var a = _triangle.SideB + _triangle.SideC > _triangle.SideA;
            var b = _triangle.SideA + _triangle.SideC > _triangle.SideB;
            var c = _triangle.SideA + _triangle.SideB > _triangle.SideC;

            return a && b && c;
        }

        public override bool IsNegativeNumber()
        {
            return _triangle.SideA < 0 && _triangle.SideA < 0 && _triangle.SideC < 0;
        }
    }
}
