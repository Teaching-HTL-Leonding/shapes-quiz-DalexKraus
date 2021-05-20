using System;
using System.ComponentModel;

namespace ShapesQuiz.Model
{
    public abstract class ShapeBase
    {
        public double Area => Math.Round(GetArea(), 2);
        public abstract double GetArea();

        public override string ToString()
        {
            return GetType().Name;
        }   
    }
}
