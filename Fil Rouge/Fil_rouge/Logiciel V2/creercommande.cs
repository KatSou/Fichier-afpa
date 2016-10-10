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
    public partial class creercommande : Form
    {

        List<Produits> Panier = new List<Produits>();

        public creercommande()
        {
            InitializeComponent();

        }
        Client_fr repo = new Client_fr("server=.;database=Fil_rouge;integrated security = true");
        produit repo1 = new produit("server=.;database=Fil_rouge;integrated security = true");
        int bouton = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            switch (bouton)
            {
                case 0:
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    groupBox3.Location = groupBox2.Location;
                    bouton++;
                    button5.Visible = true;
                    break;
                case 1:
                    groupBox3.Visible = false;
                    groupBox4.Visible = true;
                    groupBox4.Location = groupBox2.Location;
                    bouton++;
                    button5.Visible = true;
                    button2.Text = "Terminer";

                    break;
                case 2:
                    groupBox4.Visible = false;
                    groupBox5.Visible = true;
                    groupBox5.Location = groupBox2.Location;
                    bouton++;
                    button5.Text = "Modifier";
                    button2.Visible = false;

                    break;

                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void creercommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'fil_rougeDataSet1.Produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produitsTableAdapter.Fill(this.fil_rougeDataSet1.Produits);
            this.Width = 930;
            this.Height = 655;
            button5.Visible = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MultiSelect = false;
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (bouton)
            {
                case 1:
                    groupBox2.Visible = true;
                    groupBox3.Visible = false;
                    bouton--;
                    button5.Visible = false;
                    break;
                case 2:
                    groupBox3.Visible = true;
                    groupBox4.Visible = false;
                    bouton--;
                    button2.Text = "Suivant";
                    break;
                case 3:
                    groupBox4.Visible = true;
                    groupBox5.Visible = false;
                    bouton--;
                    button2.Visible = true;
                    button5.Text = "Précedent";
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = textBox1.Text;

            if (id == "")
            {
                MessageBox.Show("ID non valide !");
            }
            else
            {
                Client cli = repo.Afficher(id);
                Adresse adresse = repo.Afficheradd(id);

                int cat = Convert.ToInt32(cli.client_categorie);

                if (cat == 2)
                {
                    groupBox1.Visible = true;
                }
                else if (cat == 1)
                {
                    groupBox1.Visible = false;
                }

                textBox8.Text = cli.client_reference.ToString();
                textBox10.Text = cli.client_nom.ToString();
                textBox2.Text = cli.client_prenom.ToString();
                textBox6.Text = cli.client_telephone.ToString();
                textBox9.Text = cli.prix_coef.ToString();
                textBox16.Text = cli.pro_siret.ToString();
                textBox17.Text = cli.pro_raison.ToString();
                textBox13.Text = adresse.client_adresse.ToString();
                textBox12.Text = adresse.client_code_postal.ToString();
                textBox11.Text = adresse.client_ville.ToString();
                textBox18.Text = adresse.client_facturation_adresse.ToString();
                textBox15.Text = adresse.client_facturation_code_postal.ToString();
                textBox14.Text = adresse.client_facturation_ville.ToString();
                textBox3.Text = adresse.client_livraison_adresse.ToString();
                textBox4.Text = adresse.client_livraison_code_postal.ToString();
                textBox5.Text = adresse.client_livraison_ville.ToString();
            }


            /* Client cli = repo.Afficher(id);
             Adresse adresse = repo.Afficheradd(id);

             int cat = Convert.ToInt32(cli.client_categorie);

            if (cat == 2)
             {
                 groupBox1.Visible = true;
             }
            else if ( cat == 1)
             {
                 groupBox1.Visible = false;
             }

             textBox8.Text = cli.client_reference.ToString();
             textBox10.Text = cli.client_nom.ToString();
             textBox2.Text = cli.client_prenom.ToString();
             textBox6.Text = cli.client_telephone.ToString();
             textBox9.Text = cli.prix_coef.ToString();
             textBox16.Text = cli.pro_siret.ToString();
             textBox17.Text = cli.pro_raison.ToString();
             textBox13.Text = adresse.client_adresse.ToString();
             textBox12.Text = adresse.client_code_postal.ToString();
             textBox11.Text = adresse.client_ville.ToString();
             textBox18.Text = adresse.client_facturation_adresse.ToString();
             textBox15.Text = adresse.client_facturation_code_postal.ToString();
             textBox14.Text = adresse.client_facturation_ville.ToString();
             textBox3.Text = adresse.client_livraison_adresse.ToString();
             textBox4.Text = adresse.client_livraison_code_postal.ToString();
             textBox5.Text = adresse.client_livraison_ville.ToString(); */



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.MultiSelect = false;
            
                
            if (comboBox1.SelectedItem.ToString() != "")
            {
                dataGridView2.DataSource = repo1.Rechercherproduit(comboBox1.SelectedItem.ToString());

                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.Columns[8].Visible = false;


            }


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MultiSelect = false;

            
            Panier.Add(repo1.Rechercherproduitid(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()))[0]);

            dataGridView1.DataSource = Panier.ToList();

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            

            //dataGridView1.Rows.Add(repo1.Rechercherproduitid(Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString())));




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
