using System;
using System.Windows.Forms;

namespace Demo.Domain
{
    /// <summary>
    /// Реалізація функції для рівняння параболи
    /// </summary>
    public class Ellipse : Function
    {
        /// <summary>
        /// Виклик конструктора базового класу для ініціалізації полів
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Ellipse(double a, double b, double c) : base(a, b, c)
        {
        }

        /// <summary>
        /// Реалізація розрахунку функції параболи для певного - x
        /// </summary>
        /// <param name="x">Аргумент методу</param>
        /// <returns></returns>
        public override double Evaluate(double x)
        {
            var argSqrt = A - x * x * B;
            if (argSqrt < 0)
            {
                argSqrt *= -1;
            }
            if (argSqrt <= 0)
            {
                throw new Exception("Неможливо знайти значення кореню квадратного з від'ємного числа");
            }
            return Math.Sqrt(argSqrt) + C;
        }
        /// <summary>
        /// Перевантажений базовий метод для виводу інформації, спецефічної для эліпсу
        /// </summary>
        /// <returns>Характеристики об'єкта</returns>
        public override string ShowInfo()
        {
            var e = C / A;
            var p = (B * B) / A; 
            return base.ShowInfo() + $"\nЭксцентриситет = {e}\n" + $"Половина длины хорды = {p}\n";
        }

    }
}
