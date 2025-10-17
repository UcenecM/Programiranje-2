namespace RačunjesKOMPFORM
{
    public partial class Form1 : Form
    {
        Kompleksno prvo;
        Kompleksno drugo;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            prvo = new Kompleksno(a, b);
            drugo = new Kompleksno(c, d);

            label7.Text = (prvo + drugo).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            prvo = new Kompleksno(a, b);
            drugo = new Kompleksno(c, d);

            label7.Text = (prvo - drugo).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            prvo = new Kompleksno(a, b);
            drugo = new Kompleksno(c, d);

            label7.Text = (prvo * drugo).ToString();
        }
    }
}
