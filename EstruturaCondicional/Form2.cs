using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaCondicional
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (rdbtn1.Checked)
            {
                txtresposta.Text = "Java";
            }
            else if (rdbrn2.Checked)
            {
                txtresposta.Text = "C3";
            }
            else if (rdbtn3.Checked)
            {
                txtresposta.Text = "PHP";
            }
        }
    }
}
