using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lodyon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int shforTH = int.Parse(numericUpDown1.Text);
            int shstuport = int.Parse(numericUpDown2.Text);
            int shbook = int.Parse(numericUpDown3.Text);
            int shotop = int.Parse(numericUpDown4.Text);
            int gomain = int.Parse(numericUpDown5.Text);
            int gorong = int.Parse(numericUpDown6.Text);
            int house = int.Parse(numericUpDown7.Text);
            int car = int.Parse(numericUpDown8.Text);
            int final;
            int q = 0;
            int p = 0;

            if ((gomain + gorong) < 20000)
            {
                q = (gomain + gorong);
            }
            else if ((gomain + gorong) > 20001)
            {
                q = 20000;
            }
            if ((house + car) < 100000)
            {
                p = (house + car);
            }
            else if ((house + car) > 100001)
            {
                p = 100000;
            }

            final =shforTH + shbook + shstuport + shotop + q + p;
            textBox5.Text = final.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int raidai = int.Parse(textBox4.Text);
            int final = int.Parse(textBox5.Text);
            int ngern;
            ngern = raidai - final;

            textBox6.Text = ngern.ToString();
            Form7 f7 = new Form7();
            f7.textBox6.Text = textBox6.Text;
            f7.Show();
            this.Close();
        }
    }
}
