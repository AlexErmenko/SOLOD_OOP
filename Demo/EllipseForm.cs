using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Demo.Domain;

namespace Demo
{
    public partial class EllipseForm : Form
    {

        private int resultCount;

        public EllipseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Nav(new Menu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridElipce.Rows.Add(1);

            DataGridElipce.Rows[resultCount].Cells[0].Value = $"{resultCount}";

            //Переменные введённые пользователем
            double aPow = 0, bPow = 0;

            try
            {
                var atry = double.TryParse(ValueATb.Text, out aPow);
                var btry = double.TryParse(ValueBTb.Text, out bPow);

                if (!atry || !btry)
                {
                    throw new Exception();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Помилка не вірний формат числа!", "Повідомлення про помилку!");
            }

            var a = Math.Sqrt(aPow);
            var b = Math.Sqrt(bPow);

            //половина расстояния между F1 и F2;

            var c = Math.Sqrt(aPow - bPow);
            //эксцентриситет
            var eArg = c / a;

            var F1 = $"({c};0)";
            var F2 = $"({-c};0)";

            var textND = "x = -a / e";

            var negativeDirectriceVal = -a / eArg;


            var textPD = "x = a / e";
            var x2     = a / eArg;

            negativeDirectrice.Text = $"x = {-a}/{e}";
            positiveDirectrice.Text = $"x = {a}/{e}";
            var ellipse = new Ellipse(a, b, c);

            var y = ellipse.Evaluate(negativeDirectriceVal);
            var y2 = ellipse.Evaluate(x2);

            DataGridElipce[1, resultCount].Value = aPow;
            DataGridElipce[2, resultCount].Value = bPow;
            DataGridElipce[3, resultCount].Value = c;
            // DataGridElipce[4, resultCount].Value = x;
            // DataGridElipce[5, resultCount].Value = y;
            DataGridElipce[6, resultCount].Value = F1;
            DataGridElipce[7, resultCount].Value = F2;
            resultCount++;
        }

        private void EllipseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
