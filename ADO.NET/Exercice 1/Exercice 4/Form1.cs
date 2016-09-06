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
using System.Text.RegularExpressions;

namespace Exercice_4
{
    public partial class Form1 : Form
    {
        SqlConnection connect;
        public Form1()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            connect = new SqlConnection("server=(local); integrated security=true; database=papyrus");
            connect.Open();

            SqlCommand requete1 = new SqlCommand("Select max(NUMFOU)from stg02.FOURNIS",connect);
            a = (int)requete1.ExecuteScalar();
            a += 1;
            


            SqlCommand requete = new SqlCommand("insert into stg02.FOURNIS(NUMFOU,NOMFOU,RUEFOU,POSFOU,VILFOU,CONFOU,SATISF) values (@NUMFOU,@NOMFOU,@RUEFOU,@POSFOU,@VILFOU,@CONFOU,@SATISF)", connect);
            requete.Parameters.AddWithValue("@NUMFOU", a.ToString());
            requete.Parameters.AddWithValue("@NOMFOU", textBox1.Text);
            requete.Parameters.AddWithValue("@RUEFOU", textBox2.Text);
            requete.Parameters.AddWithValue("@POSFOU", textBox3.Text);
            requete.Parameters.AddWithValue("@VILFOU", textBox4.Text);
            requete.Parameters.AddWithValue("@CONFOU", textBox5.Text);
            requete.Parameters.AddWithValue("@SATISF", trackBar1.Value.ToString());
            requete.ExecuteNonQuery();
            connect.Close();

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^[A-Za-z]{1,30}$");
            if (ex.IsMatch(textBox1.Text) == true)
            {
                textBox1.BackColor = Color.White;
                label6.ForeColor = Color.Green;
                label6.Text = "Correct";
                label6.Visible = true;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                label6.ForeColor = Color.Red;
                label6.Text = "Erreur";
                label6.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex("[0-9]{1,5}(?:(?:[,. ]){1}[-a-zA-Zàâäéèêëïîôöùûüç]+)+");
            if (ex.IsMatch(textBox2.Text) == true)
            {
                textBox2.BackColor = Color.White;
                label6.ForeColor = Color.Green;
                label6.Text = "Correct";
                label6.Visible = true;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                label6.ForeColor = Color.Red;
                label6.Text = "Erreur";
                label6.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^(F -)?((2[A|B])|[0-9]{2})[0-9]{3}$");
            if (ex.IsMatch(textBox3.Text) == true)
            {
                textBox3.BackColor = Color.White;
                label6.ForeColor = Color.Green;
                label6.Text = "Correct";
                label6.Visible = true;
            }
            else
            {
                textBox3.BackColor = Color.Red;
                label6.ForeColor = Color.Red;
                label6.Text = "Erreur";
                label6.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^[A-Za-z]{1,30}$");
            if (ex.IsMatch(textBox4.Text) == true)
            {
                textBox4.BackColor = Color.White;
                label6.ForeColor = Color.Green;
                label6.Text = "Correct";
                label6.Visible = true;
            }
            else
            {
                textBox4.BackColor = Color.Red;
                label6.ForeColor = Color.Red;
                label6.Text = "Erreur";
                label6.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
