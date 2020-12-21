using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain
{
    /// <summary>
    /// Реалізація функції для рівняння параболи
    /// </summary>
    public class Parabola : Function
    {
        /// <summary>
        /// Виклик конструктора базового класу для ініціалізації полів
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Parabola(double a, double b, double c) : base(a, b, c)
        {
        }


        /// <summary>
        /// Реалізація розрахунку функції параболи для певного - x
        /// </summary>
        /// <param name="x">Аргумент методу</param>
        /// <returns>f(x)</returns>
        public override double Evaluate(double x)
        {
            return A * x * x + B * x + C;
        }
        /// <summary>
        /// Перевантажений базовий метод для виводу інформації, спецефічної для параболи
        /// </summary>
        /// <returns>Характеристики об'єкта</returns>
        public override string ShowInfo()
        {
            var orientGilk = "";

            if (A > 0)
            {
                orientGilk = "Гілки направлені до гори";
            }else if (Math.Abs(A) < 0)
            {
                orientGilk = "Гілки відсутні";
            }
            else if (A < 0)
            {
                orientGilk = "Гілки направлені донизу";
            }

            var d                = (B * B) - 4 * A * C;
            var contactWithXAxis = "";

            if (d > 0)
            {
                contactWithXAxis = "Перетинає Oc X - 2 рази";
            }

            if (d == 0)
            {
                contactWithXAxis = "Перетинає  Oc X - 1 раз";
            }

            if (d < 0)
            {
                contactWithXAxis = "Перетинає Oc X - 0 разів";
            }


            return base.ShowInfo() + $"\n{orientGilk}\n" + $"{contactWithXAxis}\n";
        }

    }
}
