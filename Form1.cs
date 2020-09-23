using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string first = textBox1.Text;
            string temp = first.Substring(0, 1); 
            first = first.Substring(1, 1).ToUpper() + first.Substring(2) + temp + "ay";

            string last = textBox2.Text;
            temp = last.Substring(0, 1);
            last = last.Substring(1, 1).ToUpper() + last.Substring(2) + temp + "ay";

            textBox3.Text = first +" " +last;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
