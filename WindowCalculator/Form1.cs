using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowCalculator
{
    public partial class Form1 : Form
    {
        ArrayList Numbers = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number t = new Number();
            t.number1 = textBox1.Text;
            t.number2 = textBox2.Text;

            string d = "";
            int a, b, c = 0;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            d = Convert.ToString(c);
            t.stringRes = textBox1.Text + " + " + textBox2.Text + " = " + d;

            Numbers.Add(t.stringRes);
            listBox1.Items.Add(t.stringRes);
        }
    }
    class Number {
        public string number1 { get; set; }
        public string number2 { get; set; }
        public string result { get; set; }
        public string stringRes { get; set; }
    }
}
