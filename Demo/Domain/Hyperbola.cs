namespace Demo.Domain
{
    /// <summary>
    /// Реалізація функції для рівняння гіперболи
    /// </summary>
    public class Hyperbola : Function
    {
        /// <summary>
        /// Виклик конструктора базового класу для ініціалізації полів
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Hyperbola(double a, double b, double c) : base(a, b, c)
        {
        }

        /// <summary>
        /// Реалізація розрахунку функції гіперболи для певного - x
        /// </summary>
        /// <param name="x">Аргумент методу</param>
        /// <returns>f(x)</returns>
        public override double Evaluate(double x)
        {
            return (B / A) * x;
        }

        /// <summary>
        /// Перевантажений базовий метод для виводу інформації, спецефічної для гіперболи
        /// </summary>
        /// <returns>Характеристики об'єкта</returns>
        public override string ShowInfo()
        {
            return base.ShowInfo();
        }
    }
}