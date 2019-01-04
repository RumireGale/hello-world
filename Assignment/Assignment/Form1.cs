using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string SetOutValue = "";
        private void btn_FindPath_Click(object sender, EventArgs e)
        {
            Guide g = new Guide();
            Guide t = new Transfer();
            string msg = "";
            msg = g.Guidance(combo_Starting.Text, combo_Destination.Text);
            if (msg.Contains("Error1"))
            {
                MessageBox.Show("Please select an input for your Starting Station");
                combo_Starting.Focus();
            }
            else
            {
                if (msg.Contains("Error2"))
                {
                    MessageBox.Show("Please select an input for your Destination Station");
                    combo_Destination.Focus();
                }
                else
                {
                    if (msg.Contains("Error3"))
                    {
                        MessageBox.Show("Please select a different Starting Station from your Destination Vice-Versa");
                    }
                    else
                    {
                        if (msg.Contains("Error4"))
                        {
                            msg = t.Guidance(combo_Starting.Text, combo_Destination.Text);
                            combo_Destination.Focus();
                        }
                    }
                }
            }
            SetOutValue = msg;
            Form2 outform = new Form2();
            this.Hide();
            outform.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combo_Destination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_Starting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
