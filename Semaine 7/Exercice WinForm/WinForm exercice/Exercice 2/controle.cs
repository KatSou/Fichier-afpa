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

namespace Exercice_2
{
    public partial class controle : Form
    {
        public controle()
        {
            InitializeComponent();
          
        }

        private void controle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex ex = new Regex(@"^[A-Za-z]{1,30}$");
            if (ex.IsMatch(textBox1.Text) == true)
            {
                textBox1.BackColor = Color.White;
                label5.Visible = false;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                label5.Visible = true;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
                     
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Regex CP = new Regex(@"^(F -)?((2[A|B])|[0-9]{2})[0-9]{3}$");
            if (CP.IsMatch(textBox3.Text) == true)
            {
                label8.Visible = false;
                textBox4.BackColor = Color.White;
            }
            else
            {
                label8.Visible = true;
                textBox4.BackColor = Color.Red;
            }
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DateTime dt;            
            bool date = DateTime.TryParse(textBox2.Text, out dt);
           
           if (date == true)
              {
                label6.Visible = false;
                textBox2.BackColor = Color.White;
            }
           else
            {
                label6.Visible = true;
                textBox2.BackColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex montant = new Regex(@"^[0-9]+([\,|\.]{0,1}[0-9]{2}){0,1}$");
            if (montant.IsMatch(textBox3.Text) == true)
            {
                label7.Visible = false;
                textBox3.BackColor = Color.White;
            }
            else
            {
                label7.Visible = true;
                textBox3.BackColor = Color.Red;
            }
        }
    } 
}
