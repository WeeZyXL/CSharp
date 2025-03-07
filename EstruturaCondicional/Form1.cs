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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDescobrir_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(txtNumero.Text);

            if(numero % 2 == 0) {

                MessageBox.Show("O número é Par");

            } else
            {
                MessageBox.Show("O número é Impar");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
