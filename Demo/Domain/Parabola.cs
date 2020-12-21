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


        // public override double MaxY
        // {
        //     get
        //     {
        //         if (A < 0)
        //         {
        //             return -(B * B - 4 * A * C) / 4 * A;
        //         }
        //         else
        //         {
        //             return 0;
        //         }
        //     }
        // }


        // public override double MinY
        // {
        //     get
        //     {
        //         if (A > 0)
        //         {
        //             return -(B * B - 4 * A * C) / 4 * A;
        //         }
        //         else
        //         {
        //             return 0;
        //         }
        //     }
        // }
        //
        //
        // public override double MinX
        // {
        //     get
        //     {
        //         if (A > 0)
        //         {
        //             return -B / 2 * A;
        //         }
        //         else
        //         {
        //             return 0;
        //         }
        //     }
        // }
        //
        //
        // public override double MaxX
        // {
        //     get
        //     {
        //         if (A < 0)
        //         {
        //             return -B / 2 * A;
        //         }
        //         else
        //         {
        //             return 0;
        //         }
        //     }
        // }
        //
        public override double Evaluate(double x)
        {
            return A * x * x + B * x + C;
        }

        public override string ShowInfo()
        {
            var orientGilk = "";

            if (A > 0)
            {
                orientGilk = "Гілки направлені до гори";
            }

            if (A == 0)
            {
                orientGilk = "Гілки відсутні";
            }

            if (A < 0)
            {
                orientGilk = "Гілки направлені донизу";
            }

            var D                = (B * B) - 4 * A * C;
            var contactWithXAxis = "";

            if (D > 0)
            {
                contactWithXAxis = "перетинає Oc X - 2 рази";
            }

            if (D == 0)
            {
                contactWithXAxis = "перетинає  Oc X - 1 раз";
            }

            if (D < 0)
            {
                contactWithXAxis = "перетинає Oc X - 0 разів";
            }


            return base.ShowInfo() + $"\n{orientGilk}\n" + $"{contactWithXAxis}\n";
        }

    }
}
