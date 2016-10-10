using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDD;


namespace Logiciel_V2
{
    public partial class Consulterclient : Form
    {
        public Consulterclient()
        {
            InitializeComponent();
        }
        Client_fr repo = new Client_fr("server=.;database=Fil_rouge;integrated security = true");
        commande_client commande = new commande_client("server=.;database=Fil_rouge;integrated security = true");
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            if (textBox2.Text != "")
            {
                listBox1.DataSource = repo.Rechercherclient(textBox2.Text);
            }
            if (textBox1.Text != "")
            {
                Client cli = repo.Afficher(id);
                listBox1.Items.Add(cli.client_reference + " " + cli.client_nom + " " + cli.client_prenom + " " + cli.client_mail);
            }
        }
        private void Consulterclient_Load(object sender, EventArgs e)
        {
            // Cette ligne de code charge les données dans la table 'fil_rougeDataSet.Client'.
            this.clientTableAdapter.Fill(this.fil_rougeDataSet.Client);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
