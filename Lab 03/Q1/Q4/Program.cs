using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Shape
    {
        public string ShapeType { get; protected set; }
        public double Area { get; protected set; }

        public virtual void CalculateArea(double val1, double val2)
        {
            Area = val1 * val2;
        }

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine("Shape Type: " + ShapeType);
            Console.WriteLine("Area: " + Area);
        }

        public Shape(string shapeType)
        {
            ShapeType = shapeType;
            Area = 0;
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea(length, width);
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
        }

        public Rectangle() : base("Rectangle")
        {
        }
    }

    class Circle : Shape
    {
        private double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
            CalculateArea(radius, radius);
            Area *= Math.PI;
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine("Radius: " + radius);
        }

        public Circle() : base("Circle")
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimensions(5, 3);
            Console.WriteLine("Rectangle Information:");
            rectangle.DisplayShapeInfo();

            Console.WriteLine();

            Circle circle = new Circle();
            circle.SetRadius(4);
            Console.WriteLine("Circle Information:");
            circle.DisplayShapeInfo();

            Console.ReadKey();
        }
    }
}