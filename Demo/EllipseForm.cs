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

        private int _resultCount;

        public EllipseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Nav(new Menu());
        }

        private void button2_Click(object sender, EventArgs eventArgs)
        {
            
            //Переменные введённые пользователем
            double aPow = 0, bPow = 0, c = 0;

            try
            {
                var atry = double.TryParse(ValueATb.Text, out aPow);
                var btry = double.TryParse(ValueBTb.Text, out bPow);
                var cTry = double.TryParse(textBox1.Text, out c);

                if (!atry || !btry || !cTry)
                {
                    throw new Exception();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Помилка не вірний формат числа!", "Повідомлення про помилку!");
            }


            DataGridElipce.Rows.Add(1);

            DataGridElipce.Rows[_resultCount].Cells[0].Value = $"{_resultCount}";


                //Значение коеф а,b
            var a = Math.Sqrt(aPow);
            var b = Math.Sqrt(bPow);
            DataGridElipce[1, _resultCount].Value = $"{a}";
            DataGridElipce[2, _resultCount].Value = $"{b}";

            //половина расстояния между F1 и F2;

//            c = Math.Sqrt(aPow - bPow);
            //эксцентриситет
            var eArg = c / a;
            DataGridElipce[3, _resultCount].Value = $"{eArg}";

//            var F1 = $"({c};0)";
//            var F2 = $"({-c};0)";

            var textND = "x = a / e";

            var x1 = a / eArg;
            DataGridElipce[4, _resultCount].Value = $"{x1}";

            var ellipse = new Ellipse(a, b, c);

            double y1 = 0;

            try
            {
                y1 = ellipse.Evaluate(x1);
            }
            catch(Exception e)
            {
                MessageBox.Show($"{e.Message}");
                return;
                
            }
            
            DataGridElipce[5, _resultCount].Value = $"{y1}";


            var textPD = "x = -a / e";
            var x2     = -a / eArg;

            negativeDirectrice.Text = $"x = {a}/{eArg}";
            positiveDirectrice.Text = $"x = {-a}/{eArg}";
           

            var y2 = ellipse.Evaluate(x2);

            _resultCount++;
            DataGridElipce.Rows.Add(1);

            DataGridElipce.Rows[_resultCount].Cells[0].Value = $"{_resultCount}";
            DataGridElipce[1, _resultCount].Value = $"{a}";
            DataGridElipce[2, _resultCount].Value = $"{b}";

            DataGridElipce[3, _resultCount].Value = $"{eArg}";
            DataGridElipce[4, _resultCount].Value = $"{x2}";
            DataGridElipce[5, _resultCount].Value = $"{y2}";

            _resultCount++;
        }

        private void EllipseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
