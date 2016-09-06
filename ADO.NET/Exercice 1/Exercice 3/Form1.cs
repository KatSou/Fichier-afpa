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


namespace Exercice_3
{
    public partial class Form1 : Form
    {
        SqlConnection connect;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader resultat;
            resultat = GetEntCom(connect, comboBox1.SelectedItem.ToString());
            while (resultat.Read())
            {
                listBox1.Items.Add(resultat["NUMCOM"].ToString());
                listBox1.Items.Add(resultat["DATCOM"].ToString());
                listBox1.Items.Add(resultat["OBSCOM"].ToString());
            }
            resultat.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection("server=(local); integrated security = true; database = papyrus");
            connect.Open();

            SqlCommand requete = new SqlCommand("select * from stg02.FOURNIS", connect);
            SqlDataReader resultat = requete.ExecuteReader();
            while (resultat.Read())
            {
                comboBox1.Items.Add(resultat["NOMFOU"].ToString());
            }
            resultat.Close();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static SqlDataReader GetEntCom(SqlConnection connect, string nom)
        {
            string sql = "select NUMCOM,OBSCOM,DATCOM from stg02.ENTCOM join stg02.FOURNIS on stg02.ENTCOM.NUMFOU = stg02.FOURNIS.NUMFOU where NOMFOU ='" + nom + "'";
            Console.WriteLine(sql);
            SqlCommand requete = new SqlCommand(sql, connect);
            SqlDataReader resultat = requete.ExecuteReader();
            return resultat;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
