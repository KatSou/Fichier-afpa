using System;
using System.Windows.Forms;

namespace Exercice_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0, c = comboBox1.Items.Count;
            if (c != 0)
            {
                while (i < c )
                {
                    listBox1.Items.Add(comboBox1.Items[i]);
                    i++;
                }
                comboBox1.Items.Clear();
            }
         }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0, c = listBox1.Items.Count;
            if (c != 0)
            {
                while (i < c)
                {
                    comboBox1.Items.Add(listBox1.Items[i]);
                    i++;
                }
                listBox1.Items.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a;
          if (listBox1.SelectedIndex > 0)
            {
                a = (string)listBox1.Items[listBox1.SelectedIndex - 1];
                listBox1.Items[listBox1.SelectedIndex-1]= listBox1.SelectedItem;
                listBox1.Items[listBox1.SelectedIndex] = a;
            }                               
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a;
            if (listBox1.SelectedIndex < listBox1.Items.Count-1)
            {
                a = (string)listBox1.Items[listBox1.SelectedIndex + 1];
                listBox1.Items[listBox1.SelectedIndex + 1] = listBox1.SelectedItem;
                listBox1.Items[listBox1.SelectedIndex] = a;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
            
        }
    }
}
