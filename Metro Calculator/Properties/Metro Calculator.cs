using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Metro_Calculator
{
    public partial class Metro_Calculator : MetroForm
    {
         string op_value = "";
        double txt_value=0;
        bool bool_value = false;
        public Metro_Calculator()
        {
            InitializeComponent();
        }

        private void Numeric_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || bool_value)
                textBox1.Clear();
            bool_value = false;
            Button bu = (Button)sender;
            textBox1.Text = textBox1.Text + bu.Text;
        }

        private void off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CE_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = null;
        }

        private void AC_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            op_value = "0";
            label1.Text = null;
        }
        private void operator_click(object sender, EventArgs e)
        {
                Button bu = (Button)sender;
                op_value = bu.Text;
                txt_value = double.Parse(textBox1.Text);
                bool_value = true;
                label1.Text = txt_value + "" + op_value;
        }

        private void Equal_button_click(object sender, EventArgs e)
        {
            switch (op_value)
            {
                case "+":
                    textBox1.Text = (txt_value + double.Parse(textBox1.Text)).ToString();
                    break;
                      
                case "-":
                    textBox1.Text = (txt_value - double.Parse(textBox1.Text)).ToString();
                 break;
               
                case "*":
                 textBox1.Text = (txt_value * double.Parse(textBox1.Text)).ToString();
                 break;

               case "/":
                 textBox1.Text = (txt_value / double.Parse(textBox1.Text)).ToString();
                 break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();

        }      
    }
}

