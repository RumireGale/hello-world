﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtDisplayOut.Text = Form1.SetOutValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inform = new Form1();
            this.Hide();
            inform.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 mapform = new Form3();
            this.Hide();
            mapform.ShowDialog();
            this.Close();
        }
    }
}
