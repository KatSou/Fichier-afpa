using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_3_5
{
    public partial class Form1 : Form
    {
        public double t, n,k;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tauxannuel();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tauxannuel();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tauxannuel();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Mensuelle")
            {
                n = hScrollBar1.Value;
                label8.Text = n.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "Bimestrielle")
            {
                n = hScrollBar1.Value / 2;
                label8.Text = n.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "Trimestrielle")
            {
                n = hScrollBar1.Value / 3;
                label8.Text = n.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "Semestrielle")
            {
                n = hScrollBar1.Value / 6;
                label8.Text = n.ToString();
            }
            else
            {
                n = hScrollBar1.Value / 12;
                label8.Text = n.ToString();
            }
            tauxannuel();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Mensuelle")
            {
                n = hScrollBar1.Value;
                label8.Text = n.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "Bimestrielle")
            {
                n = hScrollBar1.Value / 2;
                label8.Text = n.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "Trimestrielle")
            {
                n = hScrollBar1.Value / 3;
                label8.Text = n.ToString();
            }
            else if ((string)comboBox1.SelectedItem == "Semestrielle")
            {
                n = hScrollBar1.Value / 6;
                label8.Text = n.ToString();
            }
            else
            {
                n = hScrollBar1.Value / 12;
                label8.Text = n.ToString();
            }
            label9.Text = hScrollBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = Int32.Parse(textBox2.Text);
            Console.WriteLine(k);
            Console.WriteLine(t);
            Console.WriteLine(n);
            label6.Text = (k * (t / (1 - Math.Pow((1 + t), -n)))).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void tauxannuel()
        {

            if (radioButton1.Checked == true)
            {
                if ((string)comboBox1.SelectedItem == "Mensuelle")
                {
                    t = 0.07 / 12.0;
                }
                if ((string)comboBox1.SelectedItem == "Bimestrielle")
                {
                    t = 0.07 / 6.0;
                }
                if ((string)comboBox1.SelectedItem == "Trimestrielle")
                {
                    t = 0.07 / 4.0;
                }
                if ((string)comboBox1.SelectedItem == "Semestrielle")
                {
                    t = 0.07 / 2.0;
                }
                if ((string)comboBox1.SelectedItem == "Annuelle")
                {
                    t = 0.07 / 1.0;
                }
            }
            if (radioButton2.Checked == true)
            {
                if ((string)comboBox1.SelectedItem == "Mensuelle")
                {
                    t = 0.08 / 12.0;
                }
                if ((string)comboBox1.SelectedItem == "Bimestrielle")
                {
                    t = 0.08 / 6.0;
                }
                if ((string)comboBox1.SelectedItem == "Trimestrielle")
                {
                    t = 0.08 / 4.0;
                }
                if ((string)comboBox1.SelectedItem == "Semestrielle")
                {
                    t = 0.08 / 2.0;
                }
                if ((string)comboBox1.SelectedItem == "Annuelle")
                {
                    t = 0.08 / 1.0;
                }
            }
            if (radioButton3.Checked == true)
            {
                if ((string)comboBox1.SelectedItem == "Mensuelle")
                {
                    t = 0.09 / 12.0;
                }
                if ((string)comboBox1.SelectedItem == "Bimestrielle")
                {
                    t = 0.09 / 6.0;
                }
                if ((string)comboBox1.SelectedItem == "Trimestrielle")
                {
                    t = 0.09 / 4.0;
                }
                if ((string)comboBox1.SelectedItem == "Semestrielle")
                {
                    t = 0.09 / 2.0;
                }
                if ((string)comboBox1.SelectedItem == "Annuelle")
                {
                    t = 0.09 / 1.0;
                }
            }
        }

    }
}
