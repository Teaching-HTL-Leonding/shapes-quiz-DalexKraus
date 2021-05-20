using System;

namespace ShapesQuiz.Model
{
    public class Circle : ShapeBase
    {
        public double R { get; set; }

        //public Circle(double radius) => (R) = (radius);

        public override double GetArea()
        {
            return R * R * Math.PI;
        }
    }
}