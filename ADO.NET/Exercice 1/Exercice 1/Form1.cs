using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Visible = false;                }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server="+textBox1.Text+" ; integrated security = true; database ="+textBox2.Text);

            try
            {
                connect.Open();
                label4.Text = "Open";
                textBox3.Visible = false;
            }
            catch (Exception f)
            {
                label4.Text = "Close";
                textBox3.Visible = true;
                textBox3.Text = f.Message;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=" + textBox1.Text + " ; integrated security = true; database =" + textBox2.Text);
            connect.Close();

        }
    }
}
