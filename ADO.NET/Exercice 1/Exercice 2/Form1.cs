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


namespace Exercice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=(local); integrated security = true; database = papyrus");            connect.Open();            SqlCommand requete = new SqlCommand("select * from stg02.FOURNIS where NUMFOU=" + textBox1.Text, connect);            SqlDataReader resultat = requete.ExecuteReader();            while (resultat.Read())
            {
                textBox2.Text = resultat["NOMFOU"].ToString();
                textBox3.Text = resultat["RUEFOU"].ToString();
                textBox4.Text = resultat["POSFOU"].ToString();
                textBox5.Text = resultat["VILFOU"].ToString();
                textBox6.Text = resultat["CONFOU"].ToString();
            }           
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
