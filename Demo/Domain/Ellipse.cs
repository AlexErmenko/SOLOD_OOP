using System;

namespace Demo.Domain
{
    /// <summary>
    /// sqrt(a-x*x*b)+c
    /// </summary>
    public class Ellipse : Function
    {

        private double maxY;
        private double minY;
        private double minX;
        private double maxX;

        public Ellipse(double a, double b, double c) : base(a, b, c)
        {
        }


        public override double MaxY => maxY;


        public override double MinY => minY;


        public override double MinX => minX;


        public override double MaxX => maxX;


        public override double Solve(double x)
        {
            return Math.Sqrt(A - x * x * B) + C;
        }
        
        

    }
}
