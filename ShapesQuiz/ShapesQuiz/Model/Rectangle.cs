namespace ShapesQuiz.Model
{
    public class Rectangle : ShapeBase
    {
        public double A { get; set; }
        public double B { get; set; }
        
        //public Rectangle(double a, double b) => (A, B) = (a, b);

        public override double GetArea()
        {
            return A * B;
        }
    }
}