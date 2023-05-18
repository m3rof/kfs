using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            int j;
            int f;
            int g;
            int h;
            int i;
            int k;
            int l;
            int m;
            int max1;
            int max2;
            int max3;
            int max4;



            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);
            j = int.Parse(textBox5.Text);
            f = int.Parse(textBox6.Text);
            g = int.Parse(textBox7.Text);
            h = int.Parse(textBox8.Text);
            i = int.Parse(textBox9.Text);
           


            if (a > b)
                max1 = a;
            else max1 = b;
            if (max1 < c)
                max1 = c;
            textBox10.Text = max1.ToString();

            

            if (d > j)
                max2 = d;
            else max2 = j;
            if (max2 < f)
                max2 = f;
            textBox11.Text = max2.ToString();



            if (g > h)
                max3 = g;
            else max3 = h;
            if (max3 < i)
                max3 = i;
            textBox12.Text = max3.ToString();



            if (max1 > max2)
                max4 = max1;
            else max4 = max2;
            if (max4 < max3)
                max4 = max3;
            textBox13.Text = max4.ToString();

        }
    }
}
