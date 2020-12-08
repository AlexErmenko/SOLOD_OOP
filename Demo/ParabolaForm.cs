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
        public ParabolaForm()
        {
            InitializeComponent();
        }

        private void calulateBtn_Click(object sender, EventArgs e)
        {
            //Parabola ideal
            var    a = double.Parse(ValueATb.Text);
            var    b = double.Parse(ValueBTb.Text);
            var    c = double.Parse(ValueCTb.Text);
            double x = 0;


            x = -(b / (2 * a));
            var parabola = new Parabola(a, b, c);
            var y        = parabola.Solve(x);
        }
    }
}
