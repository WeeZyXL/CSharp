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
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void cmbxcidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxestado.SelectedIndex == 0)
            {
                cmbxcidade.Items.Clear();
                cmbxcidade.Items.Add("São Paulo");
                cmbxcidade.Items.Add("Santos");
            }
            else if (cmbxestado.SelectedIndex == 1)
            {
                cmbxcidade.Items.Clear();
                cmbxcidade.Items.Add("Rio de Janeiro");
                cmbxcidade.Items.Add("Niterói");
            }
            else if (cmbxestado.SelectedIndex == 2)
            {
                cmbxcidade.Items.Clear();
                cmbxcidade.Items.Add("Belo Horizonte");
                cmbxcidade.Items.Add("Uberlândia");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estado: " + cmbxestado.Text + "\nCidade: " + cmbxcidade.Text);
        }
    }
}
