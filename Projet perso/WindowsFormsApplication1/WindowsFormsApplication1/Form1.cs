﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 1;
            while (i != 0)
            {
                System.Threading.Thread.Sleep(30000);
                Process p = new Process();
                p.StartInfo.FileName = "https://i.ytimg.com/vi/-YN6JgsR2Aw/maxresdefault.jpg";
                p.StartInfo.CreateNoWindow = true;
                p.Start();
            }

        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }
    }
}