﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "+":
                    lblResult.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
                    break;
                case "-":
                    lblResult.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
                    break;
                case "*":
                    lblResult.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
                    break;
                case "/":
                    lblResult.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
                    break;
            }
        }
        private void OnOparetors_click(object sender, EventArgs e)
        {
            comboBox1.Text = ((Button)sender).Text;
            // ((Button)sender).Text;
        }
       
    }
 

}
