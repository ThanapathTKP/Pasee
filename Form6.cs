using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lodyon
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int raidaifinal = int.Parse(textBox4.Text);
            int sangkom = int.Parse(numericUpDown1.Text);
            int cheevit = int.Parse(numericUpDown2.Text);
            int health = int.Parse(numericUpDown3.Text);
            int dadmom = int.Parse(numericUpDown4.Text);
            int feedlife = int.Parse(numericUpDown5.Text);
            int somros = int.Parse(numericUpDown6.Text);
            int q = 0;
            int p = 0;
            int outcome;

            if ((cheevit + health) > 100000)
            {
                q = 100000;
            }
            else if ((cheevit + health) < 100000)
            {
                q = cheevit + health;
            }

            if (radioButton1.Checked)
            {
                p = 0;
            }
            else if (radioButton3.Checked)
            {
                p = 0;
            }
            else if (radioButton2.Checked)
            {
                p = 10000;
            }

            outcome = raidaifinal - (sangkom + q + dadmom + feedlife + somros) + p;
            textBox5.Text = outcome.ToString();
            Form2 f2 = new Form2();
            f2.textBox9.Text = textBox5.Text;
            f2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                numericUpDown6.Enabled = false;
            }
            else
            {
                numericUpDown6.Enabled = true;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
