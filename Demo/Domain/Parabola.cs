using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    public class Parabola : Function
    {

        public Parabola(double a, double b, double c) : base(a, b, c)
        {
        }


        public override double MaxY
        {
            get
            {
                if (A < 0)
                {
                    return -(B * B - 4 * A * C) / 4 * A;
                }
                else
                {
                    return 0;
                }
            }
        }


        public override double MinY
        {
            get
            {
                if (A > 0)
                {
                    return -(B * B - 4 * A * C) / 4 * A;
                }
                else
                {
                    return 0;
                }
            }
        }


        public override double MinX
        {
            get
            {
                if (A > 0)
                {
                    return -B / 2 * A;
                }
                else
                {
                    return 0;
                }
            }
        }


        public override double MaxX
        {
            get
            {
                if (A < 0)
                {
                    return -B / 2 * A;
                }
                else
                {
                    return 0;
                }
            }
        }

        public override double Solve(double x)
        {
            return A * x * x + B * x + C;
        }

    }
}
