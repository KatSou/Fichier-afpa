using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string utilisateur_motdepasse_connexion = Console.ReadLine();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string utilisateur_login_connexion = Console.ReadLine();
        }

      
        private void btnConnexion_Click(object sender, EventArgs e)
        {

        }

    }
}
