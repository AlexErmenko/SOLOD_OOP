using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Domain
{
    public class Series
    {

        public Series()
        {
            _functions = new List<Function>();
        }

        private ICollection<Function> _functions;


        public ICollection<Function> Functions
        {
            get => _functions;
            set => _functions = value;
        }


        public IEnumerator<string> ShowObjects()
        {
            if (_functions.Any())
            {
                foreach (var func in _functions)
                {
                    switch (func)
                    {
                        case Ellipse ellipse:

                            yield return ellipse.ShowInfo();


                            break;

                        case Hyperbola hyperbola:

                            yield return hyperbola.ShowInfo();


                            break;

                        case Parabola parabola:

                            yield return parabola.ShowInfo();


                            break;

                        default:

                            throw new ArgumentOutOfRangeException(nameof(func));
                    }
                }
            }
        }


        public double FindMinimumY()
        {
            return 0;
        }

        public double FindMaximumY()
        {
            return 0;
        }

    }
}
