using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_V2
{
    public partial class Logiciel : Form
    {
        public Logiciel()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.Ajouterclient ajouterclient;
            ajouterclient = new Logiciel_V2.Ajouterclient();
            ajouterclient.MdiParent = this;
            ajouterclient.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.Modifierclient modifierclient;
            modifierclient = new Logiciel_V2.Modifierclient();
            modifierclient.MdiParent = this;
            modifierclient.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.Consulterclient consulterclient;
            consulterclient = new Logiciel_V2.Consulterclient();
            consulterclient.MdiParent = this;
            consulterclient.Show();
        }

        private void parTypeDeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.CAclient Caclient;
            Caclient = new Logiciel_V2.CAclient();
            Caclient.MdiParent = this;
            Caclient.Show();
        }

        private void parFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.Cafournisseur Cafournisseur;
            Cafournisseur = new Logiciel_V2.Cafournisseur();
            Cafournisseur.MdiParent = this;
            Cafournisseur.Show();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.CAtotal Catotal;
            Catotal = new Logiciel_V2.CAtotal();
            Catotal.MdiParent = this;
            Catotal.Show();
        }

        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.Catalogue Catalogue;
            Catalogue = new Logiciel_V2.Catalogue();
            Catalogue.MdiParent = this;
            Catalogue.Show();
        }

        private void produitsCommandésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logiciel_V2.Produitcommandes Prodcommandes;
            Prodcommandes = new Logiciel_V2.Produitcommandes();
            Prodcommandes.MdiParent = this;
            Prodcommandes.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Logiciel_V2.creercommande creercommande;
            creercommande = new Logiciel_V2.creercommande();
            creercommande.MdiParent = this;
            creercommande.Show();
        }

        private void ajouterToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Logiciel_V2.ajouterproduit newproduit;
            newproduit = new Logiciel_V2.ajouterproduit();
            newproduit.MdiParent = this;
            newproduit.Show();
        }

        private void Logiciel_Load(object sender, EventArgs e)
        {

        }
    }
}
