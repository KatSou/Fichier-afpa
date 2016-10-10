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
    public partial class ajouterproduit : Form
    {
        public ajouterproduit()
        {
            InitializeComponent();
        }
        produit repo; 

        private void button1_Click(object sender, EventArgs e)
        {

            Produits prod = new Produits();
            prod.produit_nom = textBox1.Text;
            prod.produit_libelle_court = textBox2.Text;
            prod.produit_libelle_long = textBox3.Text;
            prod.produit_rubrique = textBox4.Text;
            prod.produit_stock = Convert.ToInt32(textBox9.Text);
            prod.produit_photo = textBox5.Text;
            prod.prix_achat_initial = Convert.ToInt32(textBox6.Text);
            prod.prix_vente = Convert.ToInt32(textBox7.Text);
            prod.taux_tva = Convert.ToDouble(textBox8.Text);

            repo.Ajouterproduits(prod);
            MessageBox.Show("Produit ajouté", "Réussi", MessageBoxButtons.OK);

            Close();
        }

        private void ajouterproduit_Load(object sender, EventArgs e)
        {
            repo = new produit("server=.;database=Fil_rouge;integrated security = true");
        }
    }
}
