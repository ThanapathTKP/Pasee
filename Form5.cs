using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lodyon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox4.Text);
            int other = int.Parse(textBox5.Text);
            int tip = int.Parse(textBox6.Text);
            int raidai;
            {
                raidai = ((month * 12) + other + tip);
                textBox7.Text = raidai.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phakcun = int.Parse(numericUpDown2.Text);
            int pikarn = int.Parse(numericUpDown3.Text);
            int childbf61 = int.Parse(numericUpDown4.Text);
            int child61one = int.Parse(numericUpDown1.Text);
            int child61 = int.Parse(numericUpDown6.Text);

            int q1;
            int q2 = 0;
            int q3 = 0;
            int q4 = 0;
            int dadmom1 = 0;
            int dadmom2 = 0;
            int dadmom3 = 0;
            int dadmom4 = 0;
            int x = 0;
            int ruamdm;
            int ruamchild;
            int ruamjing;

            if (radioButton1.Checked)
            {
                x = 0;
            }
            else if (radioButton3.Checked)
            {
                x = 0;
            }
            else if (radioButton2.Checked)
            {
                x = 60000;
            }

            if (radioButton12.Checked)
            {
                dadmom1 = 30000;
            }
            else if (radioButton11.Checked)
            {
                dadmom1 = 0;
            }
            if (radioButton9.Checked)
            {
                dadmom2 = 30000;
            }
            else if (radioButton10.Checked)
            {
                dadmom2 = 0;
            }
            if (radioButton14.Checked)
            {
                dadmom3 = 30000;
            }
            else if (radioButton13.Checked)
            {
                dadmom3 = 0;
            }
            if (radioButton16.Checked)
            {
                dadmom4 = 30000;
            }
            else if (radioButton15.Checked)
            {
                dadmom4 = 0;
            }

            if (childbf61 >= 1)
            {
                q2 = childbf61 * 30000;
            }
            if (child61one == 1)
            {
                q3 = child61one * 30000;
            }
            if (child61 >= 1)
            {
                q4 = child61 * 60000;
            }

            ruamdm = dadmom1 + dadmom2 + dadmom3 + dadmom4;
            ruamchild = q2 + q3 + q4;
            q1 = pikarn * 60000;

            ruamjing = phakcun + q1 + ruamchild + x + ruamdm + 60000;
            textBox1.Text = ruamjing.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int raidai = int.Parse(textBox7.Text);
            int ruamjing = int.Parse(textBox1.Text);
            int ngernluea;
            ngernluea = raidai - ruamjing;
            textBox2.Text = ngernluea.ToString();
            Form6 f6 = new Form6();
            f6.textBox4.Text = textBox2.Text;
            f6.Show();
            this.Close();
          
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
