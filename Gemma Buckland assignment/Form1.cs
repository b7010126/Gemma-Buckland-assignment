﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gemma_Buckland_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_1p.Text);// This will hold the number and change "label_1p"
                hold_number = hold_number + 1; // Once the 1p is clicked it will increase by +1.
                label_1p.Text = hold_number.ToString();




            }
        }

        private void txt_credit_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_2p_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_2p.Text);// This will hold the number and change "label_2p"
                hold_number = hold_number + 1; // Once the 2p is clicked it will increase by +2.
                label_2p.Text = hold_number.ToString();

            }
        }

        private void pic_5_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_5p.Text);// This will hold the number and change "label_5p"
                hold_number = hold_number + 1; // Once the 5p is clicked it will increase by +1.
                label_5p.Text = hold_number.ToString();
            }
        }
        private void pic_10p_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_10p.Text);// This will hold the number and change "label_10p"
                hold_number = hold_number + 1; // Once the 10p is clicked it will increase by +1.
                label_10p.Text = hold_number.ToString();

            }
        }

        private void pic_20p_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_20p.Text);// This will hold the number and change "label_20p"
                hold_number = hold_number + 1; // Once the 20p is clicked it will increase by +1.
                label_20p.Text = hold_number.ToString();

            }
        }
        private void pic_50p_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_50p.Text);// This will hold the number and change "label_50p"
                hold_number = hold_number + 1; // Once the 50p is clicked it will increase by +1.
                label_50p.Text = hold_number.ToString();


            }
        }
        private void pic_100p_Click(object sender, EventArgs e)
        {


            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_100p.Text);// This will hold the number and change "label_100p"
                hold_number = hold_number + 1; // Once the 100p is clicked it will increase by +1.
                label_100p.Text = hold_number.ToString();

            }
        }
        private void pic_200p_Click(object sender, EventArgs e)
        {
            if ((txt_credit.Text) == "0" || txt_credit.Text == "") // This piece of code i have added onto txt_credit so this sets the value to "0" or null.
            {
                MessageBox.Show("Please Enter the Cost Per Credit");// This is a message box that will appear with "Please Enter the Cost Per Credit".
            }
            else
            {
                int hold_number = Convert.ToInt32(label_200p.Text);// This will hold the number and change "label_200p"
                hold_number = hold_number + 1; // Once the 200p is clicked it will increase by +1.
                label_200p.Text = hold_number.ToString();

            }
        }

    }
}