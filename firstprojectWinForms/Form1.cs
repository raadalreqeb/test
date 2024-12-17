﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstprojectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void mouseent(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void mouseup(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text=textBox1.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
