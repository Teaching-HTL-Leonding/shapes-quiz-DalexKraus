namespace ShapesQuiz.Model
{
    public class Triangle : ShapeBase
    {
        public double A { get; set; }
        public double Height { get; set; }

        //public Triangle(double a, double height) => (A, Height) = (a, height);

        public override double GetArea()
        {
            return (A * Height) / 2.0D;
        }
    }
}