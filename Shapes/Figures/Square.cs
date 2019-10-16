using System;
using System.Collections.Generic;
using System.Text;
using Shapes.Abstraction;
using Shapes.Interface;
using Shapes.Model;

namespace Shapes.Figures
{
    public class Square: Validation, IShapeArea
    {
        private readonly SquareParams _square;

        public Square(SquareParams square)
        {
            _square = square;
        }

        public double GetArea()
        {
            return _square.SideA * _square.SideB;
        }

        public override bool IsNegativeNumber()
        {
            return _square.SideA < 0 && _square.SideB < 0;
        }
    }
}
