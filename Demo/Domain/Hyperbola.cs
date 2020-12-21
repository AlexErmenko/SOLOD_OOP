namespace Demo.Domain
{
    public class Hyperbola : Function
    {

        public Hyperbola(double a, double b, double c) : base(a, b, c)
        {
        }

        public override double Evaluate(double x)
        {
            return A / (x - B) + C;
        }

        public override string ShowInfo()
        {
            return base.ShowInfo();
        }

    }
}
