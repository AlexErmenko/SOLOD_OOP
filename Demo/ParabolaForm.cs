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
    public partial class ParabolaForm : Form
    {

        private int resultCount = 0;

        public ParabolaForm()
        {
            InitializeComponent();
        }

        private void calulateBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1);

            dataGridView1.Rows[resultCount].Cells[0].Value = $"{resultCount}";


            //Parabola ideal
            var a = double.Parse(ValueATb.Text);
            var b = double.Parse(ValueBTb.Text);
            var c = double.Parse(ValueCTb.Text);
            var arrows = "";


            if (a > 0)
            {
                arrows = "Вверх";
            }
            else
            {
                arrows = "Вниз";
            }

            dataGridView1[1, resultCount].Value = a;
            dataGridView1[2, resultCount].Value = b;
            dataGridView1[3, resultCount].Value = c;
            dataGridView1[4, resultCount].Value = arrows;
            

            double x = 0;


            x = -b / (2 * a);

            var parabola = new Parabola(a, b, c);

            var y        = parabola.Solve(x);
            dataGridView1[5, resultCount].Value = $"({x};{y})";
            resultCount++;
        }

        private void ParabolaForm_Load(object sender, EventArgs e)
        {
            ValueATb.Text = "1";
        }

        private void ValueATb_TextChanged(object sender, EventArgs e)
        {
            var aCoef = ValueATb.Text;
            var bCoef = ValueBTb.Text;
            var cCoef = ValueCTb.Text;


            parabolaDiff.Text = $"y = {aCoef}x^2 + {bCoef}x + {cCoef}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Nav(new Menu());
        }
    }
}
