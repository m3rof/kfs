namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.ReadOnly = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox12.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox5.Text);
            int f = int.Parse(textBox6.Text);
            int g = int.Parse(textBox7.Text);
            int h = int.Parse(textBox9.Text);
            int i = int.Parse(textBox10.Text);
            int j = int.Parse(textBox11.Text);
            textBox4.Text = ((a + b + c) / 3).ToString();
            textBox8.Text = ((d + f + g) / 3).ToString();
            textBox12.Text = ((h + i + j) / 3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox4.Text);
            int n = int.Parse(textBox8.Text);
            int o = int.Parse(textBox12.Text);

            if (m > n && m > o)
            {
                MessageBox.Show("The Value is =" + m);
            }
            if (n > m && n > o)
            {
                MessageBox.Show("The Value is =" + n);
            }
            if (o > n && o > m)
            {
                MessageBox.Show("The Value is =" + o);
            }
        }
    }
}