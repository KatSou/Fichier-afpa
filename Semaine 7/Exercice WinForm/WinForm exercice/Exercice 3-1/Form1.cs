using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Choix_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked== true)
            {
                label2.BackColor = Color.Red;
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true; 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.BackColor = Color.Green;
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label2.BackColor = Color.Blue;
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label2.ForeColor = Color.Red;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label2.ForeColor = Color.Green;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label2.ForeColor = Color.Blue;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label2.Text = label2.Text.ToLower();
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                label2.Text = label2.Text.ToUpper();
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }
        }
    }
}
