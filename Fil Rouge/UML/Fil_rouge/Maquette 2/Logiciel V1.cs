using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Maquette_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquette.créerficheclient cfp;
            cfp = new Maquette.créerficheclient();
            cfp.MdiParent = this;
            cfp.Show();
        }

        private void consulterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquette.saisiecodeclient scc;
            scc = new Maquette.saisiecodeclient();
            scc.MdiParent = this;
            scc.Show();
        }

        private void chiffreDaffaireClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquette.CAclient CAC;
            CAC = new Maquette.CAclient();
            CAC.MdiParent = this;
            CAC.Show();
        }

        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquette.Catalogue CAT;
            CAT = new Maquette.Catalogue();
            CAT.MdiParent = this;
            CAT.Show();
        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiffreDaffaireFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquette.CAfournisseur CAF;
            CAF = new Maquette.CAfournisseur();
            CAF.MdiParent = this;
            CAF.Show();
        }

        private void nouvelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquette.Fichecommande Fcom;
            Fcom = new Maquette.Fichecommande();
            Fcom.MdiParent = this;
            Fcom.Show();
        }

        private void listeProduitCommandéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquette.listedesporduitscommandés LDPP;
            LDPP = new Maquette.listedesporduitscommandés();
            LDPP.MdiParent = this;
            LDPP.Show();
        }
    }
}
