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
    public partial class HyperbolaForm : Form
    {
        private int _resultCount;

        public HyperbolaForm()
        {
            InitializeComponent();
        }

        private void calulateBtn_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(ValueATb.Text);

            var b = Convert.ToInt32(ValueBTb.Text);

            var c = Convert.ToInt32(ValueCTb.Text);

            var x = -(a * a / c);
            var x1 = (a * a / c);

            var hyperbola = new Hyperbola(a, b, c);

            var y1 = hyperbola.Evaluate(x);
            var y2 = hyperbola.Evaluate(x1);

            hyperbolaDataGrid.Rows.Add(1);
            hyperbolaDataGrid.Rows[_resultCount].Cells[0].Value = $"{_resultCount}";
            hyperbolaDataGrid[1, _resultCount].Value = a;
            hyperbolaDataGrid[2, _resultCount].Value = b;
            hyperbolaDataGrid[3, _resultCount].Value = c;
            hyperbolaDataGrid[4, _resultCount].Value = x;
            hyperbolaDataGrid[5, _resultCount].Value = y1;
            _resultCount++;

            hyperbolaDataGrid.Rows.Add(1);
            hyperbolaDataGrid.Rows[_resultCount].Cells[0].Value = $"{_resultCount}";
            hyperbolaDataGrid[1, _resultCount].Value = a;
            hyperbolaDataGrid[2, _resultCount].Value = b;
            hyperbolaDataGrid[3, _resultCount].Value = c;
            hyperbolaDataGrid[4, _resultCount].Value = x1;
            hyperbolaDataGrid[5, _resultCount].Value = y2;
            _resultCount++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Nav(new Menu());

        }
    }
}