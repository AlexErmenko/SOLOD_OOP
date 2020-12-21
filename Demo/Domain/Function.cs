using System.Text;

namespace Demo.Domain
{
    /// <summary>
    /// Абстрактний клас функції для розрахунку y = f(x)
    /// </summary>
    public abstract class Function
    {

        /// <summary>
        /// Конструктор для ініціалізації полів 
        /// </summary>
        /// <param name="a">Значення змінної а</param>
        /// <param name="b">Значення змінної b</param>
        /// <param name="c">Значення змінної c</param>
        protected Function(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Автопроперті для зберігання значення зміної А
        /// </summary>
        protected double A { get; set; }

        /// <summary>
        /// Автопроперті для зберігання значення зміної B
        /// </summary>
        protected double B { get; set; }

        /// <summary>
        /// Автопроперті для зберігання значення зміної C
        /// </summary>
        protected double C { get; set; }

        /// <summary>
        /// Абстрактний метод розрахунку функції
        /// </summary>
        /// <param name="x">Відносно якого значення x буде розраховуватись y</param>
        /// <returns>Y</returns>
        public abstract double Evaluate(double x);

        /// <summary>
        /// Базовий віртуальний метод для виведення характеристик об'єкту
        /// </summary>
        /// <returns></returns>
        public virtual string ShowInfo()
        {
            var sb = new StringBuilder();
            sb.Append($"Вивід характеристик функції\n");
            sb.Append($"A = {A}\n");
            sb.Append($"B = {B}\n");
            sb.Append($"C = {C}\n");


            return sb.ToString();
        }

    }
}
