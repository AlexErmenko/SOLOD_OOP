using System;
using System.Windows.Forms;

using Demo.Domain;

namespace Demo
{
    public partial class Main : Form
    {

        private int Func = 0;

        public Main()
        {
            InitializeComponent();
        }


        private void calulateBtn_Click(object sender, EventArgs e)
        {
            if (Func != 2)
            {
                return;
            }

            //Parabola ideal
            var    a  = double.Parse(ValueATb.Text);
            var    b  = double.Parse(ValueBTb.Text);
            var    c  = double.Parse(ValueCTb.Text);
            double x = 0;
            

            


            x = -(b / (2 * a));
            var parabola = new Parabola(a, b, c);
            var y = parabola.Evaluate(x);
        }

        private void hyperbolaRb_CheckedChanged(object sender, EventArgs e)
        {
            Func = 0;
        }

        private void parabolaRb_CheckedChanged(object sender, EventArgs e)
        {
            Func = 2;
        }

    }
}
