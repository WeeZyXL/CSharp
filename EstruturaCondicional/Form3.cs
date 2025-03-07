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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preco = 0;
            preco = double.Parse(txtvalor.Text);


            if (ckbx1.Checked)
            {
                preco = preco += 2;
            }
            else if (ckbx2.Checked)
            {
                preco = preco += 5;
            }

            txttotal.Text = preco.ToString();
        }
    }
}
