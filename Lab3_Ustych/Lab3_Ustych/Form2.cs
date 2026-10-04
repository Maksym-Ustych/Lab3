using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Ustych
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            label2.Text = "Сума: " + sum.ToString("F5");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
