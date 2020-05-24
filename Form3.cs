using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lodyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int edu = int.Parse(textBox15.Text);
            int hos = int.Parse(textBox11.Text);
            int sport = int.Parse(textBox12.Text);
            int publ = int.Parse(textBox13.Text);
            int pabuek = int.Parse(textBox14.Text);
            int thuapai = int.Parse(textBox16.Text);
            int prayuth = int.Parse(textBox17.Text);
            int raidai = int.Parse(textBox4.Text);
            int suudraidai;
            int final;
            int q = 0;
            int p1;
            int p2;
            int p3;
            int p4;
            int p5;
            int p6;
            int p7;

            p1 = (edu * 2);
            textBox24.Text = p1.ToString();
            p2 = (hos * 2);
            textBox23.Text = p2.ToString();
            p3 = (sport * 2);
            textBox22.Text = p3.ToString();
            p4 = (publ * 2);
            textBox21.Text = p4.ToString();
            p5 = pabuek;
            textBox20.Text = p5.ToString();
            p6 = thuapai;
            textBox19.Text = p6.ToString();
            p7 = prayuth;
            textBox18.Text = p7.ToString();

            suudraidai = (raidai * 10) / 100;

            final = (p1 + p2 + p3 + p4 + p5 + p6 + p7);
            if (final > suudraidai)
            {
                q = suudraidai;
            }
            else if (final < suudraidai)
            {
                q = final;
            }
            textBox25.Text = q.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int raidai = int.Parse(textBox4.Text);
            int q = int.Parse(textBox25.Text);
            int ngernsuthi;
            {
                ngernsuthi = (raidai - q);
                textBox26.Text = ngernsuthi.ToString();
                Form4 f4 = new Form4();
                f4.textBox4.Text = textBox26.Text;
                f4.Show();
                this.Close();
            }

            
        }
    }
}
