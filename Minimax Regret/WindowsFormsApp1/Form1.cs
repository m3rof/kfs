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
            int max1;
            int max2;
            int max3;



            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox4.Text);
            c = int.Parse(textBox7.Text);
            d = int.Parse(textBox2.Text);
            j = int.Parse(textBox5.Text);
            f = int.Parse(textBox8.Text);
            g = int.Parse(textBox3.Text);
            h = int.Parse(textBox6.Text);
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



            textBox24.Text = (int.Parse(textBox10.Text) - int.Parse(textBox1.Text)).ToString();
            textBox21.Text = (int.Parse(textBox10.Text) - int.Parse(textBox4.Text)).ToString();
            textBox18.Text = (int.Parse(textBox10.Text) - int.Parse(textBox7.Text)).ToString();

            textBox23.Text = (int.Parse(textBox11.Text) - int.Parse(textBox2.Text)).ToString();
            textBox20.Text = (int.Parse(textBox11.Text) - int.Parse(textBox5.Text)).ToString();
            textBox17.Text = (int.Parse(textBox11.Text) - int.Parse(textBox8.Text)).ToString();

            textBox22.Text = (int.Parse(textBox12.Text) - int.Parse(textBox3.Text)).ToString();
            textBox19.Text = (int.Parse(textBox12.Text) - int.Parse(textBox6.Text)).ToString();
            textBox16.Text = (int.Parse(textBox12.Text) - int.Parse(textBox9.Text)).ToString();



            int v1 = int.Parse(textBox24.Text);
            int v2 = int.Parse(textBox21.Text);
            int v3 = int.Parse(textBox18.Text);

            int v4 = int.Parse(textBox23.Text);
            int v5 = int.Parse(textBox20.Text);
            int v6 = int.Parse(textBox17.Text);

            int v7 = int.Parse(textBox22.Text);
            int v8 = int.Parse(textBox19.Text);
            int v9 = int.Parse(textBox16.Text);

            int max5;
            int max6;
            int max7;
            int min;



            if (v1 > v4)
                max5 = a;
            else max5 = b;
            if (max5 < v7)
                max5 = v7;
            textBox15.Text = max5.ToString();



            if (v2 > v5)
                max6 = v2;
            else max6 = v5;
            if (max6 < v8)
                max6 = v8;
            textBox14.Text = max6.ToString();



            if (v3 > v6)
                max7 = v3;
            else max7 = v6;
            if (max7 < v9)
                max7 = v9;
            textBox13.Text = max7.ToString();



            if (max5 < max6)
                min = max5;
            else min = max6;
            if (min > max7)
                min = max7;
            textBox25.Text = min.ToString();

        }
    }
}
