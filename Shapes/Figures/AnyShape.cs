using Shapes.Interface;

namespace Shapes.Figures
{
    public class AnyShape: IShapeArea
    {
        private readonly IShapeArea _shape;

        public AnyShape(IShapeArea shape)
        {
            _shape = shape;
        }

        public double GetArea()
        {
            return _shape.GetArea();
        }
    }
}
