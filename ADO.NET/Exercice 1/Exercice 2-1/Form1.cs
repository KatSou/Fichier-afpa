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
using DAL;


namespace Exercice_2_1
{

    public partial class Form1 : Form
    {
        ClientDAO repo;
        int a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 458;            
            repo = new ClientDAO("server=.;database=hotel;Integrated Security = True");
            listBox1.DataSource = repo.List();
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "nom";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 800;
            a = 1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 800;
            a = 2;
            string id = listBox1.SelectedValue.ToString();
            Client cli = repo.Afficher(id);
            textBox1.Text = cli.Nom;
            textBox2.Text = cli.Prenom;
            textBox3.Text = cli.Ville;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 800;
            a = 3;
            string id = listBox1.SelectedValue.ToString();
            Client cli = repo.Afficher(id);
            textBox1.Text = cli.Nom;
            textBox2.Text = cli.Prenom;
            textBox3.Text = cli.Ville;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Width = 458;
            ClientDAO repo;
            repo = new ClientDAO("server =.; database = hotel; Integrated Security = True");
            if (a == 1)
            {
                Client c = new Client();
                c.Nom = textBox1.Text.ToString();
                c.Prenom = textBox2.Text.ToString();
                c.Ville = textBox3.Text.ToString();                
                repo.Ajouter(c);
                listBox1.DataSource = repo.List();
                listBox1.ValueMember = "Id";
                listBox1.DisplayMember = "nom";
            }
            if (a == 2)
            {
                Client c = new Client();
                c.Nom = textBox1.Text.ToString();
                c.Prenom = textBox2.Text.ToString();
                c.Ville = textBox3.Text.ToString();
                repo.Modifier(c,listBox1.SelectedValue.ToString());
                listBox1.DataSource = repo.List();
                listBox1.ValueMember = "Id";
                listBox1.DisplayMember = "nom";
            }
            if (a == 3)
            {
                Client c = new Client();
                c.Nom = textBox1.Text.ToString();
                c.Prenom = textBox2.Text.ToString();
                c.Ville = textBox3.Text.ToString();
                repo.Supprimer(c,listBox1.SelectedValue.ToString());
                listBox1.DataSource = repo.List();
                listBox1.ValueMember = "Id";
                listBox1.DisplayMember = "nom";
            }
            a = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Width = 458;
        }
    }
}
