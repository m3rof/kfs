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
            int min1;
            int min2;
            int min3;
            int min4;



            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);
            j = int.Parse(textBox5.Text);
            f = int.Parse(textBox6.Text);
            g = int.Parse(textBox7.Text);
            h = int.Parse(textBox8.Text);
            i = int.Parse(textBox9.Text);



            if (a < b)
                min1 = a;
            else min1 = b;
            if (min1 > c)
                min1 = c;
            textBox10.Text = min1.ToString();



            if (d < j)
                min2 = d;
            else min2 = j;
            if (min2 > f)
                min2 = f;
            textBox11.Text = min2.ToString();



            if (g < h)
                min3 = g;
            else min3 = h;
            if (min3 > i)
                min3 = i;
            textBox12.Text = min3.ToString();



            if (min1 > min2)
                min4 = min1;
            else min4 = min2;
            if (min4 < min3)
                min4 = min3;
            textBox13.Text = min4.ToString();
        }
    }
}
