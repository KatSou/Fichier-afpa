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
    public partial class CAclient : Form
    {
        divers repo = new divers();
        public CAclient()
        {
            InitializeComponent();
        }

        private void CAclient_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double a = repo.catotal();
            double b = repo.catotalclient(1);
            double c = Math.Round(((b / a)*100),2);

            textBox2.Text = repo.nb_client(1).ToString();
            textBox3.Text = repo.ca(1).ToString();
            textBox4.Text = repo.catotalclient(1).ToString();
            textBox5.Text = c.ToString()+"%";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double a = repo.catotal();
            double b = repo.catotalclient(2);
            double c = Math.Round(((b / a)*100),2);
            textBox2.Text = repo.nb_client(2).ToString();
            textBox3.Text = repo.ca(2).ToString();
            textBox4.Text = repo.catotalclient(2).ToString();
            textBox5.Text = c.ToString()+"%";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextAlignChanged(object sender, EventArgs e)
        {

        }
    }
}
