using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public static class Navigator
    {

        public static void Nav(this Form from, Form to)
        {
            from.Hide();
            to.Show();
        }
    }
}
