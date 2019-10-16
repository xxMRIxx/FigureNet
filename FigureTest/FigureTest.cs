using System;
using NUnit.Framework;
using Shapes.Figures;
using Shapes.Model;

namespace FigureTest
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        #region Circle

        /// <summary>
        /// ��������� ������� ����� �� ������� � ��� ������ �� �������������
        /// </summary>
        [Test]
        public void CircleArea()
        {

            //-
            var radius = new CircleParams { Radius = 4 };
            var circle = new Circle(radius);
            Assert.IsFalse(circle.IsNegativeNumber());
            var expectedArea = Math.PI * Math.Pow(radius.Radius, 2);

            //-
            var area = circle.GetArea();

            //-
            Assert.AreEqual(expectedArea, area);

        }

        /// <summary>
        /// ���������� ����, ������������� ������
        /// </summary>
        [Test]
        public void CircleAreaNegative()
        {
            //-
            var radius = new CircleParams { Radius = -4 };
            var circle = new Circle(radius);
            //--
            Assert.IsTrue(circle.IsNegativeNumber());
        }

        /// <summary>
        /// ���������� ����, ��� �������
        /// </summary>
        [Test]
        public void CircleAreaNull()
        {
            //-
            var circle = new Circle(null);

            //-
            var area = circle.GetArea();

            //-
            Assert.AreEqual(0, area);
      
        }

        /// <summary>
        /// ���������� ����, �������� ��� ��� ����� ��������
        /// </summary>
        [Test]
        public void CircleAreaByChar()
        {
            //-
            var radius = new CircleParams {Radius = 'A' };
            var circle = new Circle(radius);
            var expectedArea = Math.PI * Math.Pow(radius.Radius, 2);
            //-
            var area = circle.GetArea();
            //-
            Assert.AreEqual(expectedArea, area);

        }

        #endregion

        #region Triangle

        /// <summary>
        /// ������� ��������, ��������� ������� ������������
        /// </summary>
        [Test]
        public void TriangleArea()
        {
            var triangle = new Triangle(new TriangleParams { SideA = 41, SideB = 40, SideC = 9 });

            var area = triangle.GetArea();

            Assert.AreEqual(180, area);

        }

        /// <summary>
        /// ��������� ��� ������� � �������� ��� ����������� �������������
        /// </summary>
        [Test]
        public void TriangleAreaAndCheckIsRectangle()
        {
            var triangle = new Triangle(new TriangleParams { SideA = 41, SideB = 40, SideC = 9 });

            var area = triangle.GetArea();

            Assert.IsTrue(triangle.IsRectangularTriangle());

            Assert.AreEqual(180, area);

        }

        /// <summary>
        /// ��������� ������� ����� �������� �� ��� ����������� ����������, � �����
        /// ��� ��� ������� �� ����� ������������� ��������
        /// </summary>
        [Test]
        public void TriangleExist()
        {
            //--
            var triangle = new Triangle(new TriangleParams { SideA = 41, SideB = 40, SideC = 9 });

            //--
            var area = triangle.GetArea();

            //---
            Assert.IsFalse(triangle.IsNegativeNumber());
            Assert.IsTrue(triangle.IsTriangleExist());
            Assert.AreEqual(180, area);

        }

        /// <summary>
        /// �������� ��� ����������� �� ����������
        /// </summary>
        [Test]
        public void TriangleNoExist()
        {
            //--
            var triangle = new Triangle(new TriangleParams { SideA = 1, SideB = 40, SideC = 9 });

            //---
            Assert.IsFalse(triangle.IsTriangleExist());
       
        }

        /// <summary>
        /// ���������� ����, �������� �� ������������ �������� ������
        /// </summary>
        [Test]
        public void TriangleAreaNotAllParams()
        {
            var triangle = new Triangle(new TriangleParams { SideA = 41});

            var area = triangle.GetArea();

            Assert.AreEqual(Double.NaN, area);

        }

        /// <summary>
        /// ���������� ����, �������� ��� � �� ������������ ������� ��� ����� ���������
        /// </summary>
        [Test]
        public void TriangleAreaByChar()
        {
            var triangle = new Triangle(new TriangleParams { SideA = 'A', SideB = 'B', SideC = 'C' });

            var area = triangle.GetArea();

            Assert.AreEqual(1885.3371051353124, area);

        }

        /// <summary>
        /// �������� ��� ����������� �������������
        /// </summary>
        [Test]
        public void TriangleIsRectangle()
        {
            var triangle = new Triangle(new TriangleParams { SideA = 41, SideB = 40, SideC = 9 });

            Assert.IsTrue(triangle.IsRectangularTriangle());

        }

        #endregion

        #region Square

        /// <summary>
        /// ��������� ������� ��������
        /// </summary>
        [Test]
        public void SquareArea()
        {
            var sides = new SquareParams
            {
                SideA = 5,
                SideB = 5
            };

            var circle = new AnyShape(new Square(sides));

            var area = circle.GetArea();

            var expectedArea = sides.SideA * sides.SideB;

            Assert.AreEqual(expectedArea, area);
        }

        #endregion

        #region AnyShape

        /// <summary>
        /// ��������� ������� ��� ������ ���� ������
        /// </summary>
        [Test]
        public void AnyShapeArea()
        {

            var radius = new CircleParams
            {
                Radius = 4
            };

            var circle = new AnyShape(new Circle(radius));

            var area = circle.GetArea();

            var expectedArea = Math.PI * Math.Pow(radius.Radius, 2);

            Assert.AreEqual(expectedArea, area);

        }

        #endregion
    }
}