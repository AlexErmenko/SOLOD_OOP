namespace Demo.Domain
{
    public abstract class Function
    {

        protected Function(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }


        protected double A { get; set; }


        protected double B { get; set; }


        protected double C { get; set; }


        public abstract double MaxY { get; }


        public abstract double MinY { get; }


        public abstract double MinX { get; }


        public abstract double MaxX { get; }


        public abstract double Solve(double x);

        public override string ToString()
        {
            return $"{nameof(A)}: {A}, {nameof(B)}: {B}, {nameof(C)}: {C}, {nameof(MaxY)}: {MaxY}, {nameof(MinY)}: {MinY}, {nameof(MinX)}: {MinX}, {nameof(MaxX)}: {MaxX}";
        }

    }
}
