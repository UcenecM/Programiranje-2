namespace FRUKTAL
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double a; //kot poremikanja gere na kot x
        private int UmeriX(double xr)
        {
            return (int)Math.Round(xr * pictureBox1.Width);
        }
        private int UmeriY(double yr)
        {
            return (int)Math.Round(pictureBox1.Height - yr * pictureBox1.Height);
        }
        public void ObratLevo(double kot)
        {
            a += kot;
        }
        public void Premik(double d, Graphics g)
        {
            double xstari = x;
            double ystari = y;
            x = d * Math.Cos(a*Math.PI/180) + xstari;
            y = d * Math.Sin(a*Math.PI / 180) + ystari;
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, UmeriX(xstari), UmeriY(ystari), UmeriX(x), UmeriY(y));
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            x = 0.5;
            y = 0;
            a = 30;
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
            Premik(0.2, g);
            ObratLevo(60);
        }
    }
}
