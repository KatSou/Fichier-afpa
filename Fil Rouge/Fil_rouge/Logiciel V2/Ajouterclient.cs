using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BDD;


namespace Logiciel_V2
{
    public partial class Ajouterclient : Form
    {
        public Ajouterclient()
        {
            InitializeComponent();
        }

        Client_fr repo;

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
                Regex ex = new Regex(@"[a-zA-Z0-9._-]{2,64}@([a-zA-Z0-9-]{2,252}\.[a-zA-Z.]{2,6})");

                if (ex.IsMatch(textBox7.Text) == true)
                {
                    textBox7.BackColor = Color.White;
                    button1.Visible = true;
            }
                else
                {
                    textBox7.BackColor = Color.Red;
                    button1.Visible = false;
                }                
            
        }

        private void Ajouterclient_Load(object sender, EventArgs e)
        {
            repo = new Client_fr("server=.;database=Fil_rouge;integrated security = true");
            radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^([a-zA-Z '-]+)$");

            if (ex.IsMatch(textBox1.Text) == true)
            {
                textBox1.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client cli = new Client();            
            cli.client_nom = textBox1.Text;
            cli.client_prenom = textBox2.Text;
            cli.client_telephone = textBox6.Text;
            cli.client_mail = textBox7.Text;            
            cli.prix_coef = Double.Parse(textBox9.Text);
            cli.pro_siret = textBox16.Text;
            cli.pro_raison = textBox17.Text;

            if (radioButton1.Checked)
            {
                cli.client_categorie = "1";
                cli.pro_siret = "";
                cli.pro_raison = "";
                cli.type_reglement = "Particulier";
            }
            if (radioButton2.Checked)
            {
                cli.client_categorie = "2";
                cli.type_reglement = "Professionnel";

            }

            Adresse add = new Adresse();
            add.client_adresse = textBox13.Text;
            add.client_code_postal = textBox12.Text;
            add.client_ville = textBox11.Text;
            add.client_facturation_adresse = textBox18.Text;
            add.client_facturation_code_postal = textBox15.Text;
            add.client_facturation_ville = textBox14.Text;
            add.client_livraison_adresse = textBox3.Text;
            add.client_livraison_code_postal = textBox4.Text;
            add.client_livraison_ville = textBox5.Text;

            repo.Ajouterclient(cli, add);
            MessageBox.Show("Client ajouté", "Réussi", MessageBoxButtons.OK);

            Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"[0-9]{5}");

            if (ex.IsMatch(textBox12.Text) == true)
            {
                textBox12.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox12.BackColor = Color.Red;
                button1.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox18.Text = textBox13.Text;
            textBox15.Text = textBox12.Text;
            textBox14.Text = textBox11.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox13.Text;
            textBox4.Text = textBox12.Text;
            textBox5.Text = textBox11.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^([a-zA-Z '-]+)$");

            if (ex.IsMatch(textBox2.Text) == true)
            {
                textBox2.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                button1.Visible = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"(0|(\\+33)|(0033))[1-9][0-9]{8}");

            if (ex.IsMatch(textBox6.Text) == true)
            {
                textBox6.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox6.BackColor = Color.Red;
                button1.Visible = false;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^([a-zA-Z '-]+)$");

            if (ex.IsMatch(textBox11.Text) == true)
            {
                textBox11.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox11.BackColor = Color.Red;
                button1.Visible = false;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"[0-9]{14}");

            if (ex.IsMatch(textBox16.Text) == true)
            {
                textBox16.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox16.BackColor = Color.Red;
                button1.Visible = false;
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^([a-zA-Z '-]+)$");

            if (ex.IsMatch(textBox17.Text) == true)
            {
                textBox17.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox17.BackColor = Color.Red;
                button1.Visible = false;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^[0-9]{1,2}\,[0-9]{2}$");

            if (ex.IsMatch(textBox9.Text) == true)
            {
                textBox9.BackColor = Color.White;
                button1.Visible = true;
            }
            else
            {
                textBox9.BackColor = Color.Red;
                button1.Visible = false;
            }
        }
    }
}
