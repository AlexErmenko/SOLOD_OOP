using System;

namespace Demo.Domain
{
    /// <summary>
    /// sqrt(a-x*x*b)+c
    /// </summary>
    public class Ellipse : Function
    {

        public Ellipse(double a, double b, double c) : base(a, b, c)
        {
        }


        public override double Evaluate(double x)
        {
            return Math.Sqrt(A - x * x * B) + C;
        }

        public override string ShowInfo()
        {
            return base.ShowInfo();
        }

    }
}
