using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lodyon
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z = int.Parse(textBox6.Text);
            if (z > 5000000)
            {
                z = ((z * 35) / 100);
            }
            else if (z > 2000000)
            {
                z = ((z * 30) / 100);
            }
            else if (z > 1000000)
            {
                z = ((z * 25) / 100);
            }
            else if (z > 750000)
            {
                z = ((z * 20) / 100);
            }
            else if (z > 500000)
            {
                z = ((z * 15) / 100);
            }
            else if (z > 300000)
            {
                z = ((z * 10) / 100);
            }
            else if (z > 150000)
            {
                z = ((z * 5) / 100);
            }
            else
            {
                z = (0);
            }
            textBox7.Text = z.ToString();
        }
    }
}
