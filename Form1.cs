using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lodyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 a2 = new Form2();
            a2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 a3 = new Form3();
            a3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 a4 = new Form4();
            a4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 a5 = new Form5();
            a5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 a6 = new Form6();
            a6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 a7 = new Form7();
            a7.Show();
        }
    }
}
