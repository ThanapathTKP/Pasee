using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lodyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int raidai = int.Parse(textBox9.Text);
            int lastresult62 = int.Parse(textBox5.Text);
            int suthi;

           
            suthi = (raidai - lastresult62);
            textBox10.Text = suthi.ToString();
            Form3 f3 = new Form3();
            f3.textBox4.Text = textBox10.Text;
            f3.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int raidai = int.Parse(textBox9.Text);
            int lastresult58 = int.Parse(textBox3.Text);
            int suthi;

            suthi = (raidai - lastresult58);
            textBox14.Text = suthi.ToString();
            Form3 f3 = new Form3();
            f3.textBox4.Text = textBox14.Text;
            f3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int pricehouse62 = int.Parse(numericUpDown2.Text);
            int pasee = int.Parse(numericUpDown3.Text);
            int result62;
            int lastresult62;
            int u = 0;
            
            if (pricehouse62 < 200000)
            {
                u = pricehouse62;
            }
            else if (pricehouse62 < 5000001)
            {
                u = 200000;
            }
            
            result62 = u;
            textBox4.Text = result62.ToString();
            lastresult62 = (pasee + u);
            textBox5.Text = lastresult62.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pricehouse58 = int.Parse(numericUpDown1.Text);
            int pasee = int.Parse(numericUpDown3.Text);
            int lastresult58;
            int result58;
            int result1y;

            result58 = (pricehouse58 * 20) / 100;
            textBox1.Text = result58.ToString();
            result1y = (result58 / 5);
            textBox2.Text = result1y.ToString();
            lastresult58 = (pasee + result1y);
            textBox3.Text = lastresult58.ToString();

           
        }
    }
}
